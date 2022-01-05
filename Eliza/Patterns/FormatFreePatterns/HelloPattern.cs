using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The HELLO pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class HelloPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloPattern"/> class.
        /// </summary>
        public HelloPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("HOW DO YOU DO.  PLEASE STATE YOUR PROBLEM.");
            responses.Add("HI.  wHAT SEEMS TO BE YOUR PROBLEM?");

            // Initialize the pattern
            this.Initialize(0, "ALOHA, HI, HELLO", responses);
        }

        #endregion
    }
}
