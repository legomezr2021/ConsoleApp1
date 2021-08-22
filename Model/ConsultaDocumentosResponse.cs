
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class ConsultaDocumentosResponse
    {
        public string contenido { get; set; }
        public CatDocumentoResponse catDocumentoResponse { get; set; }
        public CatTipoImagenResponse catTipoImagenResponse { get; set; }
        public string code { get; set; }
    }
}
