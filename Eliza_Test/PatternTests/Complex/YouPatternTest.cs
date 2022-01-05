using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the YOU pattern.
    /// </summary>
    class YouPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YouPatternTest"/> class.
        /// </summary>
        public YouPatternTest()
               : base (new YouPattern())
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
            test.AddCheck("Sometimes you remind me of Einstein.", "IN WHAT WAY?");
            test.AddCheck("You remind me of Einstein.", "WHAT RESEMBLANCE DO YOU SEE?");
            test.AddCheck("You remind me of Einstein.", "WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            test.AddCheck("You remind me of Einstein.", "WHAT OTHER CONNECTIONS DO YOU SEE?");
            test.AddCheck("You remind me of Einstein.", "WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            test.AddCheck("You remind me of Einstein.", "WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            test.AddCheck("You remind me of Einstein.", "COULD THERE REALLY BE SOME CONNECTION?");
            test.AddCheck("You remind me of Einstein.", "HOW?");
            test.AddCheck("You remind me of Einstein.", "EINSTEIN?  REALLY?");
            test.AddCheck("You remind me of Einstein.", "INTERESTING.  WHAT SIMILARITY DO YOU SEE BETWEEN EINSTEIN AND ME?");
            test.AddCheck("You remind me of Einstein.", "EINSTEIN?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Sometimes I think you're human.", "WHAT MAKES YOU THINK I AM HUMAN?");
            test.AddCheck("You're human.", "DOES IT PLEASE YOU TO BELIEVE I AM HUMAN?");
            test.AddCheck("Sometimes I think you are human.", "DO YOU SOMETIMES WISH YOU WERE HUMAN?");
            test.AddCheck("You are human.", "PERHAPS YOU WOULD LIKE TO BE HUMAN.");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3");
            test.AddCheck("Sometimes I think you envy me occasionally.", "WHY DO YOU THINK I ENVY YOU?");
            test.AddCheck("Sometimes I think you envy me.", "YOU LIKE TO THINK I ENVY YOU, DON'T YOU?");
            test.AddCheck("You envy me.", "WHAT MAKES YOU THINK I ENVY YOU?");
            test.AddCheck("I think you envy me occasionally.", "REALLY, I ENVY YOU?");
            test.AddCheck("I think you envy me.", "DO YOU WISH TO BELIEVE I ENVY YOU?");
            test.AddCheck("You envy me occasionally.", "SUPPOSE I DID ENVY YOU.  WHAT WOULD THAT MEAN?");
            test.AddCheck("You envy me.", "DOES SOMEONE ELSE BELIEVE I ENVY YOU?");
            this.AddRuleTest(test);

            // Test rule 4
            test = new Test("Rule 4");
            test.AddCheck("I think you envy people.", "WE WERE DISCUSSING YOU - NOT ME.");
            test.AddCheck("You envy people.", "OH, I ENVY PEOPLE?");
            test.AddCheck("I hate you.", "YOU'RE NOT REALLY TALKING ABOUT ME, ARE YOU?");
            test.AddCheck("You suck!", "WHAT ARE YOUR FEELINGS NOW?");
            test.AddCheck("You suck!", "WHY DO YOU SAY I SUCK?");
            test.AddCheck("You suck!", "DO YOU REALLY THINK I SUCK?");
            test.AddCheck("You suck!", "IT'S INTERESTING THAT YOU THINK I SUCK.");
            test.AddCheck("You suck!", "REALLY, I SUCK?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
