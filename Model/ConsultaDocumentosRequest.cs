using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class ConsultaDocumentosRequest
    {
        [JsonProperty("idCliente")]
        public int idCliente { get; set; }
        public int idCatDocumento { get; set; }
        public Seguridad seguridad { get; set; }
    }
}
