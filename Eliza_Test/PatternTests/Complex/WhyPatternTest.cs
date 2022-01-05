using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the WHY pattern.
    /// </summary>
    class WhyPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WhyPatternTest"/> class.
        /// </summary>
        public WhyPatternTest()
               : base (new WhyPattern())
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
            test.AddCheck("Why don't you speak up?", "DO YOU BELIEVE I DON'T SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "PERHAPS I WILL SPEAK UP IN GOOD TIME.");
            test.AddCheck("I sometimes wonder why don't you speak up?", "SHOULD YOU SPEAK UP YOURSELF?");
            test.AddCheck("Why don't you speak up?", "YOU WANT ME TO SPEAK UP?");

            test.AddCheck("Why don't you speak up?", "WHY DO YOU ASK?");
            test.AddCheck("Why don't you speak up?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Why don't you speak up?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Why don't you speak up?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Why don't you speak up?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Why don't you speak up?", "WHAT DO YOU THINK?");
            test.AddCheck("Why don't you speak up?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Why don't you speak up?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Why don't you speak up?", "HAVE YOU ASKED ANYONE ELSE?");

            test.AddCheck("Why don't you speak up?", "HOW WOULD YOU FEEL IF I SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "DO YOU THINK I CAN'T SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "DO YOU WANT ME TO SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "WOULD IT PLEASE YOU IF I SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "WHY DO YOU WANT ME TO SPEAK UP?");
            test.AddCheck("Why don't you speak up?", "YOU THINK I SHOULD SPEAK UP?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Why can't I fly?", "ARE YOU CERTAIN YOU CAN'T FLY?");
            test.AddCheck("Why can't I fly?", "HAVE YOU ANY IDEA WHY YOU CAN'T FLY?");
            test.AddCheck("Why can't I fly?", "DO YOU THINK YOU SHOULD BE ABLE TO FLY?");
            test.AddCheck("Why can't I fly?", "WHAT DO YOU THINK?");
            test.AddCheck("I often wonder why can't I fly?", "DO YOU WANT TO BE ABLE TO FLY?");
            test.AddCheck("Why can't I fly?", "WHAT WILL HELP YOU FLY?");
            test.AddCheck("Why can't I fly?", "HAVE YOU EVER TRIED TO FLY?");
            test.AddCheck("Why can't I fly?", "HOW WOULD YOU FEEL IF YOU WERE ABLE TO FLY?");
            test.AddCheck("Why can't I fly?", "DO YOU KNOW ANYONE ELSE WHO ALSO CAN'T FLY?");
            test.AddCheck("Why can't I fly?", "DO YOU BELIEVE TALKING TO ME WILL HELP YOU FLY?");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3");
            test.AddCheck("Why is the sky blue?", "WHY DO YOU ASK?");
            test.AddCheck("Why is the sky blue?", "DOES THAT QUESTION INTEREST YOU?");
            test.AddCheck("Why is the sky blue?", "WHAT IS IT YOU REALLY WANTED TO KNOW?");
            test.AddCheck("Why is the sky blue?", "ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            test.AddCheck("Why is the sky blue?", "WHAT ANSWER WOULD PLEASE YOU MOST?");
            test.AddCheck("Why is the sky blue?", "WHAT DO YOU THINK?");
            test.AddCheck("Why is the sky blue?", "WHAT COMES TO MIND WHEN YOU ASK THAT?");
            test.AddCheck("Why is the sky blue?", "HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            test.AddCheck("Why is the sky blue?", "HAVE YOU ASKED ANYONE ELSE?");
        }

        #endregion
    }
}
