using EEBLAPI.Event;

namespace EEBLAPI
{
    public abstract class Bot : IBot
    {
        public abstract string NAME { get; }
        public abstract string VERSION { get; }
        public abstract string AUTHOR { get; }

        Logger _logger;
        public Logger Logger { get { return _logger; } set { _logger = value; } }

        public virtual bool PreLoad(EEBLPreLoadEvent e) { if (Logger != null) Logger.Info("Succesfully PreLoaded."); return true; }
        public virtual bool Load(EEBLLoadEvent e) { if (Logger != null) Logger.Info("Sucessfully Loaded."); return true; }
        public virtual bool OnPreInit(EEBLPreInitEvent e) => true;
        public virtual bool OnInit(EEBLInitEvent e) => true;
        public virtual bool OnPostInit(EEBLPostInitEvent e) => true;
        public virtual bool Unload() { return true; }
    }
}
