using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The ALIKE pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class AlikePattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AlikePattern"/> class.
        /// </summary>
        public AlikePattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("IN WHAT WAY?");
            responses.Add("WHAT RESEMBLANCE DO YOU SEE?");
            responses.Add("WHAT DOES THAT SIMILARITY SUGGEST TO YOU?");
            responses.Add("WHAT OTHER CONNECTIONS DO YOU SEE?");
            responses.Add("WHAT DO YOU SUPPOSE THAT RESEMBLANCE MEANS?");
            responses.Add("WHAT DO YOU SUPPOSE IS THE CONNECTION?");
            responses.Add("COULD THERE REALLY BE SOME CONNECTION?");
            responses.Add("HOW?");

            // Initialize the pattern
            this.Initialize(10, "ALIKE", responses);
        }

        #endregion
    }
}
