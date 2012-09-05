using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Log
{
    public class Logging
    {
        #region -Public Static Methods-

        /// <summary>
        /// Writes an information entry in the event log.
        /// </summary>
        /// <param name="source">Entry source</param>
        /// <param name="message">Information message</param>
        public static void Information(string source, string message)
        {
            EventLog.WriteEntry(source, message, EventLogEntryType.Information);
        }

        /// <summary>
        /// Writes a warning entry in the event log.
        /// </summary>
        /// <param name="source">Entry source</param>
        /// <param name="message">Warning message</param>
        public static void Warning(string source, string message)
        {
            EventLog.WriteEntry(source, message, EventLogEntryType.Warning);
        }

        /// <summary>
        /// Writes an error entry in the event log.
        /// </summary>
        /// <param name="source">Entry source</param>
        /// <param name="message">Error message</param>
        public static void Error(string source, string message)
        {
            EventLog.WriteEntry(source, message, EventLogEntryType.Error);
        }

        #endregion
    }
}
