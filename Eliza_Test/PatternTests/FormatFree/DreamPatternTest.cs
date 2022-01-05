using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the DREAM/DREAMS pattern.
    /// </summary>
    class DreamPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamPatternTest"/> class.
        /// </summary>
        public DreamPatternTest()
               : base (new DreamPattern())
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
            test.AddCheck("I dream of Jeannie.", "WHAT DOES THAT DREAM SUGGEST TO YOU?");
            test.AddCheck("My dreams are always in color.", "DO YOU DREAM OFTEN?");
            test.AddCheck("I dream of Jeannie.", "WHAT PERSONS APPEAR IN YOUR DREAM?");
            test.AddCheck("I dream of Jeannie.", "DON'T YOU BELIEVE THAT DREAM HAS SOMETHING TO DO WITH YOUR PROBLEM?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
