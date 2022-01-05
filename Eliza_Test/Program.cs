using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ElizaTest
{
    /// <summary>
    /// The Eliza tester.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Add the format free tests
            List<PatternTest> tests = new List<PatternTest>();
            tests.Add (new AlikePatternTest ());
            tests.Add (new AlwaysPatternTest ());
            tests.Add (new BecausePatternTest ());
            tests.Add (new ComputerPatternTest ());
            tests.Add (new DreamPatternTest ());
            tests.Add (new ForeignPatternTest ());
            tests.Add (new HelloPatternTest ());
            tests.Add (new NamePatternTest ());
            tests.Add (new NoPatternTest ());
            tests.Add (new PerhapsPatternTest ());
            tests.Add (new SorryPatternTest ());
            tests.Add (new WhatPatternTest ());
            tests.Add (new YesPatternTest ());

            // Add the complex pattern tests
            tests.Add (new AmPatternTest ());
            tests.Add (new ArePatternTest ());
            tests.Add (new CanPatternTest ());
            tests.Add (new DreamedPatternTest ());
            tests.Add (new EveryonePatternTest ());
            tests.Add (new GenericResponsePatternTest ());
            tests.Add (new IfPatternTest ());
            tests.Add (new IPatternTest ());
            tests.Add (new LikePatternTest ());
            tests.Add (new MyPatternTest());
            tests.Add (new RememberPatternTest ());
            tests.Add (new WasPatternTest ());
            tests.Add (new WerePatternTest ());
            tests.Add (new WhyPatternTest ());
            tests.Add (new YouPatternTest ());
            tests.Add (new YourPatternTest ());

            // Run the tests
            PatternTest.ResetCounters();
            DateTime start = DateTime.Now;
            foreach(PatternTest test in tests) {
                test.Run(new ConsoleLogger());
            }
            TimeSpan elapsed = DateTime.Now - start;
            Console.WriteLine("\n{0} patterns, {1} rules and {2} responses tested in {3} sec",
                              PatternTest.PatternsTestedCount,
                              PatternTest.RulesTestedCount,
                              PatternTest.ResponsesTestedCount,
                              elapsed.TotalSeconds);

            // Run GenericResponsePattern integration test
            start = DateTime.Now;
            Dictionary<string, string> responses = new Dictionary<string, string>();
            responses.Add("I WANT TO EAT ICE CREAM FOR BREAKFAST EVERYDAY.",
                          "WHAT WOULD IT MEAN TO YOU IF YOU GOT TO EAT ICE CREAM FOR BREAKFAST EVERYDAY?");
            responses.Add("I'M A PROGRAMMER.",
                          "IS IT BECAUSE YOU ARE A PROGRAMMER THAT YOU CAME TO ME?");
            responses.Add("I CAN CLIMB MT EVEREST.",
                          "I SEE.  YOU CAN CLIMB MT EVEREST.");
            responses.Add("I DON'T LIKE SUSHI.",
                          "DON'T YOU REALLY LIKE SUSHI?");
            responses.Add("SOMETIMES I SHARPEN PENCILS.",
                          "CAN YOU ELABORATE ON THAT?");
            responses.Add("YESTERDAY I ATE TOAST.",
                          "DID YOU SAY YESTERDAY YOU ATE TOAST FOR SOME SPECIAL REASON?");
            responses.Add("MY CAR IS VERY OLD.",
                          "YOUR CAR IS VERY OLD?");
            responses.Add("I REMEMBER EATING NOODLES IN CHINA.",
                          "IT'S INTERESTING THAT YOU REMEMBER EATING NOODLES IN CHINA.");
            responses.Add("ONCE I WAS YOUNG.",
                          "PERHAPS ONCE I ALSO WERE YOUNG?");
            responses.Add("I LOVE TO WRITE CODE ALL DAY.",
                          "OH, YOU LOVE TO WRITE CODE ALL DAY?");
            responses.Add("I LOVE CHOCOLATE ICECREAM.",
                          "WHAT IS IT ABOUT CHOCOLATE ICECREAM YOU LOVE?");
            responses.Add("I HATE TO WAIT IN LINE.",
                          "WHY DO YOU HATE TO WAIT IN LINE?");
            responses.Add("I HATE DOING LAUNDRY.",
                          "WHY DO YOU HATE DOING LAUNDRY?");

            responses.Add("BRRR1.", "I'M NOT SURE I UNDERSTAND YOU FULLY.");
            responses.Add("BRRR2.", "EARLIER YOU SAID YOU WANT TO EAT ICE CREAM FOR BREAKFAST EVERYDAY.");
            responses.Add("BRRR3.", "PLEASE GO ON.");
            responses.Add("BRRR4.", "DOES THIS HAVE ANYTHING TO DO WITH THE FACT THAT YOU'RE A PROGRAMMER?");
            responses.Add("BRRR5.", "BUT YOU SAID YOU CAN CLIMB MT EVEREST.");
            responses.Add("BRRR6.", "WHAT DOES THAT SUGGEST TO YOU?");
            responses.Add("BRRR7.", "DIDN'T YOU SAY YOU DON'T LIKE SUSHI?");
            responses.Add("BRRR8.", "DO YOU FEEL STRONGLY ABOUT DISCUSSING SUCH THINGS?");
            responses.Add("BRRR9.", "I'M NOT SURE I UNDERSTAND YOU FULLY.");
            responses.Add("BRRR10.", "EARLIER YOU SAID SOMETIMES YOU SHARPEN PENCILS.");
            responses.Add("BRRR11.", "PLEASE GO ON.");
            responses.Add("BRRR12.", "DOES THIS HAVE ANYTHING TO DO WITH THE FACT THAT YESTERDAY YOU ATE TOAST?");
            responses.Add("BRRR13.", "BUT YOU SAID YOUR CAR IS VERY OLD.");
            responses.Add("BRRR14.", "WHAT DOES THAT SUGGEST TO YOU?");
            responses.Add("BRRR15.", "DIDN'T YOU SAY YOU REMEMBER EATING NOODLES IN CHINA?");
            responses.Add("BRRR16.", "DO YOU FEEL STRONGLY ABOUT DISCUSSING SUCH THINGS?");
            responses.Add("BRRR17.", "I'M NOT SURE I UNDERSTAND YOU FULLY.");
            responses.Add("BRRR18.", "EARLIER YOU SAID ONCE YOU WAS YOUNG.");
            responses.Add("BRRR19.", "PLEASE GO ON.");
            responses.Add("BRRR20.", "DOES THIS HAVE ANYTHING TO DO WITH THE FACT THAT YOU LOVE TO WRITE CODE ALL DAY?");
            responses.Add("BRRR22.", "BUT YOU SAID YOU LOVE CHOCOLATE ICECREAM.");
            responses.Add("BRRR23.", "WHAT DOES THAT SUGGEST TO YOU?");
            responses.Add("BRRR24.", "DIDN'T YOU SAY YOU HATE TO WAIT IN LINE?");
            responses.Add("BRRR25.", "DO YOU FEEL STRONGLY ABOUT DISCUSSING SUCH THINGS?");
            responses.Add("BRRR26.", "I'M NOT SURE I UNDERSTAND YOU FULLY.");
            responses.Add("BRRR27.", "EARLIER YOU SAID YOU HATE DOING LAUNDRY.");

            Eliza.IEliza eliza = new Eliza.Eliza(new ConsoleLogger());
            bool conversationHasEnded = false;
            foreach(string input in responses.Keys) {
                string expectedResponse = responses[input];
                string actualResponse = eliza.GetResponse(input, out conversationHasEnded);
                Debug.Assert(!conversationHasEnded);
                Debug.Assert(actualResponse == expectedResponse);
            }

            elapsed = DateTime.Now - start;
            Console.WriteLine("GenericResponsePattern integration test passed in {0} sec", elapsed.TotalSeconds);

            // Close window
            Console.WriteLine("\nPress ENTER to close window...");
            Console.ReadLine();
        }
    }
}
