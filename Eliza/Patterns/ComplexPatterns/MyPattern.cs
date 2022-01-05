using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The MY pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class MyPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MyPattern"/> class.
        /// </summary>
        public MyPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("TELL ME MORE ABOUT YOUR FAMILY.");
            reassembledResponses.Add("WHO ELSE IN YOUR FAMILY (5)?");
            reassembledResponses.Add("YOUR (4)?");
            reassembledResponses.Add("WHAT ELSE COMES TO MIND WHEN YOU THINK OF YOUR (4)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* MY * @FAMILY *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("YOUR (3)?");
            reassembledResponses.Add("WHY DO YOU SAY YOUR (3)?");
            reassembledResponses.Add("DOES THAT SUGGEST ANYTHING ELSE?");   // Original: DOES THAT SUGGEST ANYTHING ELSE WHICH BELONGS TO YOU?
            reassembledResponses.Add("IS IT IMPORTANT THAT YOUR (3)?");
            reassembledResponses.Add("LET'S DISCUSS FURTHER WHY YOUR (3).");
            rule = new DecompReassemblyRule("* MY *", reassembledResponses, "YOUR (3)");
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "MY", rules);
        }

        #endregion
    }
}






