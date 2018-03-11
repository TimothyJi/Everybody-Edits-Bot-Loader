namespace EEBLAPI
{
    public enum LogLevel
    {
        INFO,
        WARN
    }

    public class Logger
    {
        string source;

        public Logger(string source)
        {
            this.source = source;
        }

        public delegate void LogEventHandler(LogLevel level, string source, string message);
        public event LogEventHandler LogEvent;

        public void AddToLogEventListener(LogEventHandler handler)
        {
            LogEvent += handler;
        }

        public void RemoveFromLogEventListener(LogEventHandler handler)
        {
            LogEvent -= handler;
        }

        public void Info(string message)
        {
            LogEvent?.Invoke(LogLevel.INFO, source, message);
        }

        public void Warn(string message)
        {
            LogEvent?.Invoke(LogLevel.WARN, source, message);
        }
    }
}
