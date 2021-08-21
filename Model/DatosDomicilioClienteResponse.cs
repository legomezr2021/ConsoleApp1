using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class DatosDomicilioClienteResponse
    {
        [JsonProperty("calle")]
        public string calle { get; set; }
        [JsonProperty("noExterior")]
        public string noExterior { get; set; }
        [JsonProperty("noInterior")]
        public string noInterior { get; set; }
        [JsonProperty("cp")]
        public string cp { get; set; }
        [JsonProperty("colonia")]
        public string colonia { get; set; }
        [JsonProperty("municipio")]
        public string municipio { get; set; }
        [JsonProperty("ciudadPoblacion")]
        public string ciudadPoblacion { get; set; }
        [JsonProperty("entidadFederativa")]
        public string entidadFederativa { get; set; }
        [JsonProperty("pais")]
        public string pais { get; set; }
        [JsonProperty("tipoVivienda")]
        public string tipoVivienda { get; set; }
        [JsonProperty("tiempoResidencia")]
        public string tiempoResidencia { get; set; }
        [JsonProperty("code")]
        public string code { get; set; }
    }
}
