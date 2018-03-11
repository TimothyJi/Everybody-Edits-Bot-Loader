using System.Collections.Generic;

namespace EEBLAPI.Player
{
    public interface IOfflinePlayer
    {
        Dictionary<string, object> Tags { get; set; }
        string UniqueId { get; }

        void SetValue(string tag, object value);
        object GetValue(string tag);
        object GetValueOrDefault(string tag, object value);
    }
}
