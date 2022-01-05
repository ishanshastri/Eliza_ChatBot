using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// The WHAT pattern.
    /// </summary>
    /// <seealso cref="Eliza.Pattern" />
    public class WhatPattern : FormatFreePattern
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatPattern"/> class.
        /// </summary>
        public WhatPattern()
        {
            // Define the responses
            List<string> responses = new List<string>();
            responses.Add("WHY DO YOU ASK?");
            responses.Add("DOES THAT QUESTION INTEREST YOU?");
            responses.Add("WHAT IS IT YOU REALLY WANTED TO KNOW?");
            responses.Add("ARE SUCH QUESTIONS OFTEN ON YOUR MIND?");
            responses.Add("WHAT ANSWER WOULD PLEASE YOU MOST?");
            responses.Add("WHAT DO YOU THINK?");
            responses.Add("WHAT COMES TO MIND WHEN YOU ASK THAT?");
            responses.Add("HAVE YOU ASKED SUCH QUESTIONS BEFORE?");
            responses.Add("HAVE YOU ASKED ANYONE ELSE?");

            // Initialize the pattern
            this.Initialize(0, "WHAT", responses);
        }

        #endregion
    }
}
