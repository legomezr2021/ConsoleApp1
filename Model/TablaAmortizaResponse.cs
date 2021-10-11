using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class TablaAmortizaResponse
    {
        public int id { get; set; }
        public int pagoNo { get; set; }
        public int totalPagos { get; set; }
        public int montoPago { get; set; }
        public long fechaPago { get; set; }
        public int idMovimientoTarjeta { get; set; }
        public string concepto { get; set; }
        public bool indLiquidado { get; set; }
    }
}
