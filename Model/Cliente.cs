using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class Cliente
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("aPaterno")]
        public string aPaterno { get; set; }
        [JsonProperty("aMaterno")]
        public string aMaterno { get; set; }
        [JsonProperty("rfc")]
        public string rfc { get; set; }
        [JsonProperty("fechaRegistro")]
        public string fechaRegistro { get; set; }
        [JsonProperty("pan")]
        public string pan { get; set; }
        [JsonProperty("nombreCompleto")]
        public string nombreCompleto { get; set; }
        [JsonProperty("importeCredito")]
        public int importeCredito { get; set; }
        [JsonProperty("idSucursal")]
        public int idSucursal { get; set; }
        [JsonProperty("sucursal")]
        public string sucursal { get; set; }
        [JsonProperty("idEmpresa")]
        public int idEmpresa { get; set; }
        [JsonProperty("empresa")]
        public string empresa { get; set; }
        [JsonProperty("estatus")]
        public int estatus { get; set; }
        [JsonProperty("idSeguro")]
        public string idSeguro { get; set; }
        [JsonProperty("nombreSeguro")]
        public string nombreSeguro { get; set; }
        [JsonProperty("idProductoFinanciero")]
        public int idProductoFinanciero { get; set; }
        [JsonProperty("nombreProductoFinanciero")]
        public string nombreProductoFinanciero { get; set; }
        [JsonProperty("indObligado")]
        public bool indObligado { get; set; }
        //[JsonProperty("code")]
        //public string code { get; set; }

    }
}
