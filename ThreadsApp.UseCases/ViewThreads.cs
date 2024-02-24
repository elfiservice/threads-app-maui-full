namespace ThreadsApp.UseCases;
using ThreadsApp.CoreBusiness;

public class ViewThreads
{
    public async Task<IEnumerable<AThread>> ExecuteAsync()
    {
        return await Task.Run(() => {

            return new[]
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
    });
        // return new[]
        // {
        //     new AThread
        //     {
        //         User = new AUser
        //         {
        //             UserName = "jamesmontemagno",
        //             DisplayName = "James Montemagno",
        //             IsVerified = true,
        //             IsFollowing = false,
        //             Image = "profilecircle.png",
        //             FollowerCount = 1500
        //         },
        //         Message = "This is a thread message that you should read",
        //         Likes = 10, Replies = 2, TimeAgo = "2h"
        //     },
        //     new AThread
        //     {
        //         User = new AUser
        //         {
        //             UserName = "shanselman",
        //             DisplayName = "Scott Hanselman",
        //             IsVerified = true,
        //             IsFollowing = false,
        //             HasSimilarFollowers = true,
        //             Image = "profilecircle.png",
        //             FollowerCount = 15
        //         },
        //         Message = "This is a thread message that you should read",
        //         Likes = 10, Replies = 2, TimeAgo = "2h"
        //     }
        // };
    }
}
