using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the CAN pattern.
    /// </summary>
    class CanPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CanPatternTest"/> class.
        /// </summary>
        public CanPatternTest()
               : base (new CanPattern())
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
            test.AddCheck("Can you fly?", "YOU BELIEVE I CAN FLY, DON'T YOU?");
            test.AddCheck("Can you fly?", "WHY DO YOU ASK?");
            test.AddCheck("Can you fly?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Can you fly?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Can you fly?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Can you fly?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Can you fly?", "WHAT DO YOU THINK?");
            test.AddCheck("Can you fly?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Can you fly?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Can you fly?", "HAVE YOU ASKED ANYONE ELSE THAT?");
            test.AddCheck("Sometimes can you fly?", "DO YOU WANT ME TO BE ABLE TO FLY?");
            test.AddCheck("Can you fly?", "PERHAPS YOU WOULD LIKE TO BE ABLE TO FLY YOURSELF?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Can I fly?", "WHETHER OR NOT YOU CAN FLY DEPENDS ON YOU MORE THAN ME.");
            test.AddCheck("Can I fly?", "DO YOU WANT TO BE ABLE TO FLY?");
            test.AddCheck("Can I fly?", "PERHAPS YOU DON'T WANT TO FLY.");
            test.AddCheck("Can I fly?", "WHY DO YOU ASK?");
            test.AddCheck("Can I fly?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Can I fly?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Can I fly?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Can I fly?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Can I fly?", "WHAT DO YOU THINK?");
            test.AddCheck("Can I fly?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Can I fly?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Sometimes can I fly?", "HAVE YOU ASKED ANYONE ELSE THAT?");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3");
            test.AddCheck("I know I can fly.", "OH, YOU CAN FLY?");
            test.AddCheck("I know I can fly.", "HOW WOULD YOU FEEL IF YOU COULDN'T FLY?");
            test.AddCheck("I know I can fly.", "DO YOU WANT TO FLY?");
            test.AddCheck("I know I can fly.", "DOES IT PLEASE YOU THAT YOU CAN FLY?");
            test.AddCheck("I know I can fly.", "CAN SOMEONE ELSE FLY?");
        }

        #endregion
    }
}
