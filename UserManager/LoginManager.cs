using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace GoodsFlow.UserManager;

public class LoginManager
{
    public static string? AccountHash = null;
    public static void Hash(string Input) {
        SHA256 Crypt = SHA256.Create();
        StringBuilder Hashed = new();

        byte[] Result = Crypt.ComputeHash(Encoding.UTF8.GetBytes(Input));

        foreach (byte C in Result) {
            Hashed.Append(C.ToString("x2"));
        }

        AccountHash = Hashed.ToString();
    }
}
