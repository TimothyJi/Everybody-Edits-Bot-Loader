using System.Collections.Generic;

namespace EEBLAPI.Player
{
    public class Player : OfflinePlayer, IPlayer
    {
        public Player(string uuid) : base(uuid) { }

        public int Id { get; set; }
        public string Username { get; set; }
    }
}
