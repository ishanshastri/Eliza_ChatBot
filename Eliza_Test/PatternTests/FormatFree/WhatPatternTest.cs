using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the WHAT pattern.
    /// </summary>
    class WhatPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatPatternTest"/> class.
        /// </summary>
        public WhatPatternTest()
               : base (new WhatPattern())
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
            test.AddCheck("What is iron?", "WHY DO YOU ASK?");
            test.AddCheck("What is iron?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("What is iron?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("What is iron?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("What is iron?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("What is iron?", "WHAT DO YOU THINK?");
            test.AddCheck("What is iron?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("What is iron?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("What is iron?", "HAVE YOU ASKED ANYONE ELSE?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
