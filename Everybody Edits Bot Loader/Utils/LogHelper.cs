using System;
using System.Collections.Generic;
using System.Text;

using EEBLAPI;

namespace EEBL.Utils
{
    class LogHelper
    {
        private static void Log(string message)
        {
            Console.WriteLine("[" + DateTime.Now.ToLocalTime().ToLongTimeString() + "] " + message);
        }

        public static void Info(string message)
        {
            Log("[Info] " + message);
        }

        public static void Info(string source, string message)
        {
            Log("[Info] [" + source + "] " + message);
        }

        public static void Warn(string message)
        {
            Log("[Warn] " + message);
        }

        public static void Warn(string source, string message)
        {
            Log("[Warn] [" + source + "] " + message);
        }

        public static void LogEvent(LogLevel level, string source, string message)
        {
            switch (level)
            {
                case LogLevel.INFO:
                    Info(source, message);
                    break;

                case LogLevel.WARN:
                    Warn(source, message);
                    break;
            }
        }
    }
}
