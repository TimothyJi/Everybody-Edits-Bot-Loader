using EEBLAPI.Event;
namespace EEBLAPI
{
    public interface IBot : IBotBase
    {
        Logger Logger { get; set; }

        bool PreLoad(EEBLPreLoadEvent e);
        bool Load(EEBLLoadEvent e);

        bool OnPreInit(EEBLPreInitEvent e);

        bool OnInit(EEBLInitEvent e);

        bool OnPostInit(EEBLPostInitEvent e);

        bool Unload();
    }
}
