using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public interface ILogger
    {
        void Log(string Message);
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
