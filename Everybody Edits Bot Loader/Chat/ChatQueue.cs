using System.Collections.Generic;
using System.Timers;
using EEBLAPI.Chat;

namespace EEBL.Chat
{
    public class ChatQueue : IChatQueue
    {
        Timer timer;
        int interval = 500;

        public Queue<string> priorityQueue { get; set; }
        public Queue<string> commandQueue { get; set; }
        public Queue<string> queue { get; set; }

        public ChatQueue()
        {
            priorityQueue = new Queue<string>();
            commandQueue = new Queue<string>();
            queue = new Queue<string>();

            timer = new Timer
            {
                Interval = interval,
                Enabled = true
            };
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (EEBotLoader.Instance.conn.Connected == false)
            {
                priorityQueue.Clear();
                commandQueue.Clear();
                queue.Clear();
                timer.Enabled = false;
                return;
            }

            if (priorityQueue.Count > 0)
                EEBotLoader.Instance.conn.Send("say", priorityQueue.Dequeue());
            else if (commandQueue.Count > 0)
                EEBotLoader.Instance.conn.Send("say", commandQueue.Dequeue());
            else if (queue.Count > 0)
                EEBotLoader.Instance.conn.Send("say", queue.Dequeue());
        }

        public void SendChat(ChatPriority priority, string message)
        {
            switch (priority)
            {
                case ChatPriority.IMPORTANT:
                    priorityQueue.Enqueue(message);
                    break;
                case ChatPriority.EXECUTE_COMMAND:
                    commandQueue.Enqueue(message);
                    break;
                case ChatPriority.NORMAL:
                    queue.Enqueue(message);
                    break;
            }
        }
    }
}
