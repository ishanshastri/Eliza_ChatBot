using System;

using Eliza;

namespace ElizaMain
{
    /// <summary>
    /// Logs messages to the Windows console.
    /// </summary>
    /// <seealso cref="Eliza.ILogger" />
    class ConsoleLogger : ILogger
    {
        #region ILogger implementation

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="msg">The message.</param>
        public void Info
            (string msg)
        {
            if (this._enabled) {
                Console.WriteLine("I: {0}", msg);
            }
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="msg">The message.</param>
        public void Warning
            (string msg)
        {
            if (this._enabled) {
                Console.WriteLine("W: {0}", msg);
            }
        }

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="msg">The message.</param>
        public void Error
            (string msg)
        {
            if (this._enabled) {
                Console.WriteLine("E: {0}", msg);
            }
        }

        /// <summary>
        /// Enables and disables logging
        /// </summary>
        /// <param name="enable">Flag: enable logging.</param>
        public void EnableLogging
            (bool enable)
        {
            this._enabled = enable;
        }

        #endregion

        #region Fields

        /// <summary>
        /// Flag: logging is enabled.
        /// </summary>
        private bool _enabled;

        #endregion
    }
}
















