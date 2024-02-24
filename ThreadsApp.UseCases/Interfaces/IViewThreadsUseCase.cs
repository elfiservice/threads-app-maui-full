using ThreadsApp.CoreBusiness;

namespace ThreadsApp.UseCases;

public interface IViewThreadsUseCase
{
    Task<IEnumerable<AThread>> ExecuteAsync();
}
