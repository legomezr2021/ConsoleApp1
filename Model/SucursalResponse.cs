using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class SucursalResponse
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("idEmpresa")]
        public int idEmpresa { get; set; }
        [JsonProperty("idSucursalPlaza")]
        public int idSucursalPlaza { get; set; }
    }
}
