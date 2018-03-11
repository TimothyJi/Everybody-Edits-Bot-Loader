using System.IO;

namespace EEBLAPI.Event
{
    public class EEBLPreLoadEvent
    {
        string path;
        Logger logger;

        public EEBLPreLoadEvent(string path, Logger logger)
        {
            this.path = path;
            this.logger = logger;
        }

        public Logger GetLogger() => logger;
        public string GetStoragePath()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
    }
}
