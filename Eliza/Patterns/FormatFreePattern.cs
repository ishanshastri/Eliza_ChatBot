using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// A speech pattern.
    /// </summary>
    public abstract class FormatFreePattern : Pattern
    {
        #region Protected constructor (can only be called by derived class)

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatFreePattern"/> class.
        /// </summary>
        protected FormatFreePattern()
        {
            // Nothing to do
        }

        #endregion

        #region Public methods (callable by anybody)

        /// <summary>
        /// Generates a human-like response, if possible.
        /// </summary>
        /// <param name="input">The user's input.</param>
        /// <param name="synonyms">The synonyms.</param>
        /// <param name="memory">Eliza's memory.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>
        /// The response or <see langword="null"/> if no response could be generated.
        /// </returns>
        public override string GenerateResponse
            (string input,
             Dictionary<string, List<string>> synonyms,
             Memory memory,
             ILogger logger)
        {
            // Pick the response to be returned
            string response = this._responses[this._nextResponseIndex];

            // Point to the next response
            this._nextResponseIndex++;
            if (this._nextResponseIndex == this._responses.Count) {
                this._nextResponseIndex = 0;
            }

            // Return the response
            return response;
        }

        #endregion

        #region Protected methods (can only be called by derived class)

        /// <summary>
        /// Initializes the pattern.
        /// </summary>
        /// <param name="rank">The pattern's rank.</param>
        /// <param name="phraseToMatch">The phrases to match, specified as a comma separated string.</param>
        /// <param name="responses">The responses.</param>
        protected void Initialize
            (int rank,
             string phrasesToMatch,
             List<string> responses)
        {
            // Store rank
            this._rank = rank;

            // Store phrases to match
            string[] phrases = phrasesToMatch.Split(',');
            this._phrasesToMatch = new List<string>();
            foreach(string phrase in phrases) {
                this._phrasesToMatch.Add(phrase.Trim());
            }

            // Store responses
            this._responses = new List<string>();
            foreach(string response in responses) {
                this._responses.Add(response);
            }
        }

        #endregion

        #region Fields

        /// <summary>
        /// The responses.
        /// </summary>
        private List<string> _responses;

        /// <summary>
        /// Index of the next response to return.
        /// </summary>
        private int _nextResponseIndex;

        #endregion
    }
}
