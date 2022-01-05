using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the YOUR pattern.
    /// </summary>
    class YourPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YourPatternTest"/> class.
        /// </summary>
        public YourPatternTest()
               : base (new YourPattern())
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
            test.AddCheck("I think your sense of humor is terrible.", "WHY ARE YOU CONCERNED ABOUT MY SENSE OF HUMOR?");
            test.AddCheck("Your sense of humor is terrible.", "WHAT ABOUT YOUR OWN SENSE OF HUMOR?");
            test.AddCheck("I think your sense of humor is terrible.", "ARE YOU WORRIED ABOUT SOMEONE ELSE'S SENSE OF HUMOR?");
            test.AddCheck("I think your sense of humor is terrible.", "REALLY, MY SENSE OF HUMOR IS TERRIBLE?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("I think your responses are stilted.", "HAVE YOU THOUGHT ABOUT YOUR OWN RESPONSES?");
            test.AddCheck("Your responses are stilted.", "WHAT OTHER THOUGHTS DO YOU HAVE REGARDING MY RESPONSES?");
            test.AddCheck("I think your responses are over the top.", "DO YOU FIND OTHER PEOPLES' RESPONSES OVER THE TOP?");
            test.AddCheck("I think your responses are stilted.", "REALLY, MY RESPONSES ARE STILTED?");
            test.AddCheck("Your responses are very artificial.", "WHAT ELSE COMES TO MIND WHEN YOU THINK ABOUT MY RESPONSES?");
            test.AddCheck("I think your responses are stilted.", "WHAT ABOUT YOUR RESPONSES?");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3");
            test.AddCheck("I think your promises don't ring true.", "OH, MY PROMISES DON'T RING TRUE?");
            test.AddCheck("Your speech lacks conviction.", "PERHAPS YOUR SPEECH LACKS CONVICTION.");
            test.AddCheck("Your speech lacked conviction.", "DOES IT WORRY YOU THAT MY SPEECH LACKED CONVICTION?");
            test.AddCheck("Your promises don't ring true.", "REALLY, MY PROMISES DON'T RING TRUE?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
