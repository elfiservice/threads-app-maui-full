using ThreadsApp.CoreBusiness;
using ThreadsApp.UseCases;

namespace ThreadsApp.Plugins.DataStore.InMemory;

public class UsersInMemoryRepository : IUserRepository
{
    private static AUser[] _users;

    public UsersInMemoryRepository()
    {
        _users = new[]
        {
            new AUser
            {
                UserName = "jamesmontemagno",
                DisplayName = "James Montemagno",
                IsVerified = true,
                IsFollowing = false,
                Image = "profilecircle.png",
                FollowerCount = 1500
            },
            new AUser
            {
                UserName = "shanselman",
                DisplayName = "Scott Hanselman",
                IsVerified = false,
                IsFollowing = true,
                HasSimilarFollowers = true,
                Image = "profilecircle.png",
                FollowerCount = 1500000
            }
        };
    }

    public Task<IEnumerable<AUser>> GetUsersAsync()
    {
        return Task.FromResult<IEnumerable<AUser>>(_users);
    }
}
