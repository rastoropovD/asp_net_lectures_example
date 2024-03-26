namespace DataAccess.Entities;

public sealed class GameEntity
{
    public int Id { get; }
    public string Title { get; }

    public GameEntity(int id, string title)
    {
        Id = id;
        Title = title;
    }
}