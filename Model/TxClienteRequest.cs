using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class TxClienteRequest
    {
        [JsonProperty("idCliente")]
        public int idCliente { get; set; }
        [JsonProperty("txNoDe")]
        public int txNoDe { get; set; }
        [JsonProperty("txNoA")]
        public int txNoA { get; set; }
        public Seguridad seguridad { get; set; }
    }
}
