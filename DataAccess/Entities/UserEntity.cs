namespace DataAccess.Entities;

public sealed class UserEntity
{
    public int Id { get; }
    public string UserName { get; }
    public string Email { get; }
    public string PasswordHash { get; }

    public UserEntity(int id, string userName, string email, string passwordHash)
    {
        Id = id;
        UserName = userName;
        Email = email;
        PasswordHash = passwordHash;
    }
}