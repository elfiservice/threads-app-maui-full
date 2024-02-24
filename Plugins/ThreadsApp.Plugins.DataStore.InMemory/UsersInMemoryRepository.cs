using ThreadsApp.CoreBusiness;
using ThreadsApp.UseCases;

namespace ThreadsApp.Plugins.DataStore.InMemory;

public class UsersInMemoryRepository : IUserRepository
{
    public Task<IEnumerable<AUser>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}
