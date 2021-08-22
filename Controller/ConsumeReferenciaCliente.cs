using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Controller
{
    class ConsumeReferenciaCliente
    {
        public IList<DatosReferenciaClienteResponse> GetReferenceClient (int pidCliente, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            DatosContactoClienteRequest datosContactoClienteRequestReq = new DatosContactoClienteRequest
            {
                idCliente = pidCliente,
                seguridad = miseguridad

            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(datosContactoClienteRequestReq, Formatting.Indented);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/financial/data/referencia");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // Arma y ejecuta servicio 
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            // Obtener la propiedades en una lista 
            JObject objectres = JObject.Parse(json);
            Console.WriteLine("Objeto parseado " + objectres);
            IList<JToken> results = objectres["reference"].Children().ToList();
            // Serializa resultados JSON a un objeto .NET
            IList<DatosReferenciaClienteResponse> searchResults = new List<DatosReferenciaClienteResponse>();
            //Llena una lista de Obejtis Model Cliente Deserializados
            foreach (JToken result in results)
            {
                DatosReferenciaClienteResponse searchResult = JsonConvert.DeserializeObject<DatosReferenciaClienteResponse>(result.ToString());
                searchResults.Add(searchResult);
            }
            //Devuelve la lista de Clientes
            return searchResults;
        }
    }
}
