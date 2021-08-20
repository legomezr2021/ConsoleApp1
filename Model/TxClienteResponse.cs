using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class TxClienteResponse
    {
        public int id { get; set; }

        public int idCliente { get; set; }
        public int idTransaccion { get; set; }
        public string pan { get; set; }
        public int noCredito { get; set; }
        public int producto { get; set; }
        public int tipoTransaccion { get; set; }
        public int importeTx { get; set; }
        public string fechaHora { get; set; }
        public string sucursal { get; set; }
        public string statusTx { get; set; }
        public int perfilTransaccional { get; set; }
        public int noAutorizacion { get; set; }
    }
}
