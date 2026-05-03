using GoodsFlow.Data.DataStore;
using GoodsFlow.UserManager;

namespace GoodsFlow;

/// <summary>
/// Class that holds globally accessible data
/// </summary>
public class Globals
{
    public static StoreWrapper? StoreData = null;
    public static UserInfo? UserData = null;
    public static string GivenPassword = "";

    public static bool IsLoggedIn()
    {
        return (StoreData != null) 
            && (UserData != null) 
            && (GivenPassword.Trim() != string.Empty) 
            && UserData.PasswordMatches(GivenPassword);
    }
}
