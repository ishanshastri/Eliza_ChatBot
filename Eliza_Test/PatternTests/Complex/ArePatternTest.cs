using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the ARE pattern.
    /// </summary>
    class ArePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ArePatternTest"/> class.
        /// </summary>
        public ArePatternTest()
               : base (new ArePattern())
        {
        }

        #endregion

        #region PatternTest implementation

        /// <summary>
        /// Adds the pattern's tests.
        /// </summary>
        protected override void AddTests()
        {
            // Test rule 1
            Test test = new Test("Rule 1");
            test.AddCheck("Are you smart?", "WHY ARE YOU INTERESTED IN WHETHER OR NOT I'M SMART?");
            test.AddCheck("Are you smart?", "WOULD YOU PREFER IF I WEREN'T SMART?");
            test.AddCheck("Are you smart?", "PERHAPS I'M SMART IN YOUR FANTASIES.");
            test.AddCheck("Are you smart?", "DO YOU SOMETIMES THINK I'M SMART?");
            test.AddCheck("Sometimes are you smart?", "HOW WOULD YOU FEEL IF I WERE SMART?");
            test.AddCheck("Are you smart?", "WHY DO YOU ASK?");
            test.AddCheck("Are you smart?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Are you smart?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Are you smart?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Are you smart?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Are you smart?", "WHAT DO YOU THINK?");
            test.AddCheck("Are you smart?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Are you smart?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Are you smart?", "HAVE YOU ASKED ANYONE ELSE?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("All software engineers are morons.", "DID YOU THINK THEY MIGHT NOT BE MORONS?");
            test.AddCheck("All software engineers are morons.", "WOULD YOU LIKE IT IF THEY WEREN'T MORONS?");
            test.AddCheck("All software engineers are morons.", "WHAT IF THEY WERE NOT MORONS?");
            test.AddCheck("All software engineers are morons.", "POSSIBLY THEY ARE MORONS.");
            test.AddCheck("All software engineers are morons.", "ALL SOFTWARE ENGINEERS?  REALLY?");
            test.AddCheck("All software engineers are morons.", "WHO ELSE THINKS ALL SOFTWARE ENGINEERS ARE MORONS?");
            test.AddCheck("All software engineers are morons.", "WHY DO YOU SAY ALL SOFTWARE ENGINEERS ARE MORONS?");
            test.AddCheck("All software engineers are morons.", "WHAT MAKES YOU THINK THEY'RE MORONS?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
