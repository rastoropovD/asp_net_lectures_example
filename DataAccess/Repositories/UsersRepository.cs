using DataAccess.Entities;

namespace DataAccess.Repositories;

public sealed class UsersRepository : IUsersRepository
{
    public UsersRepository(string connectionString)
    {
        
    }
    
    public IEnumerable<UserEntity> GetUsers()
    {
        throw new NotImplementedException();
    }
}