using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The NAME pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class NamePattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NamePattern"/> class.
        /// </summary>
        public NamePattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("I AM NOT INTERESTED IN NAMES.");
            responses.Add("I'VE TOLD YOU BEFORE - I DON'T CARE ABOUT NAMES.");
            responses.Add("THERE'S NO NEED TO MENTION NAMES.");
            responses.Add("LET'S KEEP NAMES OUT OF THIS CONVERSATION.");

            // Initialize the pattern
            this.Initialize(15, "NAME", responses);
        }

        #endregion
    }
}
