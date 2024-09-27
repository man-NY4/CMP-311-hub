using System;
using System.Collections.Generic;
using System.Text;

namespace ProgessiveExample
{
    public class SomeLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of SomeLogger.");
            LogToSome(message);
        }
        private void LogToSome(string message)
        {
            Console.WriteLine("Method: LogToSome, Text: {0}", message);
        }
    }
}
