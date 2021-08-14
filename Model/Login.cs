using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Login
    {
        [JsonProperty("usr")]
        public string usr { get; set; }
        [JsonProperty("psw")]
        public string psw { get; set; }
    }
}
