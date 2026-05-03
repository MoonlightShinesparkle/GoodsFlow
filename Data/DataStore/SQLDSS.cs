#define Debug
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using GoodsFlow.UserManager;
using Supabase;

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
    public static Store? GetStoreData(string StoreName)
    {
        Store New = new(StoreName);
        bool StoreExists = true;

        // TODO: Fetch data from static connection
        // TODO: If data couldn't be fetched, set StoreExists to false

        if (!StoreExists)
        {
            return null;
        }

        // TODO: Load user data into store
        /*
            Loading user data includes the name, the hashed password and its assigned salt
            IMPORTANT: the store has a password tied to it, this password has to be tied to "Admin"
         */

#if Debug
        New.Users.Add(new(StoreName,"Moonlight", "f693ee9f422e3ce09e28761ea2e0154fa9abb2f05551b154d2c1dad2dba16b2e", "062e2462bfc8e1f62609"));
#endif

        return New;
    }
}

public class Store(string Name)
{
    /// <summary>
    /// Contains all user information
    /// </summary>
    public List<UserInfo> Users = [];
    public string Name = Name;

    // TODO: Add other data things to save, add as necesary, ensure it gets loaded in GetStoreData in SQLDSS

    /// <summary>
    /// Fetches a user's data
    /// </summary>
    /// <param name="Name">Name of the user to look for</param>
    /// <returns>Loaded UserInfo if user is found, else returns null</returns>
    public UserInfo? GetUser(string Name)
    {
        foreach (UserInfo Info in Users) { 
            if (Info.NameData == Name)
            {
                return Info;
            }
        }
        return null;
    }
}