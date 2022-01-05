using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// A speech pattern.
    /// </summary>
    public abstract class ComplexPattern : Pattern
    {
        #region Protected constructor (can only be called by derived class)

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexPattern"/> class.
        /// </summary>
        protected ComplexPattern()
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
            input = StringTransformer.PreTransform(input);

            // Find the first decomp/reassembly rule (if any) that can decompose the user's input.
            // DecompReassemblyRule doesn't yet have a CanDecompose() method, so we'll need to
            // write it.
            DecompReassemblyRule selectedRule = null;
            foreach(DecompReassemblyRule rule in this._decompReassemblyRules) {
                if (rule.CanDecompose(input, synonyms, memory, logger)) {
                    selectedRule = rule;
                    break;
                }
            }

            // If none, return a null string
            if (selectedRule == null) {
                return null;
            }

            // Otherwise, delegate the work of generating the response to the rule.
            // DecompReassemblyRule doesn't yet have a GenerateResponse() method, so we'll need to
            // write it.
            string response = selectedRule.GenerateResponse(input, memory);

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
        /// <param name="decompReassemblyRules">The decomposition/reassembly rules.</param>
        protected void Initialize
            (int rank,
             string phrasesToMatch,
             List<DecompReassemblyRule> decompReassemblyRules)
        {
            // Store rank
            this._rank = rank;

            // Store phrases to match
            string[] phrases = phrasesToMatch.Split(',');
            this._phrasesToMatch = new List<string>();
            foreach(string phrase in phrases) {
                this._phrasesToMatch.Add(phrase.Trim());
            }

            // Store decomposition/reassembly rules
            this._decompReassemblyRules = new List<DecompReassemblyRule>();
            foreach(DecompReassemblyRule decompReassemblyRule in decompReassemblyRules) {
                this._decompReassemblyRules.Add(decompReassemblyRule);
            }
        }

        #endregion

        #region Fields

        /// <summary>
        /// The decomposition/reassembly rules.
        /// </summary>
        private List<DecompReassemblyRule> _decompReassemblyRules;

        #endregion
    }
}
