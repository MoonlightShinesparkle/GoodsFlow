using GoodsFlow.Data.DataStore.Tables;
using static GoodsFlow.UserManager.LoginManager;

namespace GoodsFlow.UserManager;

/// <summary>
/// User data store entry, contains all hash dependent data
/// </summary>
/// <param name="Store">Store name</param>
/// <param name="Name">Username</param>
/// <param name="Password">Password hash</param>
/// <param name="PasswordSalt">Password salt</param>
public class UserInfo {
    public readonly int ID;
    public readonly int StoreID;
    public readonly string NameData;
    public readonly SaltedEntry PasswordData;
    public readonly int RoleID;

    public UserInfo(User Usr)
    {
        ID = Usr.ID;
        StoreID = Usr.StoreID;
        NameData = Usr.Name ?? "";
        PasswordData = new(Usr.Password ?? "", Usr.Salt ?? "");
        RoleID = Usr.RoleID;
    }

    public UserInfo(int StoreID, string Name, string Password, string Salt)
    {
        ID = -1;
        this.StoreID = StoreID;
        NameData = Name;
        PasswordData = new(Password, Salt);
        RoleID = -1;
    }

    /// <summary>
    /// Tests whether the password matches or not
    /// </summary>
    /// <param name="Password">Given password</param>
    /// <returns>Login success/failure</returns>
    public bool PasswordMatches(string Password) {
        return Hash(Password, PasswordData.Salt).Entry == PasswordData.Entry;
    }
}
