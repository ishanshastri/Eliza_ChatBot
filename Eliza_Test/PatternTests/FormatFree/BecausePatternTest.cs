using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the BECAUSE pattern.
    /// </summary>
    class BecausePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BecausePatternTest"/> class.
        /// </summary>
        public BecausePatternTest()
               : base (new BecausePattern())
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
            test.AddCheck("I like you because you're smart.", "IS THAT THE REAL REASON?");
            test.AddCheck("I like you because you're smart.", "DON'T ANY OTHER REASONS COME TO MIND?");
            test.AddCheck("I like you because you're smart.", "DOES THAT REASON SEEM TO EXPLAIN ANYTHING ELSE?");
            test.AddCheck("I like you because you're smart.", "WHAT OTHER REASONS MIGHT THERE BE?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
