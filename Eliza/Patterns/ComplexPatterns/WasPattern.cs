using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The WAS pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class WasPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WasPattern"/> class.
        /// </summary>
        public WasPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("WHAT IF YOU WERE (3)?");
            reassembledResponses.Add("DO YOU THINK YOU WERE (3)?");
            reassembledResponses.Add("WERE YOU (3)?");
            reassembledResponses.Add("WHAT WOULD IT MEAN IF YOU WERE (3)?");
            reassembledResponses.Add("WHAT DOES (3) SUGGEST TO YOU?");

            // The following responses are from the WHAT pattern
            reassembledResponses.Add("WHY DO YOU ASK?");
            reassembledResponses.Add("DOES THAT QUESTION INTEREST YOU?");
            reassembledResponses.Add("WHAT IS IT YOU REALLY WANTED TO KNOW?");
            reassembledResponses.Add("ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            reassembledResponses.Add("WHAT ANSWER WOULD PLEASE YOU MOST?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("WHAT COMES TO MIND WHEN YOU ASK THAT?");
            reassembledResponses.Add("HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            reassembledResponses.Add("HAVE YOU ASKED ANYONE ELSE?");

            DecompReassemblyRule rule = new DecompReassemblyRule("* WAS I *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WERE YOU REALLY?");
            reassembledResponses.Add("WHY DO YOU TELL ME YOU WERE (3) NOW?");
            reassembledResponses.Add("PERHAPS I ALREADY KNOW YOU WERE (3)?");
            rule = new DecompReassemblyRule("* I WAS *", reassembledResponses, "YOU WERE (3)");
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(2, "WAS", rules);
        }

        #endregion
    }
}
