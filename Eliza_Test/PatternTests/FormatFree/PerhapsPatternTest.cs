using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the PERHAPS pattern.
    /// </summary>
    class PerhapsPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PerhapsPatternTest"/> class.
        /// </summary>
        public PerhapsPatternTest()
               : base (new PerhapsPattern())
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
            test.AddCheck("Maybe so.", "YOU DON'T SEEM QUITE CERTAIN.");
            test.AddCheck("Possibly.", "WHY THE UNCERTAIN TONE?");
            test.AddCheck("Perhaps!", "CAN'T YOU BE MORE POSITIVE?");
            test.AddCheck("It's possible.", "YOU AREN'T SURE?");
            test.AddCheck("It could be, I suppose.", "BUT DON'T YOU KNOW FOR SURE?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
