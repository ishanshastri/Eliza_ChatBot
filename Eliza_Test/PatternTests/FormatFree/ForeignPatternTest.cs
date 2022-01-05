using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the "FOREIGN" pattern.
    /// </summary>
    class ForeignPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ForeignPatternTest"/> class.
        /// </summary>
        public ForeignPatternTest()
               : base (new ForeignPattern())
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
            test.AddCheck("Sprichst du Deutsch?", "SORRY, I ONLY SPEAK ENGLISH.");
            test.AddCheck("Est-ce que tu parles francais?", "SORRY, I DON'T UNDERSTAND LANGUAGES OTHER THAN ENGLISH.");
            test.AddCheck("Parli italiano?", "SORRY, I CAN ONLY SPEAK ENGLISH.");
            test.AddCheck("Hablas espanol?", "I TOLD BEFORE - I ONLY SPEAK ENGLISH.");
            test.AddCheck("Sprichst du Deutsch?", "SORRY, I CAN ONLY SPEAK IN ENGLISH.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
