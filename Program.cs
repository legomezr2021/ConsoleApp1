using System;
using System.Security.Cryptography;
using RestSharp;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Dynamic;
using ConsoleApp1.Controller;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prueba consumo Cliente
            ConsumeCliente consumeCliente = new ConsumeCliente();
            IList<Cliente> micliente = consumeCliente.GetCliente(8, "", "", "", "", "", "", "", "", "", "", "", "", "financiera06", "gFPdxhPi");
            //Lista el Obejto Model propiedades de Cliente
            foreach (Cliente item in micliente)
            {
                Console.WriteLine("id = " +item.id);
                Console.WriteLine("nombre = " +item.nombre);
                Console.WriteLine("aPaterno = " + item.aPaterno);
                Console.WriteLine("aMaterno = " + item.aMaterno);
                Console.WriteLine("rfc = " +item.rfc);
                Console.WriteLine("fechaRegistro = " + item.fechaRegistro);
                Console.WriteLine(item.pan);
                Console.WriteLine(item.nombreCompleto);
                Console.WriteLine(item.importeCredito);
                Console.WriteLine(item.idSucursal);
                Console.WriteLine(item.sucursal);
                Console.WriteLine(item.idEmpresa);
                Console.WriteLine(item.empresa);
                Console.WriteLine(item.estatus);
                Console.WriteLine(item.idSeguro);
                Console.WriteLine(item.nombreSeguro);
                Console.WriteLine(item.idProductoFinanciero);
                Console.WriteLine(item.nombreProductoFinanciero);
                Console.WriteLine(item.indObligado);
            }
        }
    }
}
