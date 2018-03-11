using EEBL.Reference;
using EEBLAPI;
using EEBLAPI.Event;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace EEBL.Utils
{
    class BotLoaderHandler
    {
        /// <summary>
        /// Finds and Loads bots.
        /// </summary>
        /// <returns>A list of bots that were loaded.</returns>
        public static ICollection<IBot> Load()
        {
            try
            {
                LogHelper.Info("Finding Bots...");
                string[] botFileNames = Directory.GetFiles(Directories.BOT_PATH, "*.dll");
                ICollection<Assembly> assemblies = new List<Assembly>(botFileNames.Length);
                foreach (string dllFile in botFileNames)
                {
                    var assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + dllFile);
                    assemblies.Add(assembly);
                }

                Type botType = typeof(IBot);
                ICollection<Type> botTypes = new List<Type>();
                foreach (Assembly assembly in assemblies)
                {
                    if (assembly != null)
                    {
                        Type[] types = assembly.GetTypes();
                        foreach (Type type in types)
                        {
                            if (type.IsInterface || type.IsAbstract)
                            {
                                continue;
                            }
                            else
                            {
                                if (type.GetInterface(botType.FullName) != null)
                                {
                                    botTypes.Add(type);
                                }
                            }
                        }
                    }
                }

                var stringBuilder = new StringBuilder();
                var botNames = new List<string>();
                ICollection<IBot> bots = new List<IBot>(botTypes.Count);
                foreach (Type type in botTypes)
                {
                    var bot = (IBot)Activator.CreateInstance(type);
                    bots.Add(bot);
                    botNames.Add(bot.NAME);
                    LogHelper.Info("Bot Found: " + bot.NAME + " v" + bot.VERSION + " by " + bot.AUTHOR + ".");
                }
                stringBuilder.AppendJoin(", ", botNames);
                LogHelper.Info("Total Bots (" + botNames.Count + ").");

                //Pre Load
                LogHelper.Info("BotLoader - PreLoad Stage");
                foreach (var bot in bots)
                {

                    var logger = new Logger(bot.NAME);
                    logger.LogEvent += LogHelper.LogEvent;
                    var preLoadEvent = new EEBLPreLoadEvent("bots\\" + bot.NAME, logger);

                    try
                    {
                        if (!bot.PreLoad(preLoadEvent))
                        {
                            LogHelper.Warn(bot.NAME + " reported a failure to load at PreLoad stage!");
                            bots.Remove(bot);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Warn(bot.NAME + " crashed!" + Environment.NewLine +
                            ex.Message + Environment.NewLine + ex.StackTrace);
                    }
                }

                //Load
                LogHelper.Info("BotLoader - Load Stage");
                var botArray = new IBot[bots.Count];
                bots.CopyTo(botArray, 0);
                foreach (var bot in bots)
                {
                    var loadEvent = new EEBLLoadEvent(botArray);
                    try
                    {
                        if (!bot.Load(loadEvent))
                        {
                            LogHelper.Warn(bot.NAME + " reported a failure to load at Load stage!!");
                            bots.Remove(bot); // issue: mod is reported to other mods as loaded.
                        }
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Warn(bot.NAME + " crashed!" + Environment.NewLine +
                            ex.Message + Environment.NewLine + ex.StackTrace);
                    }
                }

                //TODO: ADD PostLoad?

                return bots;
            }
            catch (Exception e)
            {
                LogHelper.Warn("The Bot Loader crashed!" + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
            }
            return null;
        }
    }
}
