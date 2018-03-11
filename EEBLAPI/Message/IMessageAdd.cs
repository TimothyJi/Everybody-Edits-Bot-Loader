namespace EEBLAPI.Message
{
    /// <summary>
    /// Last Updated for EE protocol 219
    /// Occurs when someone joins the world.
    /// </summary>
    public interface IMessageAdd
    {
        ///<summary>
        /// The player's id.
        ///</summary>
        int Id { get; }
        ///<summary>
        /// The player's username.
        ///</summary>
        string Username { get; }
        ///<summary>
        /// The player's unique user id.
        ///</summary>
        string ConnectUserId { get; }
        ///<summary>
        /// The player's smiley id.
        ///</summary>
        int Smiley { get; }
        ///<summary>
        /// The x coordinate of the player's position.
        ///</summary>
        double X { get; }
        ///<summary>
        /// The y coordinate of the player's position.
        ///</summary>
        double Y { get; }
        ///<summary>
        /// Value indicating whether the player is in god mode.
        ///</summary>
        bool GodMode { get; }
        ///<summary>
        /// Value indicating whether the player is in administrator mode.
        ///</summary>
        bool AdminMode { get; }
        ///<summary>
        /// Value indicating whether the player is allowed to chat.
        ///</summary>
        bool CanChat { get; }
        ///<summary>
        /// The amount of player's gold coins.
        ///</summary>
        int GoldCoins { get; }
        ///<summary>
        /// The amount of player's blue coins.
        ///</summary>
        int BlueCoins { get; }
        ///<summary>
        /// The amount of player's deaths.
        ///</summary>
        int Deaths { get; }
        ///<summary>
        /// Value indicating whether the player is a friend.
        ///</summary>
        bool IsFriend { get; }
        ///<summary>
        /// Value indicating whether the player has gold membership.
        ///</summary>
        bool GoldMembership { get; }
        ///<summary>
        /// Value indicating whether the player is wearing gold smiley border.
        ///</summary>
        bool GoldSmileyBorder { get; }
        ///<summary>
        /// Value indicating whether the player is in moderator mode.
        ///</summary>
        bool ModeratorMode { get; }
        ///<summary>
        /// The player's team id.
        ///</summary>
        int Team { get; }
        ///<summary>
        /// The player's aura shape id.
        ///</summary>
        int AuraShape { get; }
        ///<summary>
        /// The player's aura color id.
        ///</summary>
        int AuraColor { get; }
        ///<summary>
        /// The player's chat color.
        ///</summary>
        int ChatColor { get; }
        ///<summary>
        /// The player's badge id.
        ///</summary>
        string Badge { get; }
        ///<summary>
        /// Value indicating whether the player is a member of the crew to which belongs this world.
        ///</summary>
        bool CrewMember { get; }
        ///<summary>
        /// Byte array of purple switch states.
        ///</summary>
        byte[] PurpleSwitches { get; }
        ///<summary>
        /// Value indicating whether the player can edit in this world.
        ///</summary>
        bool CanEdit { get; }
    }
}
