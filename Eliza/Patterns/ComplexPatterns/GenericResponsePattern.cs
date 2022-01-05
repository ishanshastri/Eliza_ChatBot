using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The generic response pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class GenericResponsePattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResponsePattern"/> class.
        /// </summary>
        public GenericResponsePattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("I'M NOT SURE I UNDERSTAND YOU FULLY.");
            reassembledResponses.Add("EARLIER YOU SAID ($).");
            reassembledResponses.Add("PLEASE GO ON.");
            reassembledResponses.Add("DOES THIS HAVE ANYTHING TO DO WITH THE FACT THAT ($)?");
            reassembledResponses.Add("BUT YOU SAID ($).");
            reassembledResponses.Add("WHAT DOES THAT SUGGEST TO YOU?");
            reassembledResponses.Add("DIDN'T YOU SAY ($)?");
            reassembledResponses.Add("DO YOU FEEL STRONGLY ABOUT DISCUSSING SUCH THINGS?");
            DecompReassemblyRule rule = new DecompReassemblyRule("*", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, string.Empty, rules);
        }

        #endregion
    }
}


