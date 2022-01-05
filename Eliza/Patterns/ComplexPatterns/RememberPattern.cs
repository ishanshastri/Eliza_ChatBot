using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The REMEMBER pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class RememberPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RememberPattern"/> class.
        /// </summary>
        public RememberPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("DO YOU OFTEN THINK OF (3)?");
            reassembledResponses.Add("DOES THINKING OF (3) BRING ANYTHING ELSE TO MIND?");
            reassembledResponses.Add("WHAT ELSE DO YOU RECOLLECT?");
            reassembledResponses.Add("WHY DO YOU RECOLLECT (3) JUST NOW?");
            reassembledResponses.Add("WHAT IN THE PRESENT SITUATION REMINDS YOU OF (3)?");
            reassembledResponses.Add("WHAT IS THE CONNECTION BETWEEN ME AND (3)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* I REMEMBER *", reassembledResponses, "YOU REMEMBER (3)");
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("DID YOU THINK I WOULD FORGET (3)?");
            reassembledResponses.Add("WHY DO YOU THINK I SHOULD RECALL (3) NOW?");
            reassembledResponses.Add("WHAT ABOUT (3)?");
            reassembledResponses.Add("YOU MENTIONED (3).");
            rule = new DecompReassemblyRule("* DO YOU REMEMBER *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(5, "REMEMBER", rules);
        }

        #endregion
    }
}






