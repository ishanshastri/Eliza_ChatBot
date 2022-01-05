using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the WERE pattern.
    /// </summary>
    class WerePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WerePatternTest"/> class.
        /// </summary>
        public WerePatternTest()
               : base (new WerePattern())
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
            test.AddCheck("Were you surprised?", "WOULD YOU LIKE TO BELIEVE I WAS SURPRISED?");
            test.AddCheck("Yesterday were you surprised?", "WHAT SUGGESTS THAT I WAS SURPRISED?");
            test.AddCheck("Were you surprised?", "WHAT DO YOU THINK?");
            test.AddCheck("Were you totally surprised?", "PERHAPS I WAS TOTALLY SURPRISED.");
            test.AddCheck("Yesterday were you totally surprised?", "WHAT IF I HAD BEEN TOTALLY SURPRISED?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Sometimes I wish you were real.", "WOULD YOU LIKE TO BELIEVE I WAS REAL?");
            test.AddCheck("Sometimes I wish you were real.", "OH, I WAS REAL?");
            test.AddCheck("Sometimes I wish you were real.", "PERHAPS I WAS REAL.");
            test.AddCheck("Sometimes I wish you were real.", "WHAT IF I WERE REAL?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
