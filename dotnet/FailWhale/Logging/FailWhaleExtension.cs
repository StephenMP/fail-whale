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
            switch(LogLevel)
            {
                case LogLevel.Critical:
                    logger.LogCritical(message);
                    break;
                case LogLevel.Debug:
                    logger.LogDebug(message);
                    break;
                case LogLevel.Error:
                    logger.LogError(message);
                    break;
                case LogLevel.Information:
                    logger.LogInformation(message);
                    break;
                case LogLevel.Trace:
                    logger.LogTrace(message);
                    break;
                case LogLevel.Warning:
                    logger.LogWarning(message);
                    break;
            }
        }
       
        public static void FailWhale(this ILogger logger, string message, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            switch (LogLevel)
            {
                case LogLevel.Critical:
                    logger.LogCritical(message, args);
                    break;
                case LogLevel.Debug:
                    logger.LogDebug(message, args);
                    break;
                case LogLevel.Error:
                    logger.LogError(message, args);
                    break;
                case LogLevel.Information:
                    logger.LogInformation(message, args);
                    break;
                case LogLevel.Trace:
                    logger.LogTrace(message, args);
                    break;
                case LogLevel.Warning:
                    logger.LogWarning(message, args);
                    break;
            }
        }

        public static void FailWhale(this ILogger logger, Exception exception, string message, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            switch (LogLevel)
            {
                case LogLevel.Critical:
                    logger.LogCritical(exception, message, args);
                    break;
                case LogLevel.Debug:
                    logger.LogDebug(exception, message, args);
                    break;
                case LogLevel.Error:
                    logger.LogError(exception, message, args);
                    break;
                case LogLevel.Information:
                    logger.LogInformation(exception, message, args);
                    break;
                case LogLevel.Trace:
                    logger.LogTrace(exception, message, args);
                    break;
                case LogLevel.Warning:
                    logger.LogWarning(exception, message, args);
                    break;
            }
        }

        public static void FailWhale(this ILogger logger, EventId eventId, Exception exception, string message, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            switch (LogLevel)
            {
                case LogLevel.Critical:
                    logger.LogCritical(eventId, exception, message, args);
                    break;
                case LogLevel.Debug:
                    logger.LogDebug(eventId, exception, message, args);
                    break;
                case LogLevel.Error:
                    logger.LogError(eventId, exception, message, args);
                    break;
                case LogLevel.Information:
                    logger.LogInformation(eventId, exception, message, args);
                    break;
                case LogLevel.Trace:
                    logger.LogTrace(eventId, exception, message, args);
                    break;
                case LogLevel.Warning:
                    logger.LogWarning(eventId, exception, message, args);
                    break;
            }
        }

        public static void FailWhale(this ILogger logger, EventId eventId, string message, params object[] args) {
            message = FailWhaleBuilder.GetFailWhaleOutput(message);
            switch (LogLevel)
            {
                case LogLevel.Critical:
                    logger.LogCritical(eventId, message, args);
                    break;
                case LogLevel.Debug:
                    logger.LogDebug(eventId, message, args);
                    break;
                case LogLevel.Error:
                    logger.LogError(eventId, message, args);
                    break;
                case LogLevel.Information:
                    logger.LogInformation(eventId, message, args);
                    break;
                case LogLevel.Trace:
                    logger.LogTrace(eventId, message, args);
                    break;
                case LogLevel.Warning:
                    logger.LogWarning(eventId, message, args);
                    break;
            }
        }
    }
}
