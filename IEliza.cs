using System.Collections.Generic;

namespace Eliza
{
    /// <summary>
    /// Simulates a psychiatrist.
    /// </summary>
    public interface IEliza
    {
        #region Properties

            /// <summary>
            /// Gets the message used to welcome a user to Eliza.
            /// </summary>
            string WelcomeMessage {
                get;
            }

            /// <summary>
            /// Gets the synonyms that Eliza recognizes.
            /// </summary>
            Dictionary<string, List<string>> Synonyms {
                get;
            }

            /// <summary>
            /// Gets Eliza's memory (for testing purposes).
            /// </summary>
            Memory Memory {
                get;
            }

        #endregion

        #region Methods

            /// <summary>
            /// Gets the response to a user's input.
            /// </summary>
            /// <param name="input">The user's input.</param>
            /// <param name="conversationHasEnded">Flag: the conversation has ended.</param>
            /// <returns>Eliza's response.</returns>
            string GetResponse
                (string input,
                 out bool conversationHasEnded);

        #endregion
    }
}
