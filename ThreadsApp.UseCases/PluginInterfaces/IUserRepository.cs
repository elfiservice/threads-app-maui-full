using ThreadsApp.CoreBusiness;

namespace ThreadsApp.UseCases;

public interface IUserRepository
{
    Task<IEnumerable<AUser>> GetUsersAsync();
}
