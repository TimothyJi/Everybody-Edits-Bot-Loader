namespace EEBLAPI.Player
{
    public interface IPlayer : IOfflinePlayer
    {
        int Id { get; }
        string Username { get; }
    }
}
