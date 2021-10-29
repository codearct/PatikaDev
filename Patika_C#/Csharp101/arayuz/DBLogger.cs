using System;

namespace arayuz
{
    public class DBLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database log yazar.");
        }
    }
}