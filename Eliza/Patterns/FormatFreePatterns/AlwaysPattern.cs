using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The ALWAYS pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class AlwaysPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AlwaysPattern"/> class.
        /// </summary>
        public AlwaysPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("CAN YOU THINK OF A SPECIFIC EXAMPLE?");
            responses.Add("WHEN?");
            responses.Add("WHAT INCIDENT ARE YOU THINKING OF?");
            responses.Add("REALLY, ALWAYS?");

            // Initialize the pattern
            this.Initialize(1, "ALWAYS", responses);
        }

        #endregion
    }
}
