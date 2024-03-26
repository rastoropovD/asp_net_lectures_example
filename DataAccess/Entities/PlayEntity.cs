namespace DataAccess.Entities;

public sealed class PlayEntity
{
    public int Id { get; }
    public double Score { get; }
    public DateTime PlayedAt { get; }
    public int GameId { get; }
    public int UserId { get; }

    public UserEntity? User => MockDb.MockDb.Users.GetValueOrDefault(UserId);
    public GameEntity? Game => MockDb.MockDb.Games.GetValueOrDefault(GameId);

    public PlayEntity(int id, double score, DateTime playedAt, int gameId, int userId)
    {
        Id = id;
        Score = score;
        PlayedAt = playedAt;
        GameId = gameId;
        UserId = userId;
    }
}