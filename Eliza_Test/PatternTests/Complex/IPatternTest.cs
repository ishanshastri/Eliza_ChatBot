using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests the I pattern.
    /// </summary>
    class IPatternTest : PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IPatternTest"/> class.
        /// </summary>
        public IPatternTest()
               : base (new IPattern())
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
            Test test = new Test("Rule 1 (@desire)");
            test.AddCheck("Sometimes I desire fame.", "WHAT WOULD IT MEAN TO YOU IF YOU GOT FAME?");
            test.AddCheck("Sometimes I want fame.", "WHY DO YOU WANT FAME?");
            test.AddCheck("Sometimes I often crave fame.", "SUPPOSE YOU GOT FAME SOON?");
            test.AddCheck("I desire fame.", "WHAT IF YOU NEVER GOT FAME?");
            test.AddCheck("I want fame.", "WHAT WOULD GETTING FAME MEAN TO YOU?");
            test.AddCheck("I crave fame.", "WHAT DOES WANTING FAME HAVE TO DO WITH THIS DISCUSSION?");
            this.AddRuleTest(test);

            // Test rule 2
            test = new Test("Rule 2 (@sad)");
            test.AddCheck("Sometimes I am very sad.", "I AM SORRY TO HEAR THAT YOU ARE SAD.");
            test.AddCheck("Sometimes I'm unhappy.", "DO YOU THINK THAT COMING HERE WILL HELP YOU NOT TO BE UNHAPPY?");
            test.AddCheck("I'm a tad depressed.", "I'M SURE IT'S NOT PLEASANT TO BE DEPRESSED.");
            test.AddCheck("I am feeling sick.", "CAN YOU EXPLAIN WHAT MADE YOU SICK?");
            this.AddRuleTest(test);

            // Test rule 3
            test = new Test("Rule 3 (@happy)");
            test.AddCheck("Sometimes I am very happy!", "HOW HAVE I HELPED YOU TO BE HAPPY?");
            test.AddCheck("Sometimes I'm elated.", "HAS YOUR TREATMENT MADE YOU ELATED?");
            test.AddCheck("I'm a tad glad.", "WHAT MAKES YOU GLAD JUST NOW?");
            test.AddCheck("I am feeling happy.", "CAN YOU EXPLAN WHY YOU ARE SUDDENLY HAPPY?");
            this.AddRuleTest(test);

            // Test rule 4
            test = new Test("Rule 4 (@belief)");
            test.AddCheck("Sometimes I believe that I could fry an egg.", "DO YOU REALLY THINK YOU COULD FRY AN EGG?");
            test.AddCheck("Sometimes I feel I could fry an egg.", "BUT YOU'RE NOT SURE YOU COULD FRY AN EGG?");
            test.AddCheck("I wish I could fry an egg.", "DO YOU SOMETIMES DOUBT YOU COULD FRY AN EGG?");
            this.AddRuleTest(test);

            // Test rule 5
            test = new Test("Rule 5");
            test.AddCheck("I'm in love with programming.", "IS IT BECAUSE YOU ARE IN LOVE WITH PROGRAMMING THAT YOU CAME TO ME?");
            test.AddCheck("I am in love with programming.", "HOW LONG HAVE YOU BEEN IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I thought I'm in love with programming.", "DO YOU BELIEVE IT'S NORMAL TO BE IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I thought I am in love with programming.", "DO YOU ENJOY BEING IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "DO YOU KNOW ANYONE ELSE WHO IS IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "HOW WOULD YOU FEEL IF YOU WEREN'T IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "OH, YOU'RE IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "ARE YOU GLAD YOU'RE IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "WOULD YOU PREFER IT IF YOU WEREN'T IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I'm in love with programming.", "REALLY?  YOU'RE IN LOVE WITH PROGRAMMING?");
            test.AddCheck("I once thought I'm in love with programming.", "I SEE.  SO YOU'RE IN LOVE WITH PROGRAMMING.");
            this.AddRuleTest(test);

            // Test rule 6
            test = new Test("Rule 6");
            test.AddCheck("Sometimes I can't run fast.", "WHY DO YOU THINK YOU CAN'T RUN FAST?");
            test.AddCheck("I can't run fast.", "HAVE YOU TRIED?");
            test.AddCheck("Sometimes I cannot run fast.", "PERHAPS YOU COULD RUN FAST NOW.");
            test.AddCheck("I cannot run fast.", "DO YOU REALLY WANT TO BE ABLE TO RUN FAST?");

            test.AddCheck("Sometimes I can't run fast.", "ARE YOU SURE YOU CAN'T RUN FAST?");
            test.AddCheck("Sometimes I can't run fast.", "DO YOU KNOW ANYONE ELSE WHO CAN'T RUN FAST?");
            test.AddCheck("Sometimes I can't run fast.", "HOW WOULD YOU FEEL IF YOU COULD RUN FAST?");
            test.AddCheck("Sometimes I can't run fast.", "WOULD IT PLEASE YOU IF YOU COULD RUN FAST?");
            test.AddCheck("Sometimes I can't run fast.", "WHAT PREVENTS YOU FROM BEING ABLE TO RUN FAST?");
            test.AddCheck("Sometimes I can't run fast.", "DO YOU THINK OTHERS ALSO CAN'T RUN FAST?");

            this.AddRuleTest(test);

            // Test rule 7
            test = new Test("Rule 7");
            test.AddCheck("I don't like beetroot.", "DON'T YOU REALLY LIKE BEETROOT?");
            test.AddCheck("Sometimes I don't like beetroot.", "WHY DON'T YOU LIKE BEETROOT?");
            test.AddCheck("I wonder if I don't like beetroot.", "DO YOU WISH TO BE ABLE TO LIKE BEETROOT?");
            test.AddCheck("I don't like beetroot.", "DOES THAT TROUBLE YOU?");
            test.AddCheck("Sometimes I wonder if I don't like beetroot.", "DO YOU KNOW ANYONE ELSE WHO DOESN'T LIKE BEETROOT?");
            test.AddCheck("I don't like beetroot.", "HOW WOULD YOU FEEL IF YOU DID LIKE BEETROOT?");
            test.AddCheck("I don't like beetroot.", "YOU REALLY DON'T LIKE BEETROOT?");
            test.AddCheck("I don't like beetroot.", "DO YOU KNOW SOMEONE WHO DOES LIKE BEETROOT?");
            this.AddRuleTest(test);

            // Test rule 8
            test = new Test("Rule 8");
            test.AddCheck("Why do I feel hungry?", "TELL ME MORE ABOUT SUCH FEELINGS.");
            test.AddCheck("Why do I feel hungry?", "DO YOU OFTEN FEEL HUNGRY?");
            test.AddCheck("Why do I feel hungry?", "DO YOU ENJOY FEELING HUNGRY?");
            test.AddCheck("Why do I feel hungry?", "WHAT DOES FEELING HUNGRY REMIND YOU OF?");
            test.AddCheck("Why do I feel hungry?", "WHAT IF YOU DIDN'T FEEL HUNGRY?");
            test.AddCheck("Why do I feel hungry?", "HOW LONG HAVE YOU FELT HUNGRY?");
            test.AddCheck("Why do I feel hungry?", "DO YOU THINK YOUR FRIENDS ALSO FEEL HUNGRY?");
            test.AddCheck("Why do I feel hungry?", "WOULD YOU LIKE TO NOT FEEL HUNGRY?");
            this.AddRuleTest(test);

            // Test rule 9
            test = new Test("Rule 9");
            test.AddCheck("Sometimes I feel hungry.", "TELL ME MORE ABOUT SUCH FEELINGS.");
            test.AddCheck("Sometimes I feel hungry.", "DO YOU OFTEN FEEL HUNGRY?");
            test.AddCheck("I feel hungry.", "DO YOU ENJOY FEELING HUNGRY?");
            test.AddCheck("Sometimes I feel hungry.", "WHAT DOES FEELING HUNGRY REMIND YOU OF?");
            test.AddCheck("Sometimes I feel hungry.", "WHAT IF YOU DIDN'T FEEL HUNGRY?");
            test.AddCheck("I feel hungry.", "HOW LONG HAVE YOU FELT HUNGRY?");
            test.AddCheck("Sometimes I feel hungry.", "DO YOU THINK YOUR FRIENDS ALSO FEEL HUNGRY?");
            test.AddCheck("Sometimes I feel hungry.", "WOULD YOU LIKE TO NOT FEEL HUNGRY?");
            this.AddRuleTest(test);

            // Test rule 10
            test = new Test("Rule 10");
            test.AddCheck("Sometimes I despise you very much.", "PERHAPS IN YOUR FANTASIES WE DESPISE EACH OTHER.");
            test.AddCheck("Sometimes I despise you.", "DO YOU WISH TO DESPISE ME?");
            test.AddCheck("I despise you very much.", "YOU SEEM TO NEED TO DESPISE ME.");
            test.AddCheck("I despise you.", "DO YOU DESPISE ANYONE ELSE?");
            test.AddCheck("I despise you very much.", "REALLY?  YOU DESPISE ME?");
            test.AddCheck("I despise you every Tuesday morning.", "OH, YOU DESPISE ME?");
            this.AddRuleTest(test);

            // Test rule 11
            test = new Test("Rule 11 (@lovelike) to");
            test.AddCheck("I love to write code.", "OH, YOU LOVE TO WRITE CODE?");
            test.AddCheck("I like to write code.", "HAVE YOU ALWAYS LIKED TO WRITE CODE?");
            test.AddCheck("I love to write code.", "WHO ELSE IN YOUR FAMILY LOVES TO WRITE CODE?");
            test.AddCheck("I like to write code.", "I FIND IT FASCINATING THAT YOU LIKE TO WRITE CODE.");
            test.AddCheck("I love to write code.", "DO YOU THINK OTHERS ALSO LOVE TO WRITE CODE?");
            test.AddCheck("I love to write code.", "WHAT WOULD IT MEAN IF YOU GOT TO WRITE CODE NOW?");
            test.AddCheck("I like to write code.", "PERHAPS SOMETIMES I ALSO LIKE TO WRITE CODE.");
            this.AddRuleTest(test);

            // Test rule 12
            test = new Test("Rule 12 (@love)");
            test.AddCheck("Sometimes I really love icecream.", "WHAT IS IT ABOUT ICECREAM YOU LOVE?");
            test.AddCheck("I really love icecream.", "DO YOU OFTEN THINK ABOUT ICECREAM?");
            test.AddCheck("I love icecream.", "IS THERE SOMETHING SPECIFIC ABOUT ICECREAM YOU LOVE?");
            test.AddCheck("Sometimes I really love icecream.", "TELL ME MORE ABOUT YOUR FEELINGS ABOUT ICECREAM.");
            test.AddCheck("I really love icecream.", "WHAT ABOUT ICECREAM DO YOU LOVE MOST?");
            test.AddCheck("I love icecream.", "DO OTHERS FEEL THE SAME WAY ABOUT ICECREAM AS YOU?");
            test.AddCheck("Sometimes I really I love icecream.", "WHAT ELSE DO YOU LOVE?");
            test.AddCheck("I really love icecream.", "WHAT ELSE GIVES YOU AS MUCH PLEASURE AS ICECREAM?");
            this.AddRuleTest(test);

            // Test rule 13
            test = new Test("Rule 13 (HATE TO)");
            test.AddCheck("I hate to wake up early.", "WHY DO YOU HATE TO WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "WOULD YOU RATHER NOT WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "WHEN DID YOU FIRST HATE TO WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "DO YOU THINK OTHERS ALSO HATE TO WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "WHAT MADE YOU HATE TO WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "HAVE YOU ALWAYS HATED TO WAKE UP EARLY?");
            test.AddCheck("I hate to wake up early.", "WHAT ELSE DO YOU HATE DOING?");
            this.AddRuleTest(test);

            // Test rule 14
            test = new Test("Rule 14 (@hate)");
            test.AddCheck("I hate exercising.", "WHY DO YOU HATE EXERCISING?");
            test.AddCheck("I detest exercising.", "WHAT ABOUT EXERCISING DO YOU DETEST?");
            test.AddCheck("I despise exercising.", "WHEN DID YOU FIRST BEGIN TO DESPISE EXERCISING?");
            test.AddCheck("I loathe exercising.", "DO YOU THINK OTHERS ALSO LOATHE EXERCISING?");
            test.AddCheck("I abhor exercising.", "DO YOU KNOW SOMEONE WHO ALSO ABHORS EXERCISING?");
            test.AddCheck("I resent exercising.", "HOW LONG HAVE YOU FELT THIS WAY ABOUT EXERCISING?");
            test.AddCheck("I reject exercising.", "WHAT DO YOU REJECT MORE THAN EXERCISING?");
            test.AddCheck("I spurn exercising.", "HAVE YOU ALWAYS DESPISED EXERCISING?");
            test.AddCheck("I dislike exercising.", "WHAT MADE YOU DISLIKE EXERCISING?");
            test.AddCheck("I hate exercising.", "WHAT ELSE DO YOU HATE?");
            test.AddCheck("I hate exercising.", "PERHAPS SOMEDAY YOU WON'T HATE EXERCISING?");
            test.AddCheck("I hate exercising.", "DO YOU THINK IT'S NORMAL TO HATE EXERCISING?");
            test.AddCheck("I hate exercising.", "DID YOU EVER NOT HATE EXERCISING?");
            this.AddRuleTest(test);

            // Test rule 15
            test = new Test("Rule 15");
            test.AddCheck("Yesterday I climbed Mt Everest.", "I SEE.  YOU CLIMBED MT EVEREST.");
            test.AddCheck("Yesterday I climbed Mt Everest.", "CAN YOU ELABORATE ON THAT?");
            test.AddCheck("Yesterday I climbed Mt Everest.", "DID YOU SAY YESTERDAY YOU CLIMBED MT EVEREST FOR SOME SPECIAL REASON?");
            test.AddCheck("Yesterday I climbed Mt Everest.", "IT'S INTERESTING THAT YESTERDAY YOU CLIMBED MT EVEREST.");

            test.AddCheck("Yesterday I went to an Eagles concert.", "PERHAPS YESTERDAY I ALSO WENT TO AN EAGLES CONCERT?");
            test.AddCheck("Yesterday I went to an Eagles concert.", "SO YOU WENT TO AN EAGLES CONCERT?");
            test.AddCheck("I went to an Eagles concert.", "IS IT IMPORTANT THAT YOU WENT TO AN EAGLES CONCERT?");
            test.AddCheck("Yesterday I went to an Eagles concert.", "WHY DO YOU SAY YESTERDAY YOU WENT TO AN EAGLES CONCERT?");
            test.AddCheck("Yesterday I went to an Eagles concert.", "WHAT IF I ALSO WENT TO AN EAGLES CONCERT?");
            test.AddCheck("Yesterday I went to an Eagles concert.", "DO YOU THINK SOMEONE ELSE WENT TO AN EAGLES CONCERT?");
            test.AddCheck("Yesterday I went to an Eagles concert.", "YOU WENT TO AN EAGLES CONCERT?");
            this.AddRuleTest(test);
        }

        #endregion
    }
}
