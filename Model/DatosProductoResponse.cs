using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class DatosProductoResponse
    {
        public Seguridad seguridad { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("tipo")]
        public string tipo { get; set; }
        [JsonProperty("noTarjeta")]
        public int noTarjeta { get; set; }
        [JsonProperty("cat")]
        public int cat { get; set; }
        [JsonProperty("interesOrdinario")]
        public double interesOrdinario { get; set; }
        [JsonProperty("interesMoratorio")]
        public double interesMoratorio { get; set; }
        [JsonProperty("anualidad")]
        public int anualidad { get; set; }
        [JsonProperty("fechaCorte1")]
        public string fechaCorte1 { get; set; }
        [JsonProperty("fechaCorte2")]
        public string fechaCorte2 { get; set; }
        [JsonProperty("fechaLimitePago1")]
        public string fechaLimitePago1 { get; set; }
        [JsonProperty("fechaLimitePago2")]
        public string fechaLimitePago2 { get; set; }
        [JsonProperty("comisiones")]
        public string comisiones { get; set; }
        [JsonProperty("costoAdministrativo")]
        public string costoAdministrativo { get; set; }
        [JsonProperty("code")]
        public string code { get; set; }

    }
}
