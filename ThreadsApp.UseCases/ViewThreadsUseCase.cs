namespace ThreadsApp.UseCases;
using ThreadsApp.CoreBusiness;

// NOTE: I can not use BaseUseCase<AThread> here because The Front-End does not have a reference to the CoreBusiness layer (AThread)
// So we can create a specific Interface to each UseCase
public class ViewThreadsUseCase : IViewThreadsUseCase
{
    private readonly IThreadRepository threadRepository;

    public ViewThreadsUseCase(IThreadRepository threadRepository)
    {
        this.threadRepository = threadRepository;
    }

    public async Task<IEnumerable<AThread>> ExecuteAsync()
    {
        return await this.threadRepository.GetThreadsAsync();
    }
}
