namespace ThreadsApp.UseCases;
using ThreadsApp.CoreBusiness;

public class ViewThreadsUseCase : BaseUseCase<AThread>
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
