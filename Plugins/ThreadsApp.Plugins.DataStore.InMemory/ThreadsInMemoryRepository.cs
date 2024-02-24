using ThreadsApp.CoreBusiness;
using ThreadsApp.UseCases;

namespace ThreadsApp.Plugins.DataStore.InMemory;

// here the Concrete implementation of the IThreadRepository from UseCases layer
public class ThreadsInMemoryRepository : IThreadRepository
{
    public Task<IEnumerable<AThread>> GetThreadsAsync()
    {
        throw new NotImplementedException();
    }
}
