using System.Collections.Generic;
using System.Linq;

namespace Eliza
{
    /// <summary>
    /// Eliza's memory.
    /// </summary>
    public class Memory
    {
        #region Public methods

        /// <summary>
        /// Adds text to the memory, if not already present.
        /// </summary>
        /// <param name="text">The text to be added.</param>
        public void AddText
            (string text)
        {
            if (!this._memory.Contains(text)) {
                this._memory.Add(text);
            }
        }

        /// <summary>
        /// Gets (and removes) the oldest text (if any) from the memory.
        /// 
        /// </summary>
        /// <returns>The text.</returns>
        public string GetOldestText()
        {
            string ret = null;
            if (this._memory.Any()) {
                ret = this._memory.First();
                this._memory.Remove(ret);
            }
            return ret;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        /// <langword cref="true"/> if the memory is empty, otherwise <langword cref="false"/>.
        /// </returns>
        public bool IsEmpty()
        {
            return !this._memory.Any();
        }

        #endregion

        #region Fields

        /// <summary>
        /// Eliza's memory.
        /// </summary>
        private List<string> _memory = new List<string>();

        #endregion
    }
}
