using System.Security.Cryptography;
using System;
using System.Text;

namespace ChatEngine.Service
{
    public static class CryptService
    {
        public static string GetMD5Hash(string input)
        {
            using (MD5 md5hasher = MD5.Create())
            {
                byte[] bytecode = md5hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytecode)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}
