using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The ARE pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class ArePattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ArePattern"/> class.
        /// </summary>
        public ArePattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY ARE YOU INTERESTED IN WHETHER OR NOT I'M (3)?");
            reassembledResponses.Add("WOULD YOU PREFER IF I WEREN'T (3)?");
            reassembledResponses.Add("PERHAPS I'M (3) IN YOUR FANTASIES.");
            reassembledResponses.Add("DO YOU SOMETIMES THINK I'M (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF I WERE (3)?");

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

            DecompReassemblyRule rule = new DecompReassemblyRule("* ARE YOU *", reassembledResponses);
            rules.Add(rule);

            // Rule # 2
            reassembledResponses = new List<string>();
            reassembledResponses.Add("DID YOU THINK THEY MIGHT NOT BE (3)?");
            reassembledResponses.Add("WOULD YOU LIKE IT IF THEY WEREN'T (3)?");
            reassembledResponses.Add("WHAT IF THEY WERE NOT (3)?");
            reassembledResponses.Add("POSSIBLY THEY ARE (3).");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("(1)?  REALLY?");
            reassembledResponses.Add("WHO ELSE THINKS (1) ARE (3)?");
            reassembledResponses.Add("WHY DO YOU SAY (1) ARE (3)?");
            reassembledResponses.Add("WHAT MAKES YOU THINK THEY'RE (3)?");

            rule = new DecompReassemblyRule("* ARE *", reassembledResponses);
            rules.Add(rule);

            // Initialize the pattern
            this.Initialize(0, "ARE", rules);
        }

        #endregion
    }
}






