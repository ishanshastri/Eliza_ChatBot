using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The NO pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class NoPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NoPattern"/> class.
        /// </summary>
        public NoPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("YOU'RE BEING A BIT NEGATIVE.");
            responses.Add("ARE YOU SAYING NO JUST TO BE NEGATIVE?");
            responses.Add("WHY NOT?");
            responses.Add("WHY DO YOU SAY \"NO\"?");

            // Initialize the pattern
            this.Initialize(0, "NO, NOPE", responses);
        }

        #endregion
    }
}
