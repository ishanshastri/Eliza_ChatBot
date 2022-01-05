using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the SORRY pattern.
    /// </summary>
    class SorryPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SorryPatternTest"/> class.
        /// </summary>
        public SorryPatternTest()
               : base (new SorryPattern())
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
            test.AddCheck("Sorry!", "PLEASE DON'T APOLOGIZE.");
            test.AddCheck("My apologies!", "APOLOGIES ARE NOT NECESSARY.");
            test.AddCheck("I apologise.", "WHAT FEELINGS DO YOU HAVE WHEN YOU APOLOGIZE?");
            test.AddCheck("I apologize.", "I'VE TOLD YOU THAT APOLOGIES ARE NOT REQUIRED.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
