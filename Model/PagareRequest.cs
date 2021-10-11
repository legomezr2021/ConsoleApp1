using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class PagareRequest
    {
        [JsonProperty("idMovement")]
        public int idMovement { get; set; }
        public Seguridad seguridad { get; set; }
    }
}
