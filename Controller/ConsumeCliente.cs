using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Controller
{
    class ConsumeCliente
    {
        public IList<Cliente> GetCliente(int pidCliente, string pperiodoDe, string pperiodoA, string pnombre,
            string paPaterno, string paMaterno, string prfc, string pidSucursal,
            string psucursal, string pidEmpresa, string pempresa, string pidProductoFinanciero,
            string pnombreProductoFinanciero, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            ClienteRequest cliente = new ClienteRequest
            {
                idCliente = pidCliente,
                periodoDe = pperiodoDe,
                periodoA = pperiodoA,
                nombre = pnombre,
                aPaterno = paPaterno,
                aMaterno = paMaterno,
                rfc = prfc,
                idSucursal = pidSucursal,
                sucursal = psucursal,
                idEmpresa = pidEmpresa,
                empresa = pempresa,
                idProductoFinanciero = pidProductoFinanciero,
                nombreProductoFinanciero = pnombreProductoFinanciero,
                seguridad = miseguridad
            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(cliente, Formatting.Indented);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/financial/search/cliente");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // Arma y ejecuta servicio 
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            // Obtener la propiedades en una lista 
            JObject objectres = JObject.Parse(json);
            Console.WriteLine("Onjeto parseado " + objectres);
            IList<JToken> results = objectres["cliente"].Children().ToList();
            // Serializa resultados JSON a un objeto .NET
            IList<Cliente> searchResults = new List<Cliente>();
            //Llena una lista de Obejtis Model Cliente Deserializados
            foreach (JToken result in results)
            {
                Cliente searchResult = JsonConvert.DeserializeObject<Cliente>(result.ToString());
                searchResults.Add(searchResult);
            }
            //Devuelve la lista de Clientes
            return searchResults;
        }   

    }
}
