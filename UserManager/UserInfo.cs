using static GoodsFlow.UserManager.LoginManager;

namespace GoodsFlow.UserManager;

/// <summary>
/// User data store entry, contains all hash dependent data
/// </summary>
/// <param name="Store">Store name</param>
/// <param name="Name">Username</param>
/// <param name="Password">Password hash</param>
/// <param name="PasswordSalt">Password salt</param>
public class UserInfo(string Store, string Name, string Password, string PasswordSalt) {

    public readonly string StoreData = Store;
    public readonly string NameData = Name;
    public readonly SaltedEntry PasswordData = new(Password, PasswordSalt);

    /// <summary>
    /// Tests whether the password matches or not
    /// </summary>
    /// <param name="Password">Given password</param>
    /// <returns>Login success/failure</returns>
    public bool PasswordMatches(string Password) {
        return Hash(Password, PasswordData.Salt).Entry == PasswordData.Entry;
    }
}
