using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The FOREIGN pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class ForeignPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ForeignPattern"/> class.
        /// </summary>
        public ForeignPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("SORRY, I ONLY SPEAK ENGLISH.");
            responses.Add("SORRY, I DON'T UNDERSTAND LANGUAGES OTHER THAN ENGLISH.");
            responses.Add("SORRY, I CAN ONLY SPEAK ENGLISH.");
            responses.Add("I TOLD BEFORE - I ONLY SPEAK ENGLISH.");
            responses.Add("SORRY, I CAN ONLY SPEAK IN ENGLISH.");

            // Initialize the pattern
            this.Initialize(0, "DEUTSCH, FRANCAIS, ITALIANO, ESPANOL", responses);
        }

        #endregion
    }
}
