using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class DatosGeneralesClienteResponse
    {
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("aPaterno")]
        public string aPaterno { get; set; }
        [JsonProperty("aMaterno")]
        public string aMaterno { get; set; }
        [JsonProperty("fechaNacimiento")]
        public long fechaNacimiento { get; set; }
        [JsonProperty("curp")]
        public string curp { get; set; }
        [JsonProperty("rfc")]
        public string rfc { get; set; }
        [JsonProperty("tipoIdentificacion")]
        public string tipoIdentificacion { get; set; }
        [JsonProperty("noIdentificacion")]
        public string noIdentificacion { get; set; }
        [JsonProperty("nacionalidad")]
        public string nacionalidad { get; set; }
        [JsonProperty("paisNacimiento")]
        public string paisNacimiento { get; set; }
        [JsonProperty("entidadFederativaNacimiento")]
        public string entidadFederativaNacimiento { get; set; }
        [JsonProperty("genero")]
        public string genero { get; set; }
        [JsonProperty("edoCivil")]
        public string edoCivil { get; set; }
        [JsonProperty("escolaridad")]
        public string escolaridad { get; set; }
        [JsonProperty("ocupacion")]
        public string ocupacion { get; set; }
        [JsonProperty("scoreBuro")]
        public string scoreBuro { get; set; }
        [JsonProperty("code")]
        public string code { get; set; }

    }
}
