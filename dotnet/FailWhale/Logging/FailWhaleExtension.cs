using FailWhale.Utility;
using Microsoft.Extensions.Logging;
using System;

namespace FailWhale.Logging
{
    public static class FailWhaleExtension
    {
        /// <summary>
        /// Get or set the log level for the fail whale message
        /// </summary>
        public static LogLevel LogLevel { get; set; } = LogLevel.Error;

        /// <summary>
        /// Reset the log level to the default (LogLevel.Error)
        /// </summary>
        public static void ResetLogLevel()
        {
            LogLevel = LogLevel.Error;
        }

        public static void FailWhale(this ILogger logger, string message = null)
        {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            logger.Log(LogLevel, message);
        }
       
        public static void FailWhale(this ILogger logger, string message = null, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            logger.Log(LogLevel, message, args);
        }

        public static void FailWhale(this ILogger logger, Exception exception, string message = null, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            logger.Log(LogLevel, exception, message, args);
        }

        public static void FailWhale(this ILogger logger, EventId eventId, Exception exception, string message = null, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            logger.Log(LogLevel, eventId, exception, message, args);
        }

        public static void FailWhale(this ILogger logger, EventId eventId, string message = null, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            logger.Log(LogLevel, eventId, message, args);
        }
    }
}
