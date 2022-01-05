using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The base pattern class.
    /// </summary>
    public abstract class Pattern
    {
        #region Protected constructor (can only be called by derived class)

        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern"/> class.
        /// </summary>
        protected Pattern()
        {
            // Nothing to do
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the pattern's rank.
        /// </summary>
        public int Rank {
            get { return this._rank; }
        }

        #endregion

        #region Public methods (callable by anybody)

        /// <summary>
        /// Checks if the pattern matches the user's input.
        /// </summary>
        /// <param name="input">The user's input.</param>
        /// <returns><see langword="true"/> if the pattern matches the user's input, otherwise <see langword="false"/>.</returns>
        public bool MatchesInput
            (string input)
        {
            // Add a leading and trailing space to the input to ensure matching works correctly
            input = string.Format(" {0} ", input);

            // Check if the pattern's phrase was found
            foreach(string phraseToMatch in this._phrasesToMatch) {
                if (input.Contains(string.Format(" {0} ", phraseToMatch))) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Generates a human-like response, if possible.
        /// This method is abstract, meaning it must be implemented in all derived classes.
        /// </summary>
        /// <param name="input">The user's input.</param>
        /// <param name="synonyms">The synonyms.</param>
        /// <param name="memory">Eliza's memory.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>
        /// The response or <see langword="null"/> if no response could be generated.
        /// </returns>
        public abstract string GenerateResponse
            (string input,
             Dictionary<string, List<string>> synonyms,
             Memory memory,
             ILogger logger);

        #endregion

        #region Fields

        /// <summary>
        /// The pattern's rank.
        /// </summary>
        protected int _rank;

        /// <summary>
        /// The phrases to match.
        /// </summary>
        protected List<string> _phrasesToMatch;

        #endregion
    }
}
