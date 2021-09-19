using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class PlazaRequest
    {
        [JsonProperty("idEmpresa")]
        public int idEmpresa { get; set; }
    }
}
