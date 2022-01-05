using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the IF pattern.
    /// </summary>
    class IfPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IfPatternTest"/> class.
        /// </summary>
        public IfPatternTest()
               : base (new IfPattern())
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
            test.AddCheck("I'd love it if I could fly.", "DO YOU THINK IT'S LIKELY THAT YOU COULD FLY?");
            test.AddCheck("I'd love it if I could fly.", "DO YOU WISH THAT YOU COULD FLY?");
            test.AddCheck("I'd love it if I could fly.", "WHAT DO YOU KNOW ABOUT YOU COULD FLY?");
            test.AddCheck("I'd love it if I could fly.", "REALLY, IF YOU COULD FLY?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
