using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The LIKE pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class LikePattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LikePattern"/> class.
        /// </summary>
        public LikePattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1 (same as ALIKE pattern)
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("IN WHAT WAY?");
            reassembledResponses.Add("WHAT RESEMBLANCE DO YOU SEE?");
            reassembledResponses.Add("WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            reassembledResponses.Add("WHAT OTHER CONNECTIONS DO YOU SEE?");
            reassembledResponses.Add("WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            reassembledResponses.Add("WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            reassembledResponses.Add("COULD THERE REALLY BE SOME CONNECTION?");
            reassembledResponses.Add("HOW SO?");    // Original: HOW?
            DecompReassemblyRule rule = new DecompReassemblyRule("* @BE * LIKE *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(10, "LIKE", rules);
        }

        #endregion
    }
}
