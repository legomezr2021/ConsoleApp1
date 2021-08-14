using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Seguridad
    {
        [JsonProperty("userID")]
        public int userID { get; set; }

        [JsonProperty("tokenID")]
        public string tokenID { get; set; }


    }
}
