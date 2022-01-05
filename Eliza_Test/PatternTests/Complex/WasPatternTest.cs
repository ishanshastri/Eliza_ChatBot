using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the WAS pattern.
    /// </summary>
    class WasPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WasPatternTest"/> class.
        /// </summary>
        public WasPatternTest()
               : base (new WasPattern())
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
            test.AddCheck("Yesterday was I rude to you?", "WHAT IF YOU WERE RUDE TO ME?");
            test.AddCheck("Was I rude to you?", "DO YOU THINK YOU WERE RUDE TO ME?");
            test.AddCheck("Was I rude to you?", "WERE YOU RUDE TO ME?");
            test.AddCheck("Was I rude to you?", "WHAT WOULD IT MEAN IF YOU WERE RUDE TO ME?");
            test.AddCheck("Was I rude to you?", "WHAT DOES RUDE TO ME SUGGEST TO YOU?");
            test.AddCheck("Was I rude to you?", "WHY DO YOU ASK?");
            test.AddCheck("Was I rude to you?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Was I rude to you?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Was I rude to you?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Was I rude to you?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Was I rude to you?", "WHAT DO YOU THINK?");
            test.AddCheck("Was I rude to you?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Was I rude to you?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Was I rude to you?", "HAVE YOU ASKED ANYONE ELSE?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("I was happy to see you yesterday.", "WERE YOU REALLY?");
            test.AddCheck("I was happy to see you yesterday.", "WHY DO YOU TELL ME YOU WERE HAPPY TO SEE ME YESTERDAY NOW?");
            test.AddCheck("I was happy to see you yesterday.", "PERHAPS I ALREADY KNOW YOU WERE HAPPY TO SEE ME YESTERDAY?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
