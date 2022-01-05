using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The AM pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class AmPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AmPattern"/> class.
        /// </summary>
        public AmPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("DO YOU BELIEVE YOU ARE (3)?");
            reassembledResponses.Add("WOULD YOU WANT TO BE (3)?");
            reassembledResponses.Add("DO YOU WISH I WOULD TELL YOU YOU'RE (3)?");
            reassembledResponses.Add("WHAT WOULD IT MEAN IF YOU WERE (3)?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("DO YOU THINK YOU'RE (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU WERE (3)?");
            reassembledResponses.Add("WHAT DO YOU THINK ARE THE CHANCES THAT YOU'RE (3)?");

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

            DecompReassemblyRule rule = new DecompReassemblyRule("* AM I *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2 (same as IPattern rule # 2)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("I AM SORRY TO HEAR THAT YOU ARE (4).");
            reassembledResponses.Add("DO YOU THINK THAT COMING HERE WILL HELP YOU NOT TO BE (4)?");
            reassembledResponses.Add("I'M SURE IT'S NOT PLEASANT TO BE (4).");
            reassembledResponses.Add("CAN YOU EXPLAIN WHAT MADE YOU (4)?");
            rule = new DecompReassemblyRule("* I AM * @SAD", reassembledResponses);
            rules.Add(rule);

            // Rule # 3 (same as IPattern rule # 3)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("HOW HAVE I HELPED YOU TO BE (4)?");
            reassembledResponses.Add("HAS YOUR TREATMENT MADE YOU (4)?");
            reassembledResponses.Add("WHAT MAKES YOU (4) JUST NOW?");
            reassembledResponses.Add("CAN YOU EXPLAN WHY YOU ARE SUDDENLY (4)?");
            rule = new DecompReassemblyRule("* I AM * @HAPPY", reassembledResponses);
            rules.Add(rule);

            // Rule # 4 (same as IPattern rule # 4)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("IS IT BECAUSE YOU ARE (3) THAT YOU CAME TO ME?");
            reassembledResponses.Add("HOW LONG HAVE YOU BEEN (3)?");
            reassembledResponses.Add("DO YOU BELIEVE IT'S NORMAL TO BE (3)?");
            reassembledResponses.Add("DO YOU ENJOY BEING (3)?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("DO YOU KNOW ANYONE ELSE WHO IS (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU WEREN'T (3)?");
            reassembledResponses.Add("ARE YOU GLAD YOU'RE (3)?");
            reassembledResponses.Add("WOULD YOU PREFER THAT YOU WEREN'T (3)?");

            rule = new DecompReassemblyRule("* I AM *", reassembledResponses, "YOU'RE (3)");
            rules.Add(rule);

            // Rule # 4
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU SAY \"AM\"?");
            reassembledResponses.Add("I DON'T UNDERSTAND THAT.");

            rule = new DecompReassemblyRule("*", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "AM", rules);
        }

        #endregion
    }
}






