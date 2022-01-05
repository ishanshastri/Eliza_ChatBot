using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// Transforms strings.
    /// </summary>
    class StringTransformer
    {
        #region Public methods

        /// <summary>
        /// Perform a pre-transformation of an input string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The pre-transformed string.</returns>
        public static string PreTransform
            (string input)
        {
            // The transformations
            Dictionary<string, string> xforms = new Dictionary<string, string>();
            xforms.Add("DONT", "DON'T");
            xforms.Add("CANNOT", "CAN'T");
            xforms.Add("CANT", "CAN'T");
            xforms.Add("WONT", "WON'T");
            xforms.Add("RECALL", "REMEMBER");
            xforms.Add("RECOLLECT", "REMEMBER");
            xforms.Add("DREAMT", "DREAMED");
            //xforms.Add("DREAMS", "DREAM");
            xforms.Add("MAYBE", "PERHAPS");
            xforms.Add("HOW", "WHAT");
            //xforms.Add("WHEN", "WHAT");
            xforms.Add("WHO", "WHAT");
            xforms.Add("CERTAINLY", "YES");
            xforms.Add("MACHINE", "COMPUTER");
            xforms.Add("COMPUTERS", "COMPUTER");
            // xforms.Add("WERE", "WAS");
            xforms.Add("YOU'RE", "YOU ARE");
            xforms.Add("I'M", "I AM");
            xforms.Add("SAME", "ALIKE");

            // For each word in the input
            string[] words = input.Split(null);
            List<string> transformedWords = new List<string>();
            foreach (string word in words) {
                string transformedWord = word;
                if (xforms.ContainsKey(word)) {
                    transformedWord = xforms[word];
                }

                // Gather the transformed word
                transformedWords.Add(transformedWord);
            }

            // Return the transformed input
            return string.Join(" ", transformedWords);
        }

        /// <summary>
        /// Perform a post-transformation of an input string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The post-transformed string.</returns>
        public static string PostTransform
            (string input)
        {
            // The transformations
            Dictionary<string, string> xforms = new Dictionary<string, string>();
            xforms.Add("AM", "ARE");
            xforms.Add("ARE", "AM");

            xforms.Add("WAS", "WERE");
            xforms.Add("WERE", "WAS");

            xforms.Add("YOUR", "MY");
            xforms.Add("MY", "YOUR");

            xforms.Add("I", "YOU");
            xforms.Add("YOU", null);

            xforms.Add("I'M", "YOU ARE");
            xforms.Add("YOU'RE", "I AM");

            xforms.Add("ME", "YOU");

            xforms.Add("MYSELF", "YOURSELF");
            xforms.Add("YOURSELF", "MYSELF");

            // For each word in the input...
            string[] words = input.Split(null);
            List<string> transformedWords = new List<string>();
            for (int i=0; (i < words.Length); i++) {

                // Get the word
                string word = words[i];
                string transformedWord = word;

                // If the word needs to be transformed...
                if (xforms.ContainsKey(word)) {

                    if (word == "YOU") {

                        // Check if the word is the last word in the input string
                        bool isLastWord = false;
                        int j = words.Length - 1;
                        while (j >= 0) {
                            if ((words[j] != string.Empty) && (words[j] == word)) {
                                isLastWord = true;
                                break;
                            }
                            j--;
                        }

                        // Transform YOU to either ME or I
                        transformedWord = isLastWord ? "ME" : "I";
                    }
                    else {
                        // Transform word to its replacement
                        transformedWord = xforms[word];
                    }
                }

                // Gather the transformed word
                transformedWords.Add(transformedWord);
            }

            // Fix up incorrect transformations
            string ret = " " + string.Join(" ", transformedWords).Trim() + " ";
            ret = ret.Replace(" ME AM ", " I AM ");
            ret = ret.Replace(" YOU WAS ", " YOU WERE ");
            ret = ret.Trim();

            // Return the transformed input
            return ret;
        }

        #endregion
    }
}
