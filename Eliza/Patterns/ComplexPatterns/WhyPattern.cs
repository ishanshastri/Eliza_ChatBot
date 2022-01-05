using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The WHY pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class WhyPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WhyPattern"/> class.
        /// </summary>
        public WhyPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("DO YOU BELIEVE I DON'T (3)?");
            reassembledResponses.Add("PERHAPS I WILL (3) IN GOOD TIME.");
            reassembledResponses.Add("SHOULD YOU (3) YOURSELF?");
            reassembledResponses.Add("YOU WANT ME TO (3)?");

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

            // The following responses aren't part of Eliza but seem to work well
            reassembledResponses.Add("HOW WOULD YOU FEEL IF I (3)?");
            reassembledResponses.Add("DO YOU THINK I CAN'T (3)?");
            reassembledResponses.Add("DO YOU WANT ME TO (3)?");
            reassembledResponses.Add("WOULD IT PLEASE YOU IF I (3)?");
            reassembledResponses.Add("WHY DO YOU WANT ME TO (3)?");
            reassembledResponses.Add("YOU THINK I SHOULD (3)?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* WHY DON'T YOU *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();

            // A mixture of the original Eliza script + some additions that would work well
            reassembledResponses.Add("ARE YOU CERTAIN YOU CAN'T (3)?");
            reassembledResponses.Add("HAVE YOU ANY IDEA WHY YOU CAN'T (3)?");
            reassembledResponses.Add("DO YOU THINK YOU SHOULD BE ABLE TO (3)?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("DO YOU WANT TO BE ABLE TO (3)?");
            reassembledResponses.Add("WHAT WILL HELP YOU (3)?");
            reassembledResponses.Add("HAVE YOU EVER TRIED TO (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU WERE ABLE TO (3)?");
            reassembledResponses.Add("DO YOU KNOW ANYONE ELSE WHO ALSO CAN'T (3)?");
            reassembledResponses.Add("DO YOU BELIEVE TALKING TO ME WILL HELP YOU (3)?");
            rule = new DecompReassemblyRule("* WHY CAN'T I *", reassembledResponses);
            rules.Add(rule);

            // Rule # 3 (same as WHAT)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU ASK?");
            reassembledResponses.Add("DOES THAT QUESTION INTEREST YOU?");
            reassembledResponses.Add("WHAT IS IT YOU REALLY WANTED TO KNOW?");
            reassembledResponses.Add("ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            reassembledResponses.Add("WHAT ANSWER WOULD PLEASE YOU MOST?");
            reassembledResponses.Add("WHAT DO YOU THINK?");
            reassembledResponses.Add("WHAT COMES TO MIND WHEN YOU ASK THAT?");
            reassembledResponses.Add("HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            reassembledResponses.Add("HAVE YOU ASKED ANYONE ELSE?");
            rule = new DecompReassemblyRule("*", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "WHY", rules);
        }

        #endregion
    }
}






