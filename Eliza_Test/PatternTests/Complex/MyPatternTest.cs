using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the MY pattern.
    /// </summary>
    class MyPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MyPatternTest"/> class.
        /// </summary>
        public MyPatternTest()
               : base (new MyPattern())
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
            Test test = new Test("Rule 1 (@family)");
            test.AddCheck("My brother is tall.", "TELL ME MORE ABOUT YOUR FAMILY.");
            test.AddCheck("Everyone says my brother is tall.", "WHO ELSE IN YOUR FAMILY IS TALL?");
            test.AddCheck("My niece.", "YOUR NIECE?");
            test.AddCheck("Yes, my younger niece is also tall.", "WHAT ELSE COMES TO MIND WHEN YOU THINK OF YOUR NIECE?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2");
            test.AddCheck("Sometimes my head hurts.", "YOUR HEAD HURTS?");
            test.AddCheck("My head hurts.", "WHY DO YOU SAY YOUR HEAD HURTS?");
            test.AddCheck("My head hurts.", "DOES THAT SUGGEST ANYTHING ELSE?");
            test.AddCheck("My head hurts sometimes.", "IS IT IMPORTANT THAT YOUR HEAD HURTS SOMETIMES?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
