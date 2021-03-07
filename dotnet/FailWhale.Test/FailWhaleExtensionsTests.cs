using FailWhale.Logging;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace FailWhale.Test
{
    public class FailWhaleExtensionsTests
    {
        [Theory]
        [InlineData(LogLevel.Critical)]
        [InlineData(LogLevel.Debug)]
        [InlineData(LogLevel.Error)]
        [InlineData(LogLevel.Information)]
        [InlineData(LogLevel.Trace)]
        [InlineData(LogLevel.Warning)]
        public void CanLogDefault(LogLevel logLevel)
        {
            FailWhaleExtension.LogLevel = logLevel;
            var loggerMock = new Mock<ILogger>();
            var testMessage = Guid.NewGuid().ToString();

            loggerMock.Object.FailWhale(testMessage);
            loggerMock.Verify(
                m => m.Log(
                    logLevel,
                    It.IsAny<EventId>(),
                    It.Is<It.IsAnyType>((v, _) => v.ToString().Contains(testMessage)),
                    null,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
        }

        [Theory]
        [InlineData(LogLevel.Critical)]
        [InlineData(LogLevel.Debug)]
        [InlineData(LogLevel.Error)]
        [InlineData(LogLevel.Information)]
        [InlineData(LogLevel.Trace)]
        [InlineData(LogLevel.Warning)]
        public void CanLogFirstOverload(LogLevel logLevel)
        {
            FailWhaleExtension.LogLevel = logLevel;
            var loggerMock = new Mock<ILogger>();
            var randomArg = new Random().Next();
            var testMessage = Guid.NewGuid().ToString() + "{0}";

            loggerMock.Object.FailWhale(testMessage, randomArg);
            loggerMock.Verify(
                m => m.Log(
                    logLevel,
                    It.IsAny<EventId>(),
                    It.Is<It.IsAnyType>((v, _) => v.ToString().Contains(string.Format(testMessage, randomArg))),
                    null,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
        }

        [Theory]
        [InlineData(LogLevel.Critical)]
        [InlineData(LogLevel.Debug)]
        [InlineData(LogLevel.Error)]
        [InlineData(LogLevel.Information)]
        [InlineData(LogLevel.Trace)]
        [InlineData(LogLevel.Warning)]
        public void CanLogSecondOverload(LogLevel logLevel)
        {
            FailWhaleExtension.LogLevel = logLevel;
            var loggerMock = new Mock<ILogger>();
            var randomArg = new Random().Next();
            var testMessage = Guid.NewGuid().ToString() + "{0}";
            var exception = new Exception(Guid.NewGuid().ToString());

            loggerMock.Object.FailWhale(exception, testMessage, randomArg);
            loggerMock.Verify(
                m => m.Log(
                    logLevel,
                    It.IsAny<EventId>(),
                    It.Is<It.IsAnyType>((v, _) => v.ToString().Contains(string.Format(testMessage, randomArg))),
                    exception,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
        }

        [Theory]
        [InlineData(LogLevel.Critical)]
        [InlineData(LogLevel.Debug)]
        [InlineData(LogLevel.Error)]
        [InlineData(LogLevel.Information)]
        [InlineData(LogLevel.Trace)]
        [InlineData(LogLevel.Warning)]
        public void CanLogThirdOverload(LogLevel logLevel)
        {
            FailWhaleExtension.LogLevel = logLevel;
            var loggerMock = new Mock<ILogger>();
            var randomArg = new Random().Next();
            var testMessage = Guid.NewGuid().ToString() + "{0}";
            var exception = new Exception(Guid.NewGuid().ToString());
            var eventId = new EventId(new Random().Next(), Guid.NewGuid().ToString());

            loggerMock.Object.FailWhale(eventId, exception, testMessage, randomArg);
            loggerMock.Verify(
                m => m.Log(
                    logLevel,
                    eventId,
                    It.Is<It.IsAnyType>((v, _) => v.ToString().Contains(string.Format(testMessage, randomArg))),
                    exception,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
        }

        [Theory]
        [InlineData(LogLevel.Critical)]
        [InlineData(LogLevel.Debug)]
        [InlineData(LogLevel.Error)]
        [InlineData(LogLevel.Information)]
        [InlineData(LogLevel.Trace)]
        [InlineData(LogLevel.Warning)]
        public void CanLogFourthOverload(LogLevel logLevel)
        {
            FailWhaleExtension.LogLevel = logLevel;
            var loggerMock = new Mock<ILogger>();
            var randomArg = new Random().Next();
            var testMessage = Guid.NewGuid().ToString() + "{0}";
            var eventId = new EventId(new Random().Next(), Guid.NewGuid().ToString());

            loggerMock.Object.FailWhale(eventId, testMessage, randomArg);
            loggerMock.Verify(
                m => m.Log(
                    logLevel,
                    eventId,
                    It.Is<It.IsAnyType>((v, _) => v.ToString().Contains(string.Format(testMessage, randomArg))),
                    null,
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()),
                Times.Once);
        }
    }
}
