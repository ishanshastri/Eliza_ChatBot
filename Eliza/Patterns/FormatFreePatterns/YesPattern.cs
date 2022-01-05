using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The YES pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class YesPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="YesPattern"/> class.
        /// </summary>
        public YesPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("YOU SEEM QUITE POSITIVE.");
            responses.Add("ARE YOU SURE?");
            responses.Add("I SEE.");
            responses.Add("I UNDERSTAND.");

            // Initialize the pattern
            this.Initialize(0, "YES, YEP", responses);
        }

        #endregion
    }
}
