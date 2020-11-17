using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ArdalisRating
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using var stream = File.AppendText("log.txt");
            stream.WriteLine(message);
            stream.Flush();
        }
    }
}
