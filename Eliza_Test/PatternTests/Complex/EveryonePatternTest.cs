using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the EVERYONE pattern.
    /// </summary>
    class EveryonePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EveryonePatternTest"/> class.
        /// </summary>
        public EveryonePatternTest()
               : base (new EveryonePattern())
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
            test.AddCheck("I feel everyone hates me.", "REALLY, EVERYONE?");
            test.AddCheck("Nobody loves me.", "SURELY NOT NOBODY?");
            test.AddCheck("Everybody hates me.", "CAN YOU THINK OF ANYONE IN PARTICULAR?");
            test.AddCheck("Everybody hates me.", "WHO, FOR EXAMPLE?");
            test.AddCheck("Noone loves me.", "ARE YOU THINKING OF A SPECIAL PERSON?");
            test.AddCheck("Everybody hates me.", "WHO, IN PARTICULAR?");
            test.AddCheck("Everybody hates me.", "SOMEONE SPECIAL PERHAPS?");
            test.AddCheck("Everybody hates me.", "YOU HAVE A PARTICULAR PERSON IN MIND, DON'T YOU?");
            test.AddCheck("Everybody hates me.", "WHO DO YOU THINK YOU'RE REALLY TALKING ABOUT?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
