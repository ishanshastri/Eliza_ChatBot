using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The PERHAPS pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class PerhapsPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PerhapsPattern"/> class.
        /// </summary>
        public PerhapsPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("YOU DON'T SEEM QUITE CERTAIN.");
            responses.Add("WHY THE UNCERTAIN TONE?");
            responses.Add("CAN'T YOU BE MORE POSITIVE?");
            responses.Add("YOU AREN'T SURE?");
            responses.Add("BUT DON'T YOU KNOW FOR SURE?");

            // Initialize the pattern
            this.Initialize(0, "MAYBE, POSSIBLY, POSSIBLE, COULD BE, PERHAPS", responses);
        }

        #endregion
    }
}
