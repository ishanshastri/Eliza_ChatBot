using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the REMEMBER pattern.
    /// </summary>
    class RememberPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RememberPatternTest"/> class.
        /// </summary>
        public RememberPatternTest()
               : base (new RememberPattern())
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
            test.AddCheck("Sometimes I remember programming in Cobol.", "DO YOU OFTEN THINK OF PROGRAMMING IN COBOL?");
            test.AddCheck("I remember programming in Cobol.", "DOES THINKING OF PROGRAMMING IN COBOL BRING ANYTHING ELSE TO MIND?");
            test.AddCheck("Sometimes I remember programming in Cobol.", "WHAT ELSE DO YOU RECOLLECT?");
            test.AddCheck("Sometimes I remember programming in Cobol.", "WHY DO YOU RECOLLECT PROGRAMMING IN COBOL JUST NOW?");
            test.AddCheck("I remember programming in Cobol.", "WHAT IN THE PRESENT SITUATION REMINDS YOU OF PROGRAMMING IN COBOL?");
            test.AddCheck("Sometimes I remember programming in Cobol.", "WHAT IS THE CONNECTION BETWEEN ME AND PROGRAMMING IN COBOL?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Do you remember Superman?", "DID YOU THINK I WOULD FORGET SUPERMAN?");
            test.AddCheck("How often do you remember Superman?", "WHY DO YOU THINK I SHOULD RECALL SUPERMAN NOW?");
            test.AddCheck("Do you remember Superman?", "WHAT ABOUT SUPERMAN?");
            test.AddCheck("Do you remember Superman?", "YOU MENTIONED SUPERMAN.");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
