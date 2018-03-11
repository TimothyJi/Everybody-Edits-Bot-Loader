using System.Collections.Generic;

namespace EEBLAPI.Player.Utils
{
    public interface IPlayerHandler
    {
        Dictionary<int, string> PlayerUniqueIds { get; set; }
        Dictionary<string, IPlayer> Players { get; set; }

        IPlayer GetPlayer(int id);
        IPlayer GetPlayer(string uuid);
        
        event PlayerAddEvent OnPlayerJoin;
        void OnPlayerJoin_Subscribe(PlayerAddEvent e);
    }
}
