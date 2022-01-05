using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the AM pattern.
    /// </summary>
    class AmPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AmPatternTest"/> class.
        /// </summary>
        public AmPatternTest()
               : base (new AmPattern())
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
            test.AddCheck("Am I an orangutan?", "DO YOU BELIEVE YOU ARE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "WOULD YOU WANT TO BE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "DO YOU WISH I WOULD TELL YOU YOU'RE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "WHAT WOULD IT MEAN IF YOU WERE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "DO YOU THINK YOU'RE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "HOW WOULD YOU FEEL IF YOU WERE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "WHAT DO YOU THINK ARE THE CHANCES THAT YOU'RE AN ORANGUTAN?");
            test.AddCheck("Am I an orangutan?", "WHY DO YOU ASK?");
            test.AddCheck("Am I an orangutan?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Am I an orangutan?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Am I an orangutan?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Am I an orangutan?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Am I an orangutan?", "WHAT DO YOU THINK?");
            test.AddCheck("Am I an orangutan?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Am I an orangutan?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Am I an orangutan?", "HAVE YOU ASKED ANYONE ELSE?");
            this.AddRuleTest(test);

            // Test rule 2 (@ sad)
            test = new Test("Rule 2 (@sad)");
            test.AddCheck("I am sad.", "I AM SORRY TO HEAR THAT YOU ARE SAD.");
            test.AddCheck("I am unhappy.", "DO YOU THINK THAT COMING HERE WILL HELP YOU NOT TO BE UNHAPPY?");
            test.AddCheck("I am depressed.", "I'M SURE IT'S NOT PLEASANT TO BE DEPRESSED.");
            test.AddCheck("I am sick.", "CAN YOU EXPLAIN WHAT MADE YOU SICK?");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3 (@happy)");
            test.AddCheck("Sometimes I am very happy!", "HOW HAVE I HELPED YOU TO BE HAPPY?");
            test.AddCheck("Sometimes I'm elated.", "HAS YOUR TREATMENT MADE YOU ELATED?");
            test.AddCheck("I'm a tad glad.", "WHAT MAKES YOU GLAD JUST NOW?");
            test.AddCheck("I am feeling happy.", "CAN YOU EXPLAN WHY YOU ARE SUDDENLY HAPPY?");
            this.AddRuleTest(test);

            // Test rule 4
            test = new Test("Rule 4");
            test.AddCheck("I am an orangutan.", "IS IT BECAUSE YOU ARE AN ORANGUTAN THAT YOU CAME TO ME?");
            test.AddCheck("Today I am an orangutan.", "HOW LONG HAVE YOU BEEN AN ORANGUTAN?");
            test.AddCheck("I am an orangutan.", "DO YOU BELIEVE IT'S NORMAL TO BE AN ORANGUTAN?");
            test.AddCheck("They say I am an orangutan.", "DO YOU ENJOY BEING AN ORANGUTAN?");
            this.AddRuleTest(test);

            // Test rule 5
            test = new Test("Rule 5");
            test.AddCheck("Am orangutan.", "WHY DO YOU SAY \"AM\"?");
            test.AddCheck("Am orangutan.", "I DON'T UNDERSTAND THAT.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
