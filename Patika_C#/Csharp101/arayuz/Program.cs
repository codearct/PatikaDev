using System;

namespace arayuz
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            DBLogger dBLogger = new();
            dBLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();


        }
    }
}
