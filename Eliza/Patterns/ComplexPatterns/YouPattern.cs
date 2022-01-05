using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The YOU pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class YouPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YouPattern"/> class.
        /// </summary>
        public YouPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1 (identical to ALIKE pattern)
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("IN WHAT WAY?");
            reassembledResponses.Add("WHAT RESEMBLANCE DO YOU SEE?");
            reassembledResponses.Add("WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            reassembledResponses.Add("WHAT OTHER CONNECTIONS DO YOU SEE?");
            reassembledResponses.Add("WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            reassembledResponses.Add("WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            reassembledResponses.Add("COULD THERE REALLY BE SOME CONNECTION?");
            reassembledResponses.Add("HOW?");

            // Not in Eliza, but added for realism
            reassembledResponses.Add("(3)?  REALLY?");
            reassembledResponses.Add("INTERESTING.  WHAT SIMILARITY DO YOU SEE BETWEEN (3) AND ME?");
            reassembledResponses.Add("(3)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* YOU REMIND ME OF *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHAT MAKES YOU THINK I AM (3)?");
            reassembledResponses.Add("DOES IT PLEASE YOU TO BELIEVE I AM (3)?");
            reassembledResponses.Add("DO YOU SOMETIMES WISH YOU WERE (3)?");
            reassembledResponses.Add("PERHAPS YOU WOULD LIKE TO BE (3).");
            rule = new DecompReassemblyRule("* YOU ARE *", reassembledResponses);
            rules.Add(rule);

            // Rule # 3
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU THINK I (3) YOU?");
            reassembledResponses.Add("YOU LIKE TO THINK I (3) YOU, DON'T YOU?");
            reassembledResponses.Add("WHAT MAKES YOU THINK I (3) YOU?");
            reassembledResponses.Add("REALLY, I (3) YOU?");
            reassembledResponses.Add("DO YOU WISH TO BELIEVE I (3) YOU?");
            reassembledResponses.Add("SUPPOSE I DID (3) YOU.  WHAT WOULD THAT MEAN?");
            reassembledResponses.Add("DOES SOMEONE ELSE BELIEVE I (3) YOU?");
            rule = new DecompReassemblyRule("* YOU * ME *", reassembledResponses);
            rules.Add(rule);

            // Rule # 4
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WE WERE DISCUSSING YOU - NOT ME.");
            reassembledResponses.Add("OH, I (3)?");
            reassembledResponses.Add("YOU'RE NOT REALLY TALKING ABOUT ME, ARE YOU?");
            reassembledResponses.Add("WHAT ARE YOUR FEELINGS NOW?");

            // Not in Eliza, but added for realism
            reassembledResponses.Add("WHY DO YOU SAY I (3)?");
            reassembledResponses.Add("DO YOU REALLY THINK I (3)?");
            reassembledResponses.Add("IT'S INTERESTING THAT YOU THINK I (3).");
            reassembledResponses.Add("REALLY, I (3)?");
            rule = new DecompReassemblyRule("* YOU *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(1, "YOU", rules);
        }

        #endregion
    }
}






