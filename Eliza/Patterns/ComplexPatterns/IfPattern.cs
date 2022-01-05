using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The IF pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class IfPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IfPattern"/> class.
        /// </summary>
        public IfPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("DO YOU THINK IT'S LIKELY THAT (3)?");
            reassembledResponses.Add("DO YOU WISH THAT (3)?");
            reassembledResponses.Add("WHAT DO YOU KNOW ABOUT (3)?");
            reassembledResponses.Add("REALLY, IF (3)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* IF *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(3, "IF", rules);
        }

        #endregion
    }
}
