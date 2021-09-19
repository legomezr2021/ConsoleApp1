using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class PlazaResponse
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("plaza")]
        public string plaza { get; set; }
    }
}
