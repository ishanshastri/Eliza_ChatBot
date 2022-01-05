using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The BECAUSE pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class BecausePattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BecausePattern"/> class.
        /// </summary>
        public BecausePattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("IS THAT THE REAL REASON?");
            responses.Add("DON'T ANY OTHER REASONS COME TO MIND?");
            responses.Add("DOES THAT REASON SEEM TO EXPLAIN ANYTHING ELSE?");
            responses.Add("WHAT OTHER REASONS MIGHT THERE BE?");

            // Initialize the pattern
            this.Initialize(0, "BECAUSE", responses);
        }

        #endregion
    }
}
