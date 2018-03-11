namespace EEBLAPI.Event
{
    public class EEBLLoadEvent
    {
        IBotBase[] botList;

        public EEBLLoadEvent(IBotBase[] botList)
        {
            this.botList = botList;
        }

        public IBotBase[] GetLoadedBots()
        {
            return botList;
        }
    }
}
