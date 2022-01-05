using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the NAME pattern.
    /// </summary>
    class NamePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NamePatternTest"/> class.
        /// </summary>
        public NamePatternTest()
               : base (new NamePattern())
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
            test.AddCheck("My name is Ravi.", "I AM NOT INTERESTED IN NAMES.");
            test.AddCheck("What's your name?", "I'VE TOLD YOU BEFORE - I DON'T CARE ABOUT NAMES.");
            test.AddCheck("My name is Joe.", "THERE'S NO NEED TO MENTION NAMES.");
            test.AddCheck("My name is Sally.", "LET'S KEEP NAMES OUT OF THIS CONVERSATION.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
