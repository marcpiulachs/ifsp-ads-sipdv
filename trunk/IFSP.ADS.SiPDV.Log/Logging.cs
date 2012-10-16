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
        /// Escreve uma mensagem de informação no log de eventos do windows.
        /// </summary>
        /// <param name="source">Fonte do evento</param>
        /// <param name="message">Mensagem a ser escrita</param>
        public static void Information(string source, string className, string methodName, string message)
        {
            EventLog.WriteEntry(source, 
                                className + Environment.NewLine + methodName + Environment.NewLine + message, 
                                EventLogEntryType.Information);
        }

        /// <summary>
        /// Escreve uma mensagem de atenção no log de eventos do windows.
        /// </summary>
        /// <param name="source">Fonte do evento</param>
        /// <param name="message">Mensagem a ser escrita</param>
        public static void Warning(string source, string className, string methodName, string message)
        {
            EventLog.WriteEntry(source,
                                className + Environment.NewLine + methodName + Environment.NewLine + message, 
                                EventLogEntryType.Warning);
        }

        /// <summary>
        /// Escreve uma mensagem de erro no log de eventos do windows.
        /// </summary>
        /// <param name="source">Fonte do evento</param>
        /// <param name="message">Mensagem a ser escrita</param>
        public static void Error(string source, string className, string methodName, string message)
        {
            EventLog.WriteEntry(source,
                                className + Environment.NewLine + methodName + Environment.NewLine + message, 
                                EventLogEntryType.Error);
        }

        #endregion
    }
}
