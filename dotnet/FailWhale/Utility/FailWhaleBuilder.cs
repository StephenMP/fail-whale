using System;
using System.Text;

namespace FailWhale.Utility
{
    public static class FailWhaleBuilder
    {
        public static string GetFailWhaleOutput(string message = null)
        {
            var stringBuilder = new StringBuilder()
                .Append("▄████████████▄▐█▄▄▄▄█▌")
                .Append("█████▌▄▌▄▐▐▌██▌▀▀██▀▀")
                .Append("███▄█▌▄▌▄▐▐▌▀██▄▄█▌")
                .Append("▄▄▄▄█████████████");

            if (message != null)
            {
                stringBuilder.Append($"{Environment.NewLine}{message}");
            }

            return stringBuilder.ToString();
        }
    }
}
