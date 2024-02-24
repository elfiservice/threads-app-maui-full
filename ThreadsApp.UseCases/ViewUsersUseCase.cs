using ThreadsApp.CoreBusiness;

namespace ThreadsApp.UseCases;

public class ViewUsersUseCase : IViewUsersUseCase
{
    private readonly IUserRepository usersRepository;

    public ViewUsersUseCase(IUserRepository usersRepository)
    {
        this.usersRepository = usersRepository;
    }

    public async Task<IEnumerable<AUser>> ExecuteAsync()
    {
        return await this.usersRepository.GetUsersAsync();
    }
}
