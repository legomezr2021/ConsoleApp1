using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Controller
{
    class ConsumePlaza
    {
        public IList<PlazaResponse> GetPlaza(int pidEmpresa, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            PlazaRequest plaza = new PlazaRequest
            {
                idEmpresa = pidEmpresa
            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(plaza, Formatting.Indented);
            Console.WriteLine("Petición: " + body);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/catalog/organization/plaza");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // Arma y ejecuta servicio 
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            // Obtener la propiedades en una lista 
            json = "{\"plazas\":" + json + "}";
            JObject objectres = JObject.Parse(json);
            Console.WriteLine("Onjeto parseado " + objectres);
            IList<JToken> results = objectres["plazas"].Children().ToList();
            // Serializa resultados JSON a un objeto .NET
            IList<PlazaResponse> searchResults = new List<PlazaResponse>();
            //Llena una lista de Obejtos Model Empresa Deserializados
            foreach (JToken result in results)
            {
                PlazaResponse searchResult = JsonConvert.DeserializeObject<PlazaResponse>(result.ToString());
                searchResults.Add(searchResult);
            }
            //Devuelve la lista de Empresas
            return searchResults;
        }
    }
}
