using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Eliza
{
    /// <summary>
    /// A rule that associates decomposition of an input string with a collection of
    /// reassembled responses.
    /// </summary>
    public class DecompReassemblyRule
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DecompReassemblyRule"/> class.
        /// </summary>
        /// <param name="decomp">How the input string should be decomposed.</param>
        /// <param name="reassembledResponses">The reassembled responses.</param>
        /// <param name="patternOfTextToStoreInMemory">The (optional) pattern of the text to store in Eliza's memory.</param>
        public DecompReassemblyRule
            (string decomp,
             List<string> reassembledResponses,
             string patternOfTextToStoreInMemory = null)
        {
            this._decomp = decomp;
            this._reassembledResponses = new List<string>();
            foreach(string reassembledResponse in reassembledResponses) {
                this._reassembledResponses.Add(reassembledResponse);
            }
            this._patternOfTextToStoreInMemory = patternOfTextToStoreInMemory;
            this._nextResponseIndex = 0;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Determines whether this instance can decompose the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="synonyms">The synonyms.</param>
        /// <param name="memory">Eliza's memory.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>
        /// <see langword="true"/> if this instance can decompose the specified input; otherwise,
        /// <see langword="false"/>.
        /// </returns>
        public bool CanDecompose
            (string input,
             Dictionary<string, List<string>> synonyms,
             Memory memory,
             ILogger logger)
        {
            logger.Info(string.Format("  DecompReassamblyRule.CanDecompose: Checking rule \"{0}\"...", this._decomp));

            // STEP 1:
            //
            // Extract each element in the decomposition definition.
            // If the decomposition was "* I AM * @SAD *", the extracted elements would be:
            //    element 1 = *
            //    element 2 = I AM
            //    element 3 = *
            //    element 4 = @SAD
            //    element 5 = *

            // For each word in the decomposition definition...
            List<string> decompElements = new List<string>();
            foreach(string word in this._decomp.Split(null)) {

                // If (1) this is the first word -or-
                //    (2) the word contains "*" -or-
                //    (3) the word is a synonym -or-
                //    (4) the previously extracted element is "*" -or-
                //    (5) the previously extracted element is a synonym
                if (!decompElements.Any() ||
                     word.Contains("*") ||
                     word.Contains("@") ||
                     (decompElements.LastOrDefault() == "*") ||
                     decompElements.LastOrDefault().Contains("@")) {

                    // Add the word to the list of elements
                    decompElements.Add(word);
                }
                else {
                    // Otherwise, concatenate the word to the last element in the list
                    string lastDecompElement = decompElements.Last();
                    lastDecompElement += " " + word;
                    decompElements[decompElements.Count - 1] = lastDecompElement;
                }
            }

            // Pad each extracted key phrase element with a space
            for(int i=0; (i < decompElements.Count); i++) {
                if (decompElements[i] != "*") {
                    decompElements[i] = string.Format(" {0} ", decompElements[i].Trim());
                }
            }

            // STEP 2:
            //
            // Next, for each decomposition element, find the corresponding text fragment
            // in the user's input.  Store these fragments in the _textElements list.

            // Pad the input with spaces
            input = string.Format(" {0} ", input.Trim());

            // Do some initialization
            bool previousDecompEleWasWildcard = false;
            int start = 0;                              // the point where we are in the user's input
            int decompEleIndex = 0;                     // which decomposition element we're considering
            this._textElements = new List<string>();    // create a fresh _textElements list

            // For each decomposition element...
            while (decompEleIndex < decompElements.Count) {
                string decompEle = decompElements[decompEleIndex];

                // If the element is "*" (which represents optional text) and this is the last element,
                // gather all remaining text and store it in the _textElements list
                if (decompEle == "*") {
                    if (decompEleIndex == decompElements.Count - 1) {
                        string textAfterLastMatchedDecompEle = input.Substring(start);
                        this._textElements.Add(textAfterLastMatchedDecompEle);
                    }
                }
                else {

                    // Otherwise, the element is a key phrase/synonym we're trying to match.
                    bool isSynonym = decompEle.Trim().StartsWith("@");
                    int decompEleStart = -1;
                    string matchedSynonym = null;

                    if (isSynonym) {

                        // Check if any of the element's synonyms are in the user's input
                        string theSynonym = decompEle.Trim();
                        foreach(string synonym in synonyms[theSynonym]) {
                            decompEleStart = input.IndexOf(" " + synonym + " ", start);
                            if (decompEleStart != -1) {
                                matchedSynonym = synonym;
                                decompEleStart++;
                                break;
                            }
                        }
                    }
                    else {
                        // Check if the element is in the user's input
                        decompEleStart = input.IndexOf(decompEle, start);
                    }

                    // If this element isn't in the user's input, return false as we don't
                    // need to continue trying to match subsequent elements.
                    if (decompEleStart == -1) {
                        return false;
                    }

                    // Since the key phrase or synonym matched, store the text before the matched element
                    // as well as the matched element itself, in the _textElements list.
                    string textBeforeMatchedDecompEle = input.Substring(start, decompEleStart - start).Trim();
                    if ((textBeforeMatchedDecompEle.Length > 0) || previousDecompEleWasWildcard) {
                        this._textElements.Add(textBeforeMatchedDecompEle);
                    }
                    this._textElements.Add(matchedSynonym == null ? decompEle.Trim() : matchedSynonym);

                    // Reposition from where we want to continue searching for elements
                    start = decompEleStart + (matchedSynonym == null ? decompEle.Length - 1 : matchedSynonym.Length);
                }
                previousDecompEleWasWildcard = decompEle == "*";
                decompEleIndex++;
            }

            // Since we haven't returned "false" from the previous loop, we've found all elements
            // and this rule has therefore matched.

            // If the rule has been asked to some of the user's input in Eliza's memory, do that.
            if (this._patternOfTextToStoreInMemory != null) {
                string textToStoreInMemory = this._patternOfTextToStoreInMemory;
                for (int i=0; (i < this._textElements.Count); i++) {
                    string textElementSymbol = "(" + (i+1).ToString() + ")";
                    if (textToStoreInMemory.Contains(textElementSymbol)) {
                        textToStoreInMemory = textToStoreInMemory.Replace(textElementSymbol, this._textElements[i]);
                    }
                }
                memory.AddText(textToStoreInMemory);
            }

            // Return true to indicate this rule matched
            Debug.Assert(decompElements.Count == this._textElements.Count);
            return true;
        }

        /// <summary>
        /// Generates a response to the user's input.
        /// </summary>
        /// <param name="input">The user's input.</param>
        /// <param name="memory">Eliza's memory.</param>
        /// <returns>
        /// The response.
        /// </returns>
        public string GenerateResponse
            (string input,
             Memory memory)
        {
            bool responseGenerated = false;
            string response = null;
            do {
                // Select the next response
                response = this._reassembledResponses[this._nextResponseIndex];
                this._nextResponseIndex++;
                if (this._nextResponseIndex == this._reassembledResponses.Count) {
                    this._nextResponseIndex = 0;
                }

                // If the response references the memory...
                string placeHolder = "($)";
                if (response.Contains(placeHolder)) {

                    // If there's text in the memory, use it to generate the response
                    if (!memory.IsEmpty()) {
                        string phrase = memory.GetOldestText();
                        response = response.Replace(placeHolder, phrase);
                        responseGenerated = true;
                    }
                }
                else {
                    // Otherwise, replace any numbered placeholders with the corresponding text
                    // elements, after transforming them
                    for (int i=0; (i < this._textElements.Count); i++) {
                        placeHolder = string.Format("({0})", i + 1);
                        if (response.Contains(placeHolder)) {
                            string transformedInputElement = StringTransformer.PostTransform(this._textElements[i]);
                            response = response.Replace(placeHolder, transformedInputElement);
                        }
                    }
                    responseGenerated = true;
                }
            }
            while (!responseGenerated);
            
            // Reduce double spaces with a single space and remove spaces before punctuation
            while(response.Contains("  ")) {
                response = response.Replace("  ", " ");
            }
            response = response.Replace(" ?", "?");
            response = response.Replace(" !", "!");
            response = response.Replace(" .", ".");
            response = response.Replace(" ,", ",");
            response = response.Trim();

            // Add an extra space after embedded punctuation
            response = response.Replace("? ", "?  ");
            response = response.Replace("! ", "!  ");
            response = response.Replace(". ", ".  ");

            // Return the response
            return response;
        }

        #endregion

        #region Fields

        /// <summary>
        /// How the input string should be decomposed.
        /// </summary>
        private string _decomp;

        /// <summary>
        /// The (optional) patern of the text to store in Eliza's memory.
        /// </summary>
        private string _patternOfTextToStoreInMemory;

        /// <summary>
        /// The text elements in the user's input.
        /// </summary>
        private List<string> _textElements;

        /// <summary>
        /// The collection of reassembled responses.
        /// </summary>
        private List<string> _reassembledResponses;

        /// <summary>
        /// Index of the next reassembled response to return.
        /// </summary>
        private int _nextResponseIndex;

        #endregion
    }
}
