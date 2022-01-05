using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the ALWAYS pattern.
    /// </summary>
    class AlwaysPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysPatternTest"/> class.
        /// </summary>
        public AlwaysPatternTest()
               : base (new AlwaysPattern())
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
            test.AddCheck("People are always bugging me.", "CAN YOU THINK OF A SPECIFIC EXAMPLE?");
            test.AddCheck("People are always bugging me.", "WHEN?");
            test.AddCheck("People are always bugging me.", "WHAT INCIDENT ARE YOU THINKING OF?");
            test.AddCheck("People are always bugging me.", "REALLY, ALWAYS?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
