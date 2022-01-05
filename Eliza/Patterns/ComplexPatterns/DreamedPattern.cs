using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The DREAMED pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class DreamedPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamedPattern"/> class.
        /// </summary>
        public DreamedPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("REALLY, (3)?");
            reassembledResponses.Add("HAVE YOU EVER FANTASIZED (3) WHILE YOU WERE AWAKE?");
            reassembledResponses.Add("HAVE YOU EVER DREAMED (3) BEFORE?");

            // These are from the DREAM pattern
            reassembledResponses.Add("WHAT DOES THAT DREAM SUGGEST TO YOU?");
            reassembledResponses.Add("DO YOU DREAM OFTEN?");
            reassembledResponses.Add("WHAT PERSONS APPEAR IN YOUR DREAM?");
            reassembledResponses.Add("DON'T YOU BELIEVE THAT DREAM HAS SOMETHING TO DO WITH YOUR PROBLEM?");

            DecompReassemblyRule rule = new DecompReassemblyRule("* DREAMED *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(4, "DREAMED, DREAMT", rules);
        }

        #endregion
    }
}
