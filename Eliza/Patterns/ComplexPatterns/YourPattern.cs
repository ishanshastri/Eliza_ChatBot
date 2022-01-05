using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The YOUR pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class YourPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YourPattern"/> class.
        /// </summary>
        public YourPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // The original Eliza has a single decomposition rule "* YOUR *".

            // Original Eliza rule # 1
            //List<string> reassembledResponses = new List<string>();
            //reassembledResponses.Add("WHY ARE YOU CONCERNED OVER MY (3)?");
            //reassembledResponses.Add("WHAT ABOUT YOUR OWN (3)?");
            //reassembledResponses.Add("ARE YOU WORRIED ABOUT SOMEONE ELSE'S (3)?");
            //reassembledResponses.Add("REALLY, MY (3)?");
            //DecompReassemblyRule rule = new DecompReassemblyRule("* YOUR *", reassembledResponses);
            //rules.Add(rule);

            // These 3 rules seem more realistic.

            // Eliza rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY ARE YOU CONCERNED ABOUT MY (3)?");
            reassembledResponses.Add("WHAT ABOUT YOUR OWN (3)?");
            reassembledResponses.Add("ARE YOU WORRIED ABOUT SOMEONE ELSE'S (3)?");
            reassembledResponses.Add("REALLY, MY (3) IS (5)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* YOUR * IS *", reassembledResponses);
            rules.Add(rule);

            // Eliza rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("HAVE YOU THOUGHT ABOUT YOUR OWN (3)?");
            reassembledResponses.Add("WHAT OTHER THOUGHTS DO YOU HAVE REGARDING MY (3)?");
            reassembledResponses.Add("DO YOU FIND OTHER PEOPLES' (3) (5)?");
            reassembledResponses.Add("REALLY, MY (3) ARE (5)?");
            reassembledResponses.Add("WHAT ELSE COMES TO MIND WHEN YOU THINK ABOUT MY (3)?");
            reassembledResponses.Add("WHAT ABOUT YOUR (3)?");
            rule = new DecompReassemblyRule("* YOUR * ARE *", reassembledResponses);
            rules.Add(rule);

            // Eliza rule # 3
            reassembledResponses = new List<string>();
            reassembledResponses.Add("OH, MY (3)?");
            reassembledResponses.Add("PERHAPS YOUR (3).");
            reassembledResponses.Add("DOES IT WORRY YOU THAT MY (3)?");
            reassembledResponses.Add("REALLY, MY (3)?");
            rule = new DecompReassemblyRule("* YOUR *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "YOUR", rules);
        }

        #endregion
    }
}






