using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The CAN pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class CanPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CanPattern"/> class.
        /// </summary>
        public CanPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("YOU BELIEVE I CAN (3), DON'T YOU?");

            // The following responses are from the WHAT pattern
            reassembledResponses.Add("WHY DO YOU ASK?");
            reassembledResponses.Add("DOES THAT QUESTION INTEREST YOU?");
            reassembledResponses.Add("WHAT IS IT YOU REALLY WANTED TO KNOW?");
            reassembledResponses.Add("ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            reassembledResponses.Add("WHAT ANSWER WOULD PLEASE YOU MOST?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("WHAT COMES TO MIND WHEN YOU ASK THAT?");
            reassembledResponses.Add("HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            reassembledResponses.Add("HAVE YOU ASKED ANYONE ELSE THAT?");
            // End

            reassembledResponses.Add("DO YOU WANT ME TO BE ABLE TO (3)?");
            reassembledResponses.Add("PERHAPS YOU WOULD LIKE TO BE ABLE TO (3) YOURSELF?");

            DecompReassemblyRule rule = new DecompReassemblyRule("* CAN YOU *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();

            // A mixture of the original Eliza script + some additions that would work well
            reassembledResponses.Add("WHETHER OR NOT YOU CAN (3) DEPENDS ON YOU MORE THAN ME.");
            reassembledResponses.Add("DO YOU WANT TO BE ABLE TO (3)?");
            reassembledResponses.Add("PERHAPS YOU DON'T WANT TO (3).");

            // The following responses are from the WHAT pattern
            reassembledResponses.Add("WHY DO YOU ASK?");
            reassembledResponses.Add("DOES THAT QUESTION INTEREST YOU?");
            reassembledResponses.Add("WHAT IS IT YOU REALLY WANTED TO KNOW?");
            reassembledResponses.Add("ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            reassembledResponses.Add("WHAT ANSWER WOULD PLEASE YOU MOST?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("WHAT COMES TO MIND WHEN YOU ASK THAT?");
            reassembledResponses.Add("HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            reassembledResponses.Add("HAVE YOU ASKED ANYONE ELSE THAT?");
            // End

            rule = new DecompReassemblyRule("* CAN I *", reassembledResponses);
            rules.Add(rule);

            // Rule # 3 (not in Eliza)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("OH, YOU CAN (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU COULDN'T (3)?");
            reassembledResponses.Add("DO YOU WANT TO (3)?");
            reassembledResponses.Add("DOES IT PLEASE YOU THAT YOU CAN (3)?");
            reassembledResponses.Add("CAN SOMEONE ELSE (3)?");
            rule = new DecompReassemblyRule("* I CAN *", reassembledResponses, "YOU CAN (3)");
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "CAN", rules);
        }

        #endregion
    }
}






