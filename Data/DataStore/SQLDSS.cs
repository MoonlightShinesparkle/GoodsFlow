#define Debug
using GoodsFlow.Data.DataStore.Tables;
using GoodsFlow.UserManager;
using Supabase;
using Supabase.Postgrest.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodsFlow.Data.DataStore;

public class SQLDSS
{
    private static string ConnectionString = "https://tlufmhzpernsisoqycsg.supabase.co";
    private static string AnonKey = "sb_publishable_9FIaH19p3eDkAeYon_FtbA_U4NkdD3F";

    public static Client SupabaseConnection = new(ConnectionString, AnonKey, new SupabaseOptions
    {
        AutoRefreshToken = true,
        AutoConnectRealtime = false
    });

    public static async Task InitializeConnection()
    {
        await SupabaseConnection.InitializeAsync();
    }

    /// <summary>
    /// Fetches data from a store and stores into an object for its usage
    /// </summary>
    /// <param name="StoreName">Name of the store to fetch data from</param>
    /// <returns>A Store with loaded data if found, null if no data was found</returns>
    public static async Task<StoreWrapper?> GetStoreData(string StoreName)
    {

        Supabase.Postgrest.Responses.ModeledResponse<Store> Stores = await SupabaseConnection.From<Store>().Where(
            S => S.Name == StoreName
        ).Get();

        Store? Found = Stores.Models.FirstOrDefault();

        if (Found == null)
        {
            return null;
        }

        return await LoadStoreDataAsync(Found);
    }

    public static async Task<StoreWrapper> LoadStoreDataAsync(Store Given)
    {
        StoreWrapper Loadable = new(Given);
        Loadable.Users.Add(new(Loadable.ID, Loadable.AdminName, Loadable.AdminPass, Loadable.AdminSalt));

        Supabase.Postgrest.Responses.ModeledResponse<User> Users = await SupabaseConnection.From<User>().Where(
            U => U.StoreID == Loadable.ID
        ).Get();

        foreach (User Usr in Users.Models)
        {
            Loadable.Users.Add(new(Usr));
        }

        return Loadable;
    }
}

/// <summary>
/// Wrapper for a store to allow additional info to be accessed
/// </summary>
/// <param name="Str">Store to wrap around of</param>
public class StoreWrapper(Store Str)
{
    public int ID = Str.ID;
    public string Name = Str.Name ?? "";
    public string? Location = Str.Location;
    public string? Contact = Str.Contact;
    public string AdminName = Str.AdminName ?? "";
    public string AdminPass = Str.AdminPass ?? "";
    public string AdminSalt = Str.AdminSalt ?? "";

    /// <summary>
    /// Contains all user information
    /// </summary>
    public List<UserInfo> Users = [];

    // TODO: Add other data things to save, add as necesary, ensure it gets loaded in GetStoreData in SQLDSS

    /// <summary>
    /// Fetches a user's data
    /// </summary>
    /// <param name="Name">Name of the user to look for</param>
    /// <returns>Loaded UserInfo if user is found, else returns null</returns>
    public UserInfo? GetUser(string Name)
    {
        foreach (UserInfo Info in Users)
        {
            if (Info.NameData == Name)
            {
                return Info;
            }
        }
        return null;
    }
}