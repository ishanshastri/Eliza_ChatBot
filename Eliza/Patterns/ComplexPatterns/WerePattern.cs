using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The WERE pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class WerePattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WerePattern"/> class.
        /// </summary>
        public WerePattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("WOULD YOU LIKE TO BELIEVE I WAS (3)?");
            reassembledResponses.Add("WHAT SUGGESTS THAT I WAS (3)?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("PERHAPS I WAS (3).");
            reassembledResponses.Add("WHAT IF I HAD BEEN (3)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* WERE YOU *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2 (not in Eliza but added to handle case "SOMETIMES I WISH YOU WERE REAL.")
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WOULD YOU LIKE TO BELIEVE I WAS (3)?");
            reassembledResponses.Add("OH, I WAS (3)?");
            reassembledResponses.Add("PERHAPS I WAS (3).");
            reassembledResponses.Add("WHAT IF I WERE (3)?");
            rule = new DecompReassemblyRule("* YOU WERE *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(2, "WERE", rules);
        }

        #endregion
    }
}
