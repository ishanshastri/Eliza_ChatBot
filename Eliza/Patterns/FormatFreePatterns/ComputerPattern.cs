using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The COMPUTER pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class ComputerPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerPattern"/> class.
        /// </summary>
        public ComputerPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("DO COMPUTERS WORRY YOU?");
            responses.Add("WHY DO YOU MENTION COMPUTERS?");
            responses.Add("WHAT DO YOU THINK MACHINES HAVE TO DO WITH YOUR PROBLEM?");
            responses.Add("DON'T YOU THINK COMPUTERS CAN HELP PEOPLE?");
            responses.Add("WHAT ABOUT MACHINES WORRIES YOU?");
            responses.Add("WHAT DO YOU THINK ABOUT MACHINES?");

            // Initialize the pattern
            this.Initialize(50, "COMPUTER", responses);
        }

        #endregion
    }
}
