using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The SORRY pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class SorryPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SorryPattern"/> class.
        /// </summary>
        public SorryPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("PLEASE DON'T APOLOGIZE.");
            responses.Add("APOLOGIES ARE NOT NECESSARY.");
            responses.Add("WHAT FEELINGS DO YOU HAVE WHEN YOU APOLOGIZE?");
            responses.Add("I'VE TOLD YOU THAT APOLOGIES ARE NOT REQUIRED.");

            // Initialize the pattern
            this.Initialize(0, "APOLOGISE, APOLOGIZE, APOLOGIES, SORRY", responses);
        }

        #endregion
    }
}
