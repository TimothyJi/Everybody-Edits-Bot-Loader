using System.Collections.Generic;
namespace EEBLAPI.Chat
{
    public enum ChatPriority
    {
        IMPORTANT,
        EXECUTE_COMMAND,
        NORMAL
    }

    public interface IChatQueue
    {
        Queue<string> priorityQueue { get; set; }
        Queue<string> commandQueue { get; set; }
        Queue<string> queue { get; set; }

        void SendChat(ChatPriority priority, string message);
    }
}
