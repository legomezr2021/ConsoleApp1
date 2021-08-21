using ConsoleApp1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Controller
{
    class ConsumeDatosProducto
    {
        public DatosProductoResponse GetDataProduct(int pidCliente, string pusr, string ppsw)
        {
            //Crea objetos para seguridad
            ConsumeLogin consumelogin = new ConsumeLogin();
            Seguridad miseguridad = new Seguridad();
            //Obtiene Crdenciales
            miseguridad = consumelogin.GetSecurity(pusr, ppsw);
            //Crea objeto a serializar
            DatosProductoRequest datosproductorequestReq = new DatosProductoRequest
            {
                idCliente = pidCliente,
                seguridad = miseguridad

            };
            //Serializa peticion del servicio
            string body = JsonConvert.SerializeObject(datosproductorequestReq, Formatting.Indented);
            //Genera llamado a servicio de seguridad
            var client = new RestClient("https://krsrdgwsw.xicantel.com:8453/auth/api/financial/data/producto");
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
            // Serializa resultados JSON a un objeto .NET
            DatosProductoResponse searchResult = JsonConvert.DeserializeObject<DatosProductoResponse>(objectres.ToString());
            return searchResult;
        }
    }
}
