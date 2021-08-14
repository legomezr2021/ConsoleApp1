using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Controller
{
    class ConsumeLogin
    {
        public Seguridad GetSecurity (string usr, string psw)
        {
            //Genera credenciales
            var acceso = new CreaAcceso();
            var body = acceso.GetCredentials(usr, psw);
            Console.WriteLine(body);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/user/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // Arma y ejecuta servicio 
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            JObject objectres = JObject.Parse(json);
            Console.WriteLine("Onjeto parseado " + objectres);
            // Obtener la propiedades result en una lista 
            Console.WriteLine(objectres["seguridad"].ToString());
            // Serializa resultados JSON a un objeto .NET
            Seguridad searchResult = JsonConvert.DeserializeObject<Seguridad>(objectres["seguridad"].ToString());
            return searchResult;
        }
    }
}
