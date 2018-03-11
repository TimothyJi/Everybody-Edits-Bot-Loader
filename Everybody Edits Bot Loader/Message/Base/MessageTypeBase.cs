using PlayerIOClient;

namespace EEBL.Message.Base
{
    class MessageTypeBase
    {
        private PlayerIOClient.Message _message;
        public MessageTypeBase(PlayerIOClient.Message message)
        {
            _message = message;
        }

        public PlayerIOClient.Message Message => _message;

        protected int AInt(uint id) => Message.GetInt(id);
        protected uint AUInt(uint id) => Message.GetUInt(id);
        protected bool ABool(uint id) => Message.GetBoolean(id);
        protected double ADouble(uint id) => Message.GetDouble(id);
        protected string AString(uint id) => Message.GetString(id);
        protected byte[] AByteArray(uint id) => Message.GetByteArray(id);
    }
}
