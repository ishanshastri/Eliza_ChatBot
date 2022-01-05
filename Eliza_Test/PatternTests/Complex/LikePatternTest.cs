using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the LIKE pattern.
    /// </summary>
    class LikePatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LikePatternTest"/> class.
        /// </summary>
        public LikePatternTest()
               : base (new LikePattern())
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
            test.AddCheck("I am really like an astronaut.", "IN WHAT WAY?");
            test.AddCheck("People are almost like animals sometimes.", "WHAT RESEMBLANCE DO YOU SEE?");
            test.AddCheck("Life is usually like a bow of cherries.", "WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            test.AddCheck("Life is like a bow of cherries.", "WHAT OTHER CONNECTIONS DO YOU SEE?");
            test.AddCheck("People are like animals.", "WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            test.AddCheck("Jesus was like a rolling stone.", "WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            test.AddCheck("They say people are like chaotic beings.", "COULD THERE REALLY BE SOME CONNECTION?");
            test.AddCheck("His voice is like an animal's.", "HOW SO?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
