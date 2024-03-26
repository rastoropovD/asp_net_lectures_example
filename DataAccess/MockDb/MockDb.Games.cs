using DataAccess.Entities;

namespace DataAccess.MockDb;

public static partial class MockDb
{
    public static Dictionary<int, GameEntity> Games = new Dictionary<int, GameEntity>()
    {
        {1, new GameEntity(1, "Game1")},
        {2, new GameEntity(2, "Game2")},
        {3, new GameEntity(3, "Game3")},
    };
}