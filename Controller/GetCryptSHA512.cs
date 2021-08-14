using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    class GetCryptSHA512
    {
        public string GetCrypt(string text)
        {
            string hash = "";
            SHA512 alg = SHA512.Create();
            byte[] result = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
            byte[] hashedBytes = alg.ComputeHash(result);
            hash = Encoding.UTF8.GetString(hashedBytes);
            return BitConverter.ToString(result);
        }
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
