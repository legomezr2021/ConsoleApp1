using System;
using System.Collections.Generic;
using ConsoleApp1.Controller;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
        class Program
    {
        static void Main(string[] args)
        {
         /*   // Prueba consumo Cliente
            ConsumeCliente consumeCliente = new ConsumeCliente();
            IList<Cliente> micliente = consumeCliente.GetCliente(8, "", "", "", "", "", "", "", "", "", "", "", "", "financiera06", "gFPdxhPi");
            //Lista el Obejto Model propiedades de Cliente
            int registros = micliente.Count;
            if (registros > 0)
            {
                foreach (Cliente item in micliente)
                {
                    Console.WriteLine("id = " + item.id);
                    Console.WriteLine("nombre = " + item.nombre);
                    Console.WriteLine("aPaterno = " + item.aPaterno);
                    Console.WriteLine("aMaterno = " + item.aMaterno);
                    Console.WriteLine("rfc = " + item.rfc);
                    Console.WriteLine("fechaRegistro = " + item.fechaRegistro);
                    Console.WriteLine("pan = " + item.pan);
                    Console.WriteLine("nombreCompleto" + item.nombreCompleto);
                    Console.WriteLine("importeCredito" + item.importeCredito);
                    Console.WriteLine("idSucursal 0 " + item.idSucursal);
                    Console.WriteLine("sucursal = " + item.sucursal);
                    Console.WriteLine("idEmpresa = " + item.idEmpresa);
                    Console.WriteLine("empresa = " + item.empresa);
                    Console.WriteLine("estatus = " + item.estatus);
                    Console.WriteLine("idSeguro = " + item.idSeguro);
                    Console.WriteLine("nombreSeguro = " + item.nombreSeguro);
                    Console.WriteLine("idProductoFinanciero" + item.idProductoFinanciero);
                    Console.WriteLine("nombreProductoFinanciero = " + item.nombreProductoFinanciero);
                    Console.WriteLine("indObligado = " + item.indObligado);
                }
            }
            else
            {
                Console.WriteLine("La consulta no devolvió registros con los parametros enviados" );
            }*/
            // Prueba consumo Cliente
            ConsumeTxCliente consumetxclienteRes = new ConsumeTxCliente();
            IList<TxClienteResponse> miDatosCredito = consumetxclienteRes.GetTxCliente(8, 0, 1, "financiera06", "gFPdxhPi");
            //Lista el Obejto Model propiedades de Cliente
            int registros = miDatosCredito.Count;
            if (registros > 0)
            {
                foreach (TxClienteResponse item in miDatosCredito)
                {
                    Console.WriteLine("id = " + item.id);
                    Console.WriteLine("nombre = " + item.idCliente);
                    Console.WriteLine("nombre = " + item.idTransaccion);
                    Console.WriteLine("nombre = " + item.pan);
                    Console.WriteLine("nombre = " + item.noCredito);
                    Console.WriteLine("nombre = " + item.producto);
                }
            }
            else
            {
                Console.WriteLine("La consulta no devolvió registros con los parametros enviados.");
            }
        }
    }
}
