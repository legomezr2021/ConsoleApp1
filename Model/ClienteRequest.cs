using Newtonsoft.Json;

namespace ConsoleApp1
{
    class ClienteRequest
    {
        [JsonProperty("idCliente")]
        public string idCliente { get; set; }
        [JsonProperty("periodoDe")]
        public string periodoDe { get; set; }
        [JsonProperty("periodoA")]
        public string periodoA { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("aPaterno")]
        public string aPaterno { get; set; }
        [JsonProperty("aMaterno")]
        public string aMaterno { get; set; }
        [JsonProperty("rfc")]
        public string rfc { get; set; }
        [JsonProperty("idSucursal")]
        public string idSucursal { get; set; }
        [JsonProperty("sucursal")]
        public string sucursal { get; set; }
        [JsonProperty("idEmpresa")]
        public string idEmpresa { get; set; }
        [JsonProperty("empresa")]
        public string empresa { get; set; }
        [JsonProperty("idProductoFinanciero")]
        public string idProductoFinanciero { get; set; }
        [JsonProperty("nombreProductoFinanciero")]
        public string nombreProductoFinanciero { get; set; }
        public Seguridad seguridad { get; set; }
    }
}
