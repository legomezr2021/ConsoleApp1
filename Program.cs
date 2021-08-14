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

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prueba consumo Cliente
            ConsumeCliente consumeCliente = new ConsumeCliente();
            string jsonIn = consumeCliente.GetCliente(8, "", "", "", "", "", "", "", "", "", "", "", "", "financiera06", "gFPdxhPi");
            Console.WriteLine(jsonIn);
        }
    }
}
