using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class TablaAmortizaRequest
    {
        [JsonProperty("idCliente")]
        public int idCliente { get; set; }
        public Seguridad seguridad { get; set; }
    }
}
