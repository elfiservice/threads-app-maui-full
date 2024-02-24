using ThreadsApp.CoreBusiness;

namespace ThreadsApp.UseCases;

public interface IThreadRepository
{
    Task<IEnumerable<AThread>> GetThreadsAsync();
}
