using EEBLAPI.Player.Utils;

namespace EEBLAPI.Event
{
    public class EEBLPreInitEvent
    {
        IPlayerHandler playerHandler;

        public EEBLPreInitEvent(IPlayerHandler playerHandler)
        {
            this.playerHandler = playerHandler;
        }

        public IPlayerHandler GetPlayerHandler() => playerHandler;
    }
}
