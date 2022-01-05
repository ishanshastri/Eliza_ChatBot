using System;
using System.Collections.Generic;
using System.Diagnostics;

using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// A collection of user inputs and expected responses that need to be tested.
    /// </summary>
    class Test
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Test"/> class.
        /// </summary>
        /// <param name="name">The name of the test.</param>
        public Test
            (string name)
        {
            this._name = name;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds an input and response to be checked.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="response">The response.</param>
        public void AddCheck
            (string input,
             string response)
        {
            this._inputsAndResponses.Add(new Tuple<string, string>(input, response));
        }

        /// <summary>
        /// Runs the test on a pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="synonyms">The synonyms.</param>
        /// <param name="logger">The logger.</param>
        public void Run
            (Pattern pattern,
             Dictionary<string, List<string>> synonyms,
             ILogger logger)
        {
            Console.Write(string.Format("  {0} {1}...", pattern.GetType().FullName, this._name));
            DateTime start = DateTime.Now;
            IEliza eliza = new Eliza.Eliza(logger);
            bool testPassed = true;
            string error = null;
            foreach(Tuple<string, string> inputAndResponse in this._inputsAndResponses) {

                // Convert the input to the form expected by the pattern
                string input = inputAndResponse.Item1;
                input = input.ToUpper();
                input = input.Replace(".", string.Empty);
                input = input.Replace(",", string.Empty);
                input = input.Replace("!", string.Empty);
                input = input.Replace("?", string.Empty);

                // Get the response
                string response = pattern.GenerateResponse(input, synonyms, eliza.Memory, logger);
                PatternTest.ResponsesTestedCount++;
                error = string.Format("Expected \"{0}\" but received \"{1}\"",
                                       inputAndResponse.Item2, response);

                // Test the response - stop the test on failure
                testPassed = response == inputAndResponse.Item2;
                if (!testPassed) {
                    break;
                }
            }

            // Display test result
            TimeSpan elapsedTime = DateTime.Now - start;
            Console.ForegroundColor = testPassed ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(" {0} in {1} mSec", testPassed ? "PASSED" : "FAILED", elapsedTime.TotalMilliseconds);
            Console.ResetColor();

            // Invoke debugger if the test failed
            if (!testPassed) {
                Debug.Assert(false, error);
            }

        }

        #endregion

        #region Fields

        /// <summary>
        /// The name of the test.
        /// </summary>
        private string _name;

        /// <summary>
        /// The list of inputs and expected responses.
        /// </summary>
        private List<Tuple<string, string>> _inputsAndResponses = new List<Tuple<string, string>>();

        #endregion
    }
}
