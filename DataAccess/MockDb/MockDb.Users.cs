using DataAccess.Entities;

namespace DataAccess.MockDb;

public static partial class MockDb
{
    public static Dictionary<int, UserEntity?> Users = new Dictionary<int, UserEntity?>()
    {
        {1, new UserEntity(1, "Player1", "some@email.com", Guid.NewGuid().ToString())},
        {2, new UserEntity(2, "Player2", "other@email.com", Guid.NewGuid().ToString())},
        {3, new UserEntity(3, "Player3", "test@email.com", Guid.NewGuid().ToString())},
        {4, new UserEntity(4, "Player4", "general@email.com", Guid.NewGuid().ToString())},
        {5, new UserEntity(5, "Player5", "new.format@email.com", Guid.NewGuid().ToString())},
    };
}