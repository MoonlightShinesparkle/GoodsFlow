using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace GoodsFlow.UserManager;

public class LoginManager
{
    /// <summary>
    /// Creates a pile of salt attachable to a hash input
    /// </summary>
    /// <param name="Size">Ammount of salt crystals to create</param>
    /// <returns>A pile of #Size salt crystals</returns>
    public static string GenSalt(int Size) {
        RandomNumberGenerator Gen = RandomNumberGenerator.Create();
        StringBuilder Salt = new();

        byte[] Crystals = new byte[Size];
        Gen.GetBytes(Crystals);

        foreach (byte C in Crystals) {
            Salt.Append(C.ToString("x2"));
        }

        Gen.Dispose();

        return Salt.ToString();
    }

    /// <summary>
    /// Computes the hash for a given input, creating a new salt for it
    /// </summary>
    /// <param name="Input">Text to hash</param>
    /// <param name="Salt">Created salt pile</param>
    /// <returns>Computed hash and salt</returns>
    public static string Hash(string Input, out string Salt) {
        Salt = GenSalt(10);
        return Hash(Input, Salt);
    }

    /// <summary>
    /// Computes the hash for a given input and its salt
    /// </summary>
    /// <param name="Input">Text to hash</param>
    /// <param name="Salt">Previously generated salt</param>
    /// <returns>Computed hash from the salted input</returns>
    public static string Hash(string Input, string Salt) {
        StringBuilder Hashed = new();

        byte[] Result = SHA256.HashData(Encoding.UTF8.GetBytes(Salt+Input));

        foreach (byte C in Result) {
            Hashed.Append(C.ToString("x2"));
        }

        return Hashed.ToString();
    }
}
