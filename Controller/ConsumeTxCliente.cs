using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Controller
{
    class ConsumeTxCliente
    {
        public IList<TxClienteResponse> GetTxCliente(int pidCliente, int ptxNoDe, int ptxNoA, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            TxClienteRequest txclienterequest = new TxClienteRequest
            {
                idCliente = pidCliente,
                txNoDe = ptxNoDe,
                txNoA = ptxNoA,
                seguridad = miseguridad
            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(txclienterequest, Formatting.Indented);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/financial/search/transaccion");
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
            IList<JToken> results = objectres["movements"].Children().ToList();
            // Serializa resultados JSON a un objeto .NET
            IList<TxClienteResponse> searchResults = new List<TxClienteResponse>();
            //Llena una lista de Obejtis Model Cliente Deserializados
            foreach (JToken result in results)
            {
                TxClienteResponse searchResult = JsonConvert.DeserializeObject<TxClienteResponse>(result.ToString());
                searchResults.Add(searchResult);
            }
            //Devuelve la lista de Transacciones de Clientes
            return searchResults;
        }
    }
}
