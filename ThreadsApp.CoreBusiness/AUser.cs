using CommunityToolkit.Mvvm.ComponentModel;
using Humanizer;

namespace ThreadsApp.CoreBusiness;

// All the code in this file is included in all platforms.
public partial class AUser : ObservableObject
{
    [ObservableProperty]
    string userName;

    [ObservableProperty]
    string displayName;

    [ObservableProperty]
    int followerCount;

    [ObservableProperty]
    string image;

    [ObservableProperty]
    bool isVerified;

    [ObservableProperty]
    bool isFollowing;
    
    [ObservableProperty]
    bool hasSimilarFollowers;

    public string FollowersDisplay => $"{FollowerCount.ToMetric().ToUpper()} followers";
}
