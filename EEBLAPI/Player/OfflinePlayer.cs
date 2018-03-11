using System.Collections.Generic;

namespace EEBLAPI.Player
{
    public abstract class OfflinePlayer : IOfflinePlayer
    {
        string _uuid;
        public OfflinePlayer(string uuid)
        {
            _uuid = uuid;
            _tags = new Dictionary<string, object>();
        }

        public Dictionary<string, object> _tags;
        public Dictionary<string, object> Tags { get { return _tags; } set { _tags = value; } }

        public string UniqueId => _uuid;

        public void SetValue(string tag, object value)
        {
            if (Tags.ContainsKey(tag))
                Tags[tag] = value;
            else
                Tags.Add(tag, value);
        }

        public object GetValue(string tag)
        {
            if (!Tags.ContainsKey(tag))
                return null;
            return Tags[tag];
        }

        public object GetValueOrDefault(string tag, object value) => Tags.GetValueOrDefault(tag, value);
    }
}
