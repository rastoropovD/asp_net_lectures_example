using DataAccess.Entities;

namespace DataAccess.Repositories;

public interface IUsersRepository
{
    public IEnumerable<UserEntity> GetUsers();
}