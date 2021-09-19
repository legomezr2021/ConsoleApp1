using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class EmpresaRequest
    {
        [JsonProperty("idFinanciera")]
        public int idFinanciera { get; set; }
    }
}
