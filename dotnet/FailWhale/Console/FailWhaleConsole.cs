using FailWhale.Utility;
using System;

namespace FailWhale
{
    public static class FailWhaleConsole
    {
        public static void FailWhale(string message = null)
        {
            var failWhale = FailWhaleBuilder.GetFailWhaleOutput(message);

            var originalTextColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(failWhale);
            Console.ForegroundColor = originalTextColor;
        }
    }
}
