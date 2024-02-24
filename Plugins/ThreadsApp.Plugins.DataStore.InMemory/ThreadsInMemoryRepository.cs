using ThreadsApp.CoreBusiness;
using ThreadsApp.UseCases;

namespace ThreadsApp.Plugins.DataStore.InMemory;

// here the Concrete implementation of the IThreadRepository from UseCases layer
public class ThreadsInMemoryRepository : IThreadRepository
{

    private static AThread[] _threads;

    public ThreadsInMemoryRepository()
    {
        _threads = new[]
            {
                new AThread
                {
                    User = new AUser
                    {
                        UserName = "jamesmontemagno",
                        DisplayName = "James Montemagno",
                        IsVerified = true,
                        IsFollowing = false,
                        Image = "profilecircle.png",
                        FollowerCount = 1500
                    },
                    Message = "This is a thread message that you should read",
                    Likes = 5, Replies = 44, TimeAgo = "22h"
                },
                new AThread
                {
                    User = new AUser
                    {
                        UserName = "shanselman",
                        DisplayName = "Scott Hanselman",
                        IsVerified = true,
                        IsFollowing = false,
                        HasSimilarFollowers = true,
                        Image = "profilecircle.png",
                        FollowerCount = 15
                    },
                    Message = "This is a thread message that you should read",
                    Likes = 10, Replies = 2, TimeAgo = "2h"
                }
            };
    }

    public Task<IEnumerable<AThread>> GetThreadsAsync()
    {
        return Task.FromResult<IEnumerable<AThread>>(_threads);
    }
}
