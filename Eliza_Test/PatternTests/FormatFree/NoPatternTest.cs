using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the NO pattern.
    /// </summary>
    class NoPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NoPatternTest"/> class.
        /// </summary>
        public NoPatternTest()
               : base (new NoPattern())
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
            test.AddCheck("No.", "YOU'RE BEING A BIT NEGATIVE.");
            test.AddCheck("No way!", "ARE YOU SAYING NO JUST TO BE NEGATIVE?");
            test.AddCheck("Nope, not at all.", "WHY NOT?");
            test.AddCheck("No.", "WHY DO YOU SAY \"NO\"?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
