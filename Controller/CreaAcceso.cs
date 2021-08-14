using Newtonsoft.Json;
using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class CreaAcceso
    {
        public string GetCredentials(string user, string pwd)
        {
            //Genera psw encriptado
            var misha = new GetCryptSHA512();
            string hPassword = misha.ComputeHash(pwd, new SHA256CryptoServiceProvider());
            hPassword = hPassword.Replace("-", String.Empty);
            hPassword = hPassword.ToLower();
            // Genera Serialización de servicios de entrada
            Login login = new Login
            {
                usr = user,
                psw = hPassword
            };
            string cajason = JsonConvert.SerializeObject(login, Formatting.Indented);
            return cajason;
        }
    }
}
