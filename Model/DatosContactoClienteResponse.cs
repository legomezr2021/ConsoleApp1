using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class DatosContactoClienteResponse
    {
        public Seguridad seguridad { get; set; }
        public string telefonoFijo { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string code { get; set; }
        
    }
}
