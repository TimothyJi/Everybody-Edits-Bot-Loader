namespace EEBLAPI.Reference
{
    //TODO: Put summaries on all of them.

    /// <summary>
    /// Protocol 219 - https://github.com/OhPriddle/EverybodyEditsProtocol
    /// </summary>
    public class MessageTypes
    {
        public class Recieve
        {
            /// <summary>
            /// Occurs when you are given edit rights in the world.
            /// </summary>
            public static string ACCESS => "access";

            /// <summary>
            /// Occurs when someone joins the world.
            /// </summary>
            public static string ADD => "add";

            /// <summary>
            /// Occurs when a world was successfully added to a crew.
            /// </summary>
            public static string ADDED_TO_CREW => "addedToCrew";

            /// <summary>
            /// Occurs when a player toggles administrator mode.
            /// </summary>
            public static string ADMIN => "admin";

            public static string ALLOW_SPECTATING => "allowSpectatings";
            public static string AURA => "aura";
            public static string AUTO_TEXT => "autotext";

            /// <summary>
            /// Occurs when a block is placed in the world.
            /// </summary>
            public static string B => "b";

            /// <summary>
            /// Occurs when the background color of the world is changed.
            /// </summary>
            public static string BACKGROUND_COLOR => "backgroundColor";

            public static string BADGE_CHANGE => "badgeChange";
            public static string BANNED => "banned";
            public static string BC => "bc";
            public static string BR => "br";
            public static string BS => "bs";
            public static string C => "c";
            public static string CAMPAIGN_REWARDS => "campaignRewards";
            public static string CAN_ADD_TO_CREWS => "canAddToCrews";
            public static string CLEAR => "clear";
            public static string COMPLETED_LEVEL => "completedLevel";
            public static string CREW_ADD_REQUEST => "crewAddRequest";
            public static string CREW_ADD_REQUEST_FAILED => "crewAddRequestFailed";
            public static string EDIT_RIGHTS => "editRights";
            public static string EFFECT => "effect";
            public static string EFFECTLIMITS => "effectlimits";
            public static string FACE => "face";
            public static string FAVORITED => "favorited";
            public static string GIVEMAGICBRICKPACKAGE => "givemagicbrickpackage";
            public static string GIVEMAGICSMILEY => "givemagicsmiley";
            public static string GOD => "god";
            public static string HIDE => "hide";
            public static string HIDE_LOBBY => "hideLobby";
            public static string INFO => "info";
            public static string INFO2 => "info2";
            public static string INIT => "init";
            public static string INIT2 => "init2";
            public static string JOIN_CAMPAIGN => "joinCampaign";
            public static string K => "k";
            public static string KILL => "kill";
            public static string KS => "ks";
            public static string LB => "lb";
            public static string LEFT => "left";
            public static string LIKED => "liked";
            public static string LOBBY_PREVIEW_ENABLED => "lobbyPreviewEnabled";
            public static string LOCK_CAMPAIGN => "lockCampaign";
            public static string LOSTACCESS => "lostaccess";
            public static string M => "m";
            public static string MAGIC => "magic";
            public static string MINIMAP_ENABLED => "minimapEnabled";
            public static string MOD => "mod";
            public static string MUTED => "muted";
            public static string PS => "ps";
            public static string PSI => "psi";
            public static string PT => "pt";
            public static string RESET => "reset";
            public static string RESET_GLOBAL_SWITCHES => "resetGlobalSwitches";
            public static string RESTORE_PROGRESS => "restoreProgress";
            public static string ROOM_DESCRIPTION => "roomDescription";
            public static string ROOM_VISIBLE => "roomVisible";
            public static string SAVED => "saved";
            public static string SAY => "say";
            public static string SAY_OLD => "say_old";
            public static string SHOW => "show";
            public static string SMILEY_GOLD_BORDER => "smileyGoldBorder";
            public static string TEAM => "team";
            public static string TELE => "tele";
            public static string TELEPORT => "teleport";
            public static string TIME => "time";
            public static string TOGGLE_GOD => "toggleGod";
            public static string TS => "ts";
            public static string UNFAVORITED => "unfavorited";
            public static string UNLIKED => "unliked";
            public static string UPDATEMETA => "updatemeta";
            public static string UPGRADE => "upgrade";
            public static string WORLD_RELEASED => "worldReleased";
            public static string WP => "wp";
            public static string WRITE => "write";
        }

        public class Send
        {
            public static string ACCESS => "access";
            public static string ADD_TO_CREW => "addToCrew";
            public static string ADMIN => "admin";
            public static string AURA => "aura";
            public static string AUTOSAY => "autosay";
            public static string B => "b";
            public static string C => "c";
            public static string CROWN => "crown";
            public static string CAKETOUCH => "caketouch";
            public static string CHECKPOINT => "checkpoint";
            public static string CHANGE_BADGE => "changeBadge";
            public static string CLEAR => "clear";
            public static string DEATH => "death";
            public static string DIAMONDTOUCH => "diamondtouch";
            public static string EFFECT => "effect";
            public static string FAVORITE => "favorite";
            public static string GOD => "god";
            public static string HOLOGRAMTOUCH => "hologramtouch";
            public static string INIT => "init";
            public static string INIT2 => "init2";
            public static string KEY => "key";
            public static string KILL => "kill";
            public static string LEVELCOMPLETE => "levelcomplete";
            public static string LIKE => "like";
            public static string M => "m";
            public static string MOD => "mod";
            public static string NAME => "name";
            public static string PRESS_KEY => "pressKey";
            public static string PS => "ps";
            public static string REJECT_ADD_TO_CREW => "rejectAddToCrew";
            public static string REQUEST_ADD_TO_CREW => "requestAddToCrew";
            public static string RESET => "reset";
            public static string SAVE => "save";
            public static string SAY => "say";
            public static string SET_ALLOW_SPECTATING => "setAllowSpectating";
            public static string SET_CURSE_LIMIT => "setCurseLimit";
            public static string SET_HIDE_LOBBY => "setHideLobby";
            public static string SET_LOBBY_PREVIEW_ENABLED => "setLobbyPreviewEnabled";
            public static string SET_MINIMAP_ENABLED => "setMinimapEnabled";
            public static string SET_ROOM_DESCRIPTION => "setRoomDescription";
            public static string SET_ROOM_VISIBLE => "setRoomVisible";
            public static string SET_STATUS => "setStatus";
            public static string SET_ZOMBIE_LIMIT => "setZombieLimit";
            public static string SMILEY => "smiley";
            public static string SMILEY_GOLD_BORDER => "smileyGoldBorder";
            public static string TEAM => "team";
            public static string TIME => "time";
            public static string TOUCH => "touch";
            public static string UNFAVORITE => "unfavorite";
            public static string UNLIKE => "unlike";
        }
    }
}
