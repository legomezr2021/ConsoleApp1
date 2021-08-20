using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class DatosCreditoResponse
    {
        public Seguridad seguridad { get; set; }
        [JsonProperty("montoCredito")]
        public int montoCredito { get; set; }
        [JsonProperty("montoUtilizado")]
        public int montoUtilizado { get; set; }
        [JsonProperty("montoDisponible")]
        public int montoDisponible { get; set; }
        [JsonProperty("montoVencido")]
        public int montoVencido { get; set; }
        [JsonProperty("code")]
        public string code { get; set; }

    }
}
