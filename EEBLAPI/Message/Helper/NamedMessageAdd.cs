namespace EEBLAPI.Message.Helper
{
    /// <summary>
    /// Accesses MessageAdd, renames properties to be more user-friendly.
    /// </summary>
    public class NamedMessageAdd
    {
        IMessageAdd message;
        public NamedMessageAdd(IMessageAdd message)
        {
            this.message = message;
        }

        public int Id => SourceMessage.Id;
        public string Username => SourceMessage.Username;
        public string UniqueUserId => SourceMessage.ConnectUserId;
        public int Smiley => SourceMessage.Smiley;
        public double PosX => SourceMessage.X;
        public double PosY => SourceMessage.Y;
        public bool IsGodMode => SourceMessage.GodMode;
        public bool IsAdminMode => SourceMessage.AdminMode;
        public bool CanChat => SourceMessage.CanChat;
        public int GoldCoins => SourceMessage.GoldCoins;
        public int BlueCoins => SourceMessage.BlueCoins;
        public int Deaths => SourceMessage.Deaths;
        public bool IsFriend => SourceMessage.IsFriend;
        public bool IsGoldMembership => SourceMessage.GoldMembership;
        public bool IsGoldSmileyBorder => SourceMessage.GoldSmileyBorder;
        public bool IsModeratorMode => SourceMessage.ModeratorMode;
        public int Team => SourceMessage.Team;
        public int AuraShape => SourceMessage.AuraShape;
        public int AuraColor => SourceMessage.AuraColor;
        public int ChatColor => SourceMessage.ChatColor;
        public string Badge => SourceMessage.Badge;
        public bool IsCrewMember => SourceMessage.CrewMember;
        public byte[] PurpleSwitches => SourceMessage.PurpleSwitches;
        public bool CanEdit => SourceMessage.CanEdit;

        public IMessageAdd SourceMessage => message;
    }
}
