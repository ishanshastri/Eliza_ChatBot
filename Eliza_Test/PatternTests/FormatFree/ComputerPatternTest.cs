using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the COMPUTER pattern.
    /// </summary>
    class ComputerPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerPatternTest"/> class.
        /// </summary>
        public ComputerPatternTest()
               : base (new ComputerPattern())
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
            test.AddCheck("Are you a computer?", "DO COMPUTERS WORRY YOU?");
            test.AddCheck("Are you a computer?", "WHY DO YOU MENTION COMPUTERS?");
            test.AddCheck("Are you a computer?", "WHAT DO YOU THINK MACHINES HAVE TO DO WITH YOUR PROBLEM?");
            test.AddCheck("Are you a computer?", "DON'T YOU THINK COMPUTERS CAN HELP PEOPLE?");
            test.AddCheck("Are you a computer?", "WHAT ABOUT MACHINES WORRIES YOU?");
            test.AddCheck("Are you a computer?", "WHAT DO YOU THINK ABOUT MACHINES?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
