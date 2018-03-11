using EEBL.Chat;
using EEBL.Message;
using EEBL.Player;
using EEBL.Reference;
using EEBL.Utils;
using EEBLAPI;
using EEBLAPI.Event;
using EEBLAPI.Message.Helper;
using PlayerIOClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EEBL
{
    class EEBotLoader
    {
        public static EEBotLoader Instance;

        public List<IBot> Bots = new List<IBot>();

        public PlayerHandler playerHandler;
        public ChatQueue chatQueue;

        public Client client;
        public Connection conn;

        public EEBotLoader()
        {
            Console.Title = "EverybodyEdits Bot Loader";
            if (Instance != null)
            {
                LogHelper.Warn("Type -> EEBL:DuplicateInstance Blocked. This should not occur.");
                return;
            }

            Instance = this;

            Directory.CreateDirectory(Directories.BOT_PATH);

            Bots = (List<IBot>)BotLoaderHandler.Load();

            try
            {
                // TODO: Possible Login and RoomID presets (including a Login/RoomID preset system).
                // TODO: Implement a neater Login System w/ saving compatabilities (encryption w/ key on computer, not local folder to prevent accidently sending sensitive information while sharing bot list). Additionally, add others beside Email/Pass.
                
                LogHelper.Info("Logging In...");

                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Password:");
                StringBuilder stringBuilder = new StringBuilder();
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                    stringBuilder.Append(key.KeyChar);
                } while (key.Key != ConsoleKey.Enter);
                string pass = stringBuilder.ToString();
                stringBuilder.Clear();

                client = PlayerIO.QuickConnect.SimpleConnect(EverybodyEdits.GAME_ID, email, pass, null); //TODO: On Failure, Try Again.
                //disposes pass asap.
                pass = String.Empty;

                LogHelper.Info("Logged In.");
                try
                {
                    LogHelper.Info("Joining Room: ");
                    //TODO: Linked to settings in which can skip this step and use a 'default'.
                    string worldId = Console.ReadLine();

                    int serverVersion = (int)client.BigDB.Load("config", "config")["version"];
                    if (EverybodyEdits.CURRENT_VERSION != serverVersion)
                    {
                        LogHelper.Warn("POSSIBLE INCOMPATABILITIES: SERVER VERSION IS '" + serverVersion + "' AND THIS VERSION OF EEBL IS BUILT FOR '" + EverybodyEdits.CURRENT_VERSION + "'");
                    }

                    playerHandler = new PlayerHandler();
                    var preInitEvent = new EEBLPreInitEvent(playerHandler);
                    conn = this.client.Multiplayer.JoinRoom(worldId, null);
                    conn.OnMessage += Conn_OnMessage;

                    conn.Send("init");
                    LogHelper.Info("Succesfully Joined!");
                }
                catch (Exception e)
                {
                    LogHelper.Warn("Failed to Connect to Room!");
                    LogHelper.Warn(e.Message);
                }
                LogHelper.Info("Logged In!");
            }
            catch (Exception e)
            {
                LogHelper.Warn("Failed to Log In!");
                LogHelper.Warn(e.Message);
            }
        }

        private void Conn_OnMessage(object sender, PlayerIOClient.Message e)
        {
            switch (e.Type)
            {
                case "init":
                    chatQueue = new ChatQueue();
                    var initEvent = new EEBLInitEvent(chatQueue);
                    Bots.ForEach(bot => bot.OnInit(initEvent));
                    conn.Send("init2");
                    break;

                case "add":
                    NamedMessageAdd message = new NamedMessageAdd(new MessageAdd(e));

                    EEBLAPI.Player.Player player = new EEBLAPI.Player.Player(message.UniqueUserId);
                    player.Id = message.Id;
                    player.Username = message.Username;
                    playerHandler.AddPlayer(player);
                    playerHandler.PlayerJoin(player, message.SourceMessage);
                    break;

                case "left":
                    playerHandler.RemovePlayer(
                        playerHandler.GetPlayer(e.GetInt(0))
                        );
                    break;
            }
        }
    }
}