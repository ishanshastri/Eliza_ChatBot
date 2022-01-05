using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the HELLO pattern.
    /// </summary>
    class HelloPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloPatternTest"/> class.
        /// </summary>
        public HelloPatternTest()
               : base (new HelloPattern())
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
            test.AddCheck("Aloha!", "HOW DO YOU DO.  PLEASE STATE YOUR PROBLEM.");
            test.AddCheck("Hi!", "HI.  wHAT SEEMS TO BE YOUR PROBLEM?");
            test.AddCheck("Hello there!", "HOW DO YOU DO.  PLEASE STATE YOUR PROBLEM.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
