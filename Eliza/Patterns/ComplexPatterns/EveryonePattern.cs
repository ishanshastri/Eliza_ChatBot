using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The EVERYONE pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class EveryonePattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EveryonePattern"/> class.
        /// </summary>
        public EveryonePattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("REALLY, (2)?");
            reassembledResponses.Add("SURELY NOT (2)?");
            reassembledResponses.Add("CAN YOU THINK OF ANYONE IN PARTICULAR?");
            reassembledResponses.Add("WHO, FOR EXAMPLE?");
            reassembledResponses.Add("ARE YOU THINKING OF A SPECIAL PERSON?");  // Original: ARE YOU THINKING OF A VERY SPECIAL PERSON?
            reassembledResponses.Add("WHO, IN PARTICULAR?");                    // Original: WHO, MAY I ASK?
            reassembledResponses.Add("SOMEONE SPECIAL PERHAPS?");
            reassembledResponses.Add("YOU HAVE A PARTICULAR PERSON IN MIND, DON'T YOU?");
            reassembledResponses.Add("WHO DO YOU THINK YOU'RE REALLY TALKING ABOUT?"); // Original: WHO DO YOU THINK YOU'RE TALKING ABOUT?
            DecompReassemblyRule rule = new DecompReassemblyRule("* @EVERYONE *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(2, "EVERYONE, EVERYBODY, NOONE, NOBODY", rules);
        }

        #endregion
    }
}
