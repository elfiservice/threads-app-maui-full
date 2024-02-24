using ThreadsApp.CoreBusiness;

namespace ThreadsApp.UseCases;

public interface IViewUsersUseCase
{
    Task<IEnumerable<AUser>> ExecuteAsync();
}
