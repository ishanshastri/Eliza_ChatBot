using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the DREAMED pattern.
    /// </summary>
    class DreamedPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamedPatternTest"/> class.
        /// </summary>
        public DreamedPatternTest()
               : base (new DreamedPattern())
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
            test.AddCheck("I dreamed I was flying.", "REALLY, YOU WERE FLYING?");
            test.AddCheck("I dreamed I was flying.", "HAVE YOU EVER FANTASIZED YOU WERE FLYING WHILE YOU WERE AWAKE?");
            test.AddCheck("I dreamed I was flying.", "HAVE YOU EVER DREAMED YOU WERE FLYING BEFORE?");
            test.AddCheck("I dreamed I was flying.", "WHAT DOES THAT DREAM SUGGEST TO YOU?");
            test.AddCheck("I dreamed I was flying.", "DO YOU DREAM OFTEN?");
            test.AddCheck("I dreamed I was flying.", "WHAT PERSONS APPEAR IN YOUR DREAM?");
            test.AddCheck("I dreamed I was flying.", "DON'T YOU BELIEVE THAT DREAM HAS SOMETHING TO DO WITH YOUR PROBLEM?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
