using System.Collections.Generic;
using EEBL.Utils;
using EEBLAPI.Message;
using EEBLAPI.Player;
using EEBLAPI.Player.Utils;

namespace EEBL.Player
{
    class PlayerHandler : IPlayerHandler
    {
        public Dictionary<int, string> PlayerUniqueIds { get; set; }
        public Dictionary<string, IPlayer> Players { get; set; }

        public PlayerHandler()
        {
            PlayerUniqueIds = new Dictionary<int, string>();
            Players = new Dictionary<string, IPlayer>();
        }

        public event PlayerAddEvent OnPlayerJoin;

        public void AddPlayer(IPlayer player)
        {
            if (Players.ContainsKey(player.UniqueId))
                return;
            PlayerUniqueIds.Add(player.Id, player.UniqueId);
            Players.Add(player.UniqueId, player);
        }

        public void RemovePlayer(IPlayer player)
        {
            Players.Remove(player.UniqueId);
        }

        public IPlayer GetPlayer(int id)
        {
            if (!PlayerUniqueIds.ContainsKey(id))
                return null;
            return GetPlayer(PlayerUniqueIds[id]);
        }

        public IPlayer GetPlayer(string uuid)
        {
            if (!Players.ContainsKey(uuid))
                return null;
            return Players[uuid];
        }

        public void PlayerJoin(IPlayer player, IMessageAdd message)
        {
            OnPlayerJoin?.Invoke(player, message);
            if (OnPlayerJoin == null)
            {
                LogHelper.Info("Nullified");
                return;
            }
            LogHelper.Info(OnPlayerJoin.ToString());
        }

        public void OnPlayerJoin_Subscribe(PlayerAddEvent e)
        {
            LogHelper.Info("Subscribed");
            OnPlayerJoin += e;
        }
    }
}
