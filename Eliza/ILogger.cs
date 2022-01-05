namespace Eliza
{
    /// <summary>
    /// Logs messages.
    /// </summary>
    public interface ILogger
    {
        #region Methods

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Info
            (string msg);

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Warning
            (string msg);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="msg">The message.</param>
        void Error
            (string msg);

        /// <summary>
        /// Enables and disables logging
        /// </summary>
        /// <param name="enable">Flag: enable logging.</param>
        void EnableLogging
            (bool enable);

        #endregion
    }
}
