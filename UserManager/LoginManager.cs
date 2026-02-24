using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace GoodsFlow.UserManager;

public class LoginManager
{
    public struct SaltedEntry(string Entry, string Salt){
        public readonly string Entry = Entry;
        public readonly string Salt = Salt;
    }

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
    /// <returns>Computed hash and salt</returns>
    public static SaltedEntry Hash(string Input) {
        return Hash(Input, GenSalt(10));
    }

    /// <summary>
    /// Computes the hash for a given input and its salt
    /// </summary>
    /// <param name="Input">Text to hash</param>
    /// <param name="Salt">Previously generated salt</param>
    /// <returns>Computed hash from the salted input</returns>
    public static SaltedEntry Hash(string Input, string Salt) {
        return new SaltedEntry(RawHash(Salt+Input), Salt);
    }

    /// <summary>
    /// Computes the SHA256 hash of the given input
    /// </summary>
    /// <param name="Input">Text to hash</param>
    /// <returns>Computed hash from given string</returns>
    public static string RawHash(string Input) {
        StringBuilder Hashed = new();

        byte[] Result = SHA256.HashData(Encoding.UTF8.GetBytes(Input));

        foreach (byte C in Result)
        {
            Hashed.Append(C.ToString("x2"));
        }

        return Hashed.ToString();
    }
}
