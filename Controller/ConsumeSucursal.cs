using ConsoleApp1.Controller;
using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Model
{
    class ConsumeSucursal
    {
        public IList<SucursalResponse> GetSucursal (int pidEmpresa, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            SucursalRequest sucursal = new SucursalRequest
            {
                idEmpresa = pidEmpresa
            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(sucursal, Formatting.Indented);
            Console.WriteLine("Petición: " + body);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/catalog/organization/sucursal");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // Arma y ejecuta servicio 
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            // Obtener la propiedades en una lista 
            json = "{\"sucursales\":" + json + "}";
            JObject objectres = JObject.Parse(json);
            Console.WriteLine("Onjeto parseado " + objectres);
            IList<JToken> results = objectres["sucursales"].Children().ToList();
            // Serializa resultados JSON a un objeto .NET
            IList<SucursalResponse> searchResults = new List<SucursalResponse>();
            //Llena una lista de Obejtis Model Sucuesal Deserializados
            foreach (JToken result in results)
            {
                SucursalResponse searchResult = JsonConvert.DeserializeObject<SucursalResponse>(result.ToString());
                searchResults.Add(searchResult);
            }
            //Devuelve la lista de Sucursales
            return searchResults;
        }
    }
}
