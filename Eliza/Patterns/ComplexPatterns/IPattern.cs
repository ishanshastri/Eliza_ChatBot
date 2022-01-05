using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The I pattern.
    /// </summary>
    /// <seealso cref="Eliza.ComplexPattern" />
    public class IPattern : ComplexPattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IPattern"/> class.
        /// </summary>
        public IPattern()
        {
            // Create the decomp/reassembly rules
            List<DecompReassemblyRule> rules = new List<DecompReassemblyRule>();

            // Rule # 1
            List<string> reassembledResponses = new List<string>();
            reassembledResponses.Add("WHAT WOULD IT MEAN TO YOU IF YOU GOT (5)?");
            reassembledResponses.Add("WHY DO YOU WANT (5)?");
            reassembledResponses.Add("SUPPOSE YOU GOT (5) SOON?");
            reassembledResponses.Add("WHAT IF YOU NEVER GOT (5)?");
            reassembledResponses.Add("WHAT WOULD GETTING (5) MEAN TO YOU?");
            reassembledResponses.Add("WHAT DOES WANTING (5) HAVE TO DO WITH THIS DISCUSSION?");
            DecompReassemblyRule rule = new DecompReassemblyRule("* I * @DESIRE *", reassembledResponses, "YOU WANT (5)");
            rules.Add(rule);

            // Rule # 2 (same as AmPattern rule # 2)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("I AM SORRY TO HEAR THAT YOU ARE (4).");
            reassembledResponses.Add("DO YOU THINK THAT COMING HERE WILL HELP YOU NOT TO BE (4)?");
            reassembledResponses.Add("I'M SURE IT'S NOT PLEASANT TO BE (4).");
            reassembledResponses.Add("CAN YOU EXPLAIN WHAT MADE YOU (4)?");
            rule = new DecompReassemblyRule("* I AM * @SAD", reassembledResponses);
            rules.Add(rule);

            // Rule # 3 (same as AmPattern rule # 3)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("HOW HAVE I HELPED YOU TO BE (4)?");
            reassembledResponses.Add("HAS YOUR TREATMENT MADE YOU (4)?");
            reassembledResponses.Add("WHAT MAKES YOU (4) JUST NOW?");
            reassembledResponses.Add("CAN YOU EXPLAN WHY YOU ARE SUDDENLY (4)?");
            rule = new DecompReassemblyRule("* I AM * @HAPPY", reassembledResponses);
            rules.Add(rule);

            // Rule # 4
            reassembledResponses = new List<string>();
            reassembledResponses.Add("DO YOU REALLY THINK YOU (6)?");   // Original: DO YOU REALLY THINK SO?
            reassembledResponses.Add("BUT YOU'RE NOT SURE YOU (6)?");
            reassembledResponses.Add("DO YOU SOMETIMES DOUBT YOU (6)?");   // Original: DO YOU REALLY DOUBT YOU (5)?
            rule = new DecompReassemblyRule("* I @BELIEF * I *", reassembledResponses);
            rules.Add(rule);

            // Rule # 5 (same as AmPattern rule # 4)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("IS IT BECAUSE YOU ARE (3) THAT YOU CAME TO ME?");
            reassembledResponses.Add("HOW LONG HAVE YOU BEEN (3)?");
            reassembledResponses.Add("DO YOU BELIEVE IT'S NORMAL TO BE (3)?");
            reassembledResponses.Add("DO YOU ENJOY BEING (3)?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("DO YOU KNOW ANYONE ELSE WHO IS (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU WEREN'T (3)?");
            reassembledResponses.Add("OH, YOU'RE (3)?");
            reassembledResponses.Add("ARE YOU GLAD YOU'RE (3)?");
            reassembledResponses.Add("WOULD YOU PREFER IT IF YOU WEREN'T (3)?");
            reassembledResponses.Add("REALLY?  YOU'RE (3)?");
            reassembledResponses.Add("I SEE.  SO YOU'RE (3).");

            rule = new DecompReassemblyRule("* I AM *", reassembledResponses, "YOU'RE (3)");
            rules.Add(rule);

            // Rule # 6
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU THINK YOU CAN'T (3)?");   // Original: How do you think that you can't (3)
            reassembledResponses.Add("HAVE YOU TRIED?");
            reassembledResponses.Add("PERHAPS YOU COULD (3) NOW.");
            reassembledResponses.Add("DO YOU REALLY WANT TO BE ABLE TO (3)?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("ARE YOU SURE YOU CAN'T (3)?");
            reassembledResponses.Add("DO YOU KNOW ANYONE ELSE WHO CAN'T (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU COULD (3)?");
            reassembledResponses.Add("WOULD IT PLEASE YOU IF YOU COULD (3)?");
            reassembledResponses.Add("WHAT PREVENTS YOU FROM BEING ABLE TO (3)?");
            reassembledResponses.Add("DO YOU THINK OTHERS ALSO CAN'T (3)?");

            rule = new DecompReassemblyRule("* I CAN'T *", reassembledResponses);
            rules.Add(rule);

            // Rule # 7
            reassembledResponses = new List<string>();
            reassembledResponses.Add("DON'T YOU REALLY (3)?");
            reassembledResponses.Add("WHY DON'T YOU (3)?");
            reassembledResponses.Add("DO YOU WISH TO BE ABLE TO (3)?");
            reassembledResponses.Add("DOES THAT TROUBLE YOU?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("DO YOU KNOW ANYONE ELSE WHO DOESN'T (3)?");
            reassembledResponses.Add("HOW WOULD YOU FEEL IF YOU DID (3)?");
            reassembledResponses.Add("YOU REALLY DON'T (3)?");
            reassembledResponses.Add("DO YOU KNOW SOMEONE WHO DOES (3)?");

            rule = new DecompReassemblyRule("* I DON'T *", reassembledResponses, "YOU DON'T (3)");
            rules.Add(rule);

            // Rule # 8
            reassembledResponses = new List<string>();
            reassembledResponses.Add("TELL ME MORE ABOUT SUCH FEELINGS.");
            reassembledResponses.Add("DO YOU OFTEN FEEL (3)?");
            reassembledResponses.Add("DO YOU ENJOY FEELING (3)?");
            reassembledResponses.Add("WHAT DOES FEELING (3) REMIND YOU OF?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("WHAT IF YOU DIDN'T FEEL (3)?");
            reassembledResponses.Add("HOW LONG HAVE YOU FELT (3)?");
            reassembledResponses.Add("DO YOU THINK YOUR FRIENDS ALSO FEEL (3)?");
            reassembledResponses.Add("WOULD YOU LIKE TO NOT FEEL (3)?");

            rule = new DecompReassemblyRule("* DO I FEEL *", reassembledResponses);
            rules.Add(rule);

            // Rule # 9 (not in Eliza, but added for realism)
            rule = new DecompReassemblyRule("* I FEEL *", reassembledResponses);
            rules.Add(rule);

            // Rule # 10
            reassembledResponses = new List<string>();
            reassembledResponses.Add("PERHAPS IN YOUR FANTASIES WE (3) EACH OTHER.");
            reassembledResponses.Add("DO YOU WISH TO (3) ME?");
            reassembledResponses.Add("YOU SEEM TO NEED TO (3) ME.");
            reassembledResponses.Add("DO YOU (3) ANYONE ELSE?");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("REALLY?  YOU (3) ME?");
            reassembledResponses.Add("OH, YOU (3) ME?");

            rule = new DecompReassemblyRule("* I * YOU *", reassembledResponses);
            rules.Add(rule);

            // Rule # 11
            reassembledResponses = new List<string>();
            reassembledResponses.Add("OH, YOU (4) TO (6)?");
            reassembledResponses.Add("HAVE YOU ALWAYS (4)D TO (6)?");
            reassembledResponses.Add("WHO ELSE IN YOUR FAMILY (4)S TO (6)?");
            reassembledResponses.Add("I FIND IT FASCINATING THAT YOU (4) TO (6).");
            reassembledResponses.Add("DO YOU THINK OTHERS ALSO (4) TO (6)?");
            reassembledResponses.Add("WHAT WOULD IT MEAN IF YOU GOT TO (6) NOW?");
            reassembledResponses.Add("PERHAPS SOMETIMES I ALSO (4) TO (6).");
            rule = new DecompReassemblyRule("* I * @LOVELIKE TO *", reassembledResponses, "YOU (4) TO (6)");
            rules.Add(rule);

            // Rule # 12
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHAT IS IT ABOUT (5) YOU (4)?");
            reassembledResponses.Add("DO YOU OFTEN THINK ABOUT (5)?");
            reassembledResponses.Add("IS THERE SOMETHING SPECIFIC ABOUT (5) YOU (4)?");
            reassembledResponses.Add("TELL ME MORE ABOUT YOUR FEELINGS ABOUT (5).");
            reassembledResponses.Add("WHAT ABOUT (5) DO YOU (4) MOST?");
            reassembledResponses.Add("DO OTHERS FEEL THE SAME WAY ABOUT (5) AS YOU?");
            reassembledResponses.Add("WHAT ELSE DO YOU (4)?");
            reassembledResponses.Add("WHAT ELSE GIVES YOU AS MUCH PLEASURE AS (5)?");
            rule = new DecompReassemblyRule("* I * @LOVE *", reassembledResponses, "YOU (4) (5)");
            rules.Add(rule);

            // Rule # 13
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU HATE TO (5)?");
            reassembledResponses.Add("WOULD YOU RATHER NOT (5)?");
            reassembledResponses.Add("WHEN DID YOU FIRST HATE TO (5)?");
            reassembledResponses.Add("DO YOU THINK OTHERS ALSO HATE TO (5)?");
            reassembledResponses.Add("WHAT MADE YOU HATE TO (5)?");
            reassembledResponses.Add("HAVE YOU ALWAYS HATED TO (5)?");
            reassembledResponses.Add("WHAT ELSE DO YOU HATE DOING?");
            rule = new DecompReassemblyRule("* I * HATE TO *", reassembledResponses, "YOU (4) (5)");
            rules.Add(rule);

            // Rule # 14
            reassembledResponses = new List<string>();
            reassembledResponses.Add("WHY DO YOU (4) (5)?");
            reassembledResponses.Add("WHAT ABOUT (5) DO YOU (4)?");
            reassembledResponses.Add("WHEN DID YOU FIRST BEGIN TO (4) (5)?");
            reassembledResponses.Add("DO YOU THINK OTHERS ALSO (4) (5)?");
            reassembledResponses.Add("DO YOU KNOW SOMEONE WHO ALSO (4)S (5)?");
            reassembledResponses.Add("HOW LONG HAVE YOU FELT THIS WAY ABOUT (5)?");
            reassembledResponses.Add("WHAT DO YOU (4) MORE THAN (5)?");
            reassembledResponses.Add("HAVE YOU ALWAYS DESPISED (5)?");
            reassembledResponses.Add("WHAT MADE YOU (4) (5)?");
            reassembledResponses.Add("WHAT ELSE DO YOU (4)?");
            reassembledResponses.Add("PERHAPS SOMEDAY YOU WON'T (4) (5)?");
            reassembledResponses.Add("DO YOU THINK IT'S NORMAL TO (4) (5)?");
            reassembledResponses.Add("DID YOU EVER NOT (4) (5)?");
            rule = new DecompReassemblyRule("* I * @HATE *", reassembledResponses, "YOU (4) (5)");
            rules.Add(rule);

            // Rule # 15 (catch-all)
            reassembledResponses = new List<string>();
            reassembledResponses.Add("I SEE.  YOU (3).");   // More realistic than "YOU SAY (1)?"
            reassembledResponses.Add("CAN YOU ELABORATE ON THAT?");
            reassembledResponses.Add("DID YOU SAY (1) YOU (3) FOR SOME SPECIAL REASON?");
            reassembledResponses.Add("IT'S INTERESTING THAT (1) YOU (3).");

            // Not in Eliza, but added because they sound realistic
            reassembledResponses.Add("PERHAPS (1) I ALSO (3)?");
            reassembledResponses.Add("SO YOU (3)?");
            reassembledResponses.Add("IS IT IMPORTANT THAT YOU (3)?");
            reassembledResponses.Add("WHY DO YOU SAY (1) YOU (3)?");
            reassembledResponses.Add("WHAT IF I ALSO (3)?");
            reassembledResponses.Add("DO YOU THINK SOMEONE ELSE (3)?");
            reassembledResponses.Add("YOU (3)?");

            rule = new DecompReassemblyRule("* I *", reassembledResponses, "(1) YOU (3)");
            rules.Add(rule);

            // Initialize the pattern.
            // The original rank was zero.  But IPattern needs to be more important than
            // LikePattern (rank 10) to ensure we don't get an empty response with the
            // input "I LIKE CHOCOLATE.".
            this.Initialize(15, "I", rules);
        }

        #endregion
    }
}






