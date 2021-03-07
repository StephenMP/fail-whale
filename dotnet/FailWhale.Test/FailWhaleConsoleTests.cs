using FailWhale.Test.Mock;
using FailWhale.Utility;
using System;
using Xunit;

namespace FailWhale.Test
{
    public class FailWhaleConsoleTests
    {
        [Fact]
        public void CanPrintConsoleFailWhale()
        {
            using (var consoleMock = new ConsoleMock())
            {
                var expectedOutput = FailWhaleBuilder.GetFailWhaleOutput("Test Message") + Environment.NewLine;
                FailWhaleConsole.FailWhale("Test Message");

                Assert.Equal(expectedOutput, consoleMock.GetOuput());
            }
        }
    }
}
