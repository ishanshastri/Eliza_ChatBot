using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The DREAM pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class DreamPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DreamPattern"/> class.
        /// </summary>
        public DreamPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("WHAT DOES THAT DREAM SUGGEST TO YOU?");
            responses.Add("DO YOU DREAM OFTEN?");
            responses.Add("WHAT PERSONS APPEAR IN YOUR DREAM?");
            responses.Add("DON'T YOU BELIEVE THAT DREAM HAS SOMETHING TO DO WITH YOUR PROBLEM?");

            // Initialize the pattern
            this.Initialize(3, "DREAM, DREAMS", responses);
        }

        #endregion
    }
}
