using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the ALIKE pattern.
    /// </summary>
    class AlikePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AlikePatternTest"/> class.
        /// </summary>
        public AlikePatternTest()
               : base (new AlikePattern())
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
            test.AddCheck("People are all alike.", "IN WHAT WAY?");
            test.AddCheck("People are all alike.", "WHAT RESEMBLANCE DO YOU SEE?");
            test.AddCheck("People are all alike.", "WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            test.AddCheck("People are all alike.", "WHAT OTHER CONNECTIONS DO YOU SEE?");
            test.AddCheck("People are all alike.", "WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            test.AddCheck("People are all alike.", "WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            test.AddCheck("People are all alike.", "COULD THERE REALLY BE SOME CONNECTION?");
            test.AddCheck("People are all alike.", "HOW?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
