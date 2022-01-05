using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the YES pattern.
    /// </summary>
    class YesPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YesPatternTest"/> class.
        /// </summary>
        public YesPatternTest()
               : base (new YesPattern())
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
            test.AddCheck("Yes!", "YOU SEEM QUITE POSITIVE.");
            test.AddCheck("Yes!", "ARE YOU SURE?");
            test.AddCheck("Yep!", "I SEE.");
            test.AddCheck("Yes!", "I UNDERSTAND.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
