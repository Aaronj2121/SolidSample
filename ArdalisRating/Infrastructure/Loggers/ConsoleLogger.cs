using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArdalisRating
{

    public class ConsoleLogger : ILogger
    {
        //SRP Example
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    
}
