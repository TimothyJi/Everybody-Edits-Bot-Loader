using EEBLAPI.Chat;

namespace EEBLAPI.Event
{
    public class EEBLInitEvent
    {
        public IChatQueue ChatQueue { get; set; }

        public EEBLInitEvent(IChatQueue chatQueue)
        {
            ChatQueue = chatQueue;
        }

        public IChatQueue GetChatQueue() => ChatQueue;
    }
}
