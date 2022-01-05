using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the generic response pattern.
    /// </summary>
    class GenericResponsePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResponsePatternTest"/> class.
        /// </summary>
        public GenericResponsePatternTest()
               : base (new GenericResponsePattern())
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
            test.AddCheck("Foobar.", "I'M NOT SURE I UNDERSTAND YOU FULLY.");
            test.AddCheck("Foobar.", "PLEASE GO ON.");
            test.AddCheck("Foobar.", "WHAT DOES THAT SUGGEST TO YOU?");
            test.AddCheck("Foobar.", "DO YOU FEEL STRONGLY ABOUT DISCUSSING SUCH THINGS?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}