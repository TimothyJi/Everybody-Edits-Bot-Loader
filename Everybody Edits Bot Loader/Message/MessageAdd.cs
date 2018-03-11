using EEBL.Message.Base;
using EEBLAPI.Message;

namespace EEBL.Message
{
    /// <summary>
    /// Message "Add"
    /// Last Updated: EE v219
    /// </summary>
    class MessageAdd : MessageTypeBase, IMessageAdd
    {
        public MessageAdd(PlayerIOClient.Message message) : base(message) { }

        public int Id => AInt(0);
        
        public string Username => AString(1);
        
        public string ConnectUserId => AString(2);

        public double X => ADouble(4);
        public double Y => ADouble(5);

        public int Smiley => AInt(3);
        public bool GoldSmileyBorder => ABool(14);

        public bool GodMode => ABool(6);
        public bool AdminMode => ABool(7);
        public bool ModeratorMode => ABool(15);

        public int AuraShape => AInt(17);
        public int AuraColor => AInt(18);

        public int ChatColor => AInt(19);
        public bool CanChat => ABool(8);

        public bool GoldMembership => ABool(13);

        public int GoldCoins => AInt(9);
        public int BlueCoins => AInt(10);

        public int Deaths => AInt(11);

        public bool IsFriend => ABool(14);
        public bool CrewMember => ABool(21);

        public bool CanEdit => ABool(23);

        public byte[] PurpleSwitches => AByteArray(22);

        public int Team => AInt(16);

        public string Badge => AString(20);
    }
}
