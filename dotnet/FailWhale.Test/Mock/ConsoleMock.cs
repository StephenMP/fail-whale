using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FailWhale.Test.Mock
{
    internal class ConsoleMock : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleMock()
        {
            this.stringWriter = new StringWriter();
            this.originalOutput = Console.Out;
            
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}