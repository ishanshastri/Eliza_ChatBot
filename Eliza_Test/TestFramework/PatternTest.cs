using System;
using System.Collections.Generic;

using Eliza;

namespace ElizaTest
{
    /// <summary>
    /// Tests a pattern.
    /// </summary>
    abstract class PatternTest
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternTest"/> class.
        /// </summary>
        /// <param name="pattern">The pattern being tested.</param>
        protected PatternTest
            (Pattern pattern)
        {
            this._pattern = pattern;
            this.AddTests();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the number of patterns tested.
        /// </summary>
        public static int PatternsTestedCount {
            get;
            internal set;
        }

        /// <summary>
        /// Gets or sets the number of rules tested.
        /// </summary>
        public static int RulesTestedCount {
            get;
            internal set;
        }

        /// <summary>
        /// Gets or sets the number of rules tested.
        /// </summary>
        public static int ResponsesTestedCount {
            get;
            internal set;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Resets the test counters.
        /// </summary>
        public static void ResetCounters()
        {
            PatternTest.PatternsTestedCount = 0;
            PatternTest.RulesTestedCount = 0;
            PatternTest.ResponsesTestedCount = 0;
        }

        /// <summary>
        /// Runs the tests in this instance.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public void Run
            (ILogger logger)
        {
            PatternTest.PatternsTestedCount++;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(string.Format("Testing pattern {0} ", this._pattern.GetType().FullName));
            Console.ResetColor();
            IEliza eliza = new Eliza.Eliza(logger);
            foreach (Test test in this._ruleTests) {
                PatternTest.RulesTestedCount++;
                test.Run(this._pattern, eliza.Synonyms, logger);
            }
        }

        #endregion

        #region Protected methods

        /// <summary>
        /// Adds a test to the set of rule tests to be run.
        /// </summary>
        protected void AddRuleTest
            (Test test)
        {
            this._ruleTests.Add(test);
        }

        #endregion

        #region Abstract methods

        /// <summary>
        /// Adds the pattern's tests.
        /// </summary>
        abstract protected void AddTests();

        #endregion

        #region Fields

        /// <summary>
        /// The pattern being tested.
        /// </summary>
        private Pattern _pattern;

        /// <summary>
        /// The tests for each of this pattern's rules.
        /// </summary>
        private List<Test> _ruleTests = new List<Test>();

        #endregion
    }
}
