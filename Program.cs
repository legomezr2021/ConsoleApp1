using System;
using System.Collections.Generic;
using ConsoleApp1.Controller;
using ConsoleApp1.Model;
using ConsoleApp1.Tools;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 15
                ;
            if (opcion == 1)
            {
                // Prueba consumo Cliente
                ConsumeCliente consumeCliente = new ConsumeCliente();
                IList<Cliente> micliente = consumeCliente.GetCliente("8", "", "", "", "", "", "", "", "", "", "", "", "", "financiera06", "gFPdxhPi");
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
                    Console.WriteLine("La consulta no devolvió registros con los parametros enviados");
                }
            }
            else if (opcion == 2)
            {
                // Prueba consumo Tx Cliente
                ConsumeTxCliente consumetxclienteRes = new ConsumeTxCliente();
                IList<TxClienteResponse> miDatosCredito = consumetxclienteRes.GetTxCliente(8, 0, 2, "financiera06", "gFPdxhPi");
                //Lista el Obejto Model propiedades de Cliente solo se muestra los primeros 6 en ejemplo
                int registrosTx = miDatosCredito.Count;
                if (registrosTx > 0)
                {
                    foreach (TxClienteResponse item in miDatosCredito)
                    {
                        Console.WriteLine("id = " + item.id);
                        Console.WriteLine("idCliente = " + item.idCliente);
                        Console.WriteLine("idCliente = " + item.idCliente);
                        Console.WriteLine("pan = " + item.pan);
                        Console.WriteLine("noCredito = " + item.noCredito);
                        Console.WriteLine("producto = " + item.producto);
                    }
                }
                else
                {
                    Console.WriteLine("La consulta no devolvió registros con los parametros enviados.");
                }
            }
            else if (opcion == 3)
            {
                ConsumeDatosCredito consumedatoscreditoRes = new ConsumeDatosCredito();
                DatosCreditoResponse datoscreditoRes = consumedatoscreditoRes.GetDataCredit(8, "financiera06", "gFPdxhPi");
                //recorreo las propiedades del obejto con los datos de credito del cliente solicitado:
                Console.WriteLine("montoCredito = " + datoscreditoRes.montoCredito);
                Console.WriteLine("montoUtilizado = " + datoscreditoRes.montoUtilizado);
                Console.WriteLine("montoDisponible = " + datoscreditoRes.montoDisponible);
                Console.WriteLine("montoVencido = " + datoscreditoRes.montoVencido);
            }
            else if (opcion == 4)
            {
                ConsumeDatosProducto consumedatosproductoRes = new ConsumeDatosProducto();
                DatosProductoResponse datosproductopesponseRes = consumedatosproductoRes.GetDataProduct(8, "financiera06", "gFPdxhPi");
                //recorreo las propiedades del obejto con los datos del producto de credito del cliente solicitado:
                Console.WriteLine("nombre = " + datosproductopesponseRes.nombre);
                Console.WriteLine("tipo = " + datosproductopesponseRes.tipo);
                Console.WriteLine("noTarjeta = " + datosproductopesponseRes.noTarjeta);
                Console.WriteLine("cat = " + datosproductopesponseRes.cat);
                Console.WriteLine("interesOrdinario = " + datosproductopesponseRes.interesOrdinario);
                Console.WriteLine("interesMoratorio = " + datosproductopesponseRes.interesMoratorio);
                Console.WriteLine("anualidad = " + datosproductopesponseRes.anualidad);
                Console.WriteLine("fechaCorte1 = " + datosproductopesponseRes.fechaCorte1);
                Console.WriteLine("fechaCorte2 = " + datosproductopesponseRes.fechaCorte2);
                Console.WriteLine("fechaLimitePago1 = " + datosproductopesponseRes.fechaLimitePago1);
                Console.WriteLine("fechaLimitePago2 = " + datosproductopesponseRes.fechaLimitePago2);
                Console.WriteLine("comisiones = " + datosproductopesponseRes.comisiones);
                Console.WriteLine("comisiones = " + datosproductopesponseRes.comisiones);
            }
            else if (opcion == 5)
            {
                ConsumeDatosGeneralesCliente consumedatosgeneralesclienteRes = new ConsumeDatosGeneralesCliente();
                DatosGeneralesClienteResponse datosgeneralesclienteresponseRes = consumedatosgeneralesclienteRes.GetGeneralDataClient(8, "financiera06", "gFPdxhPi");
                //recorro las propiedades del obejto con los datos generales del cliente solicitado:
                Console.WriteLine("nombre = " + datosgeneralesclienteresponseRes.nombre);
                Console.WriteLine("aPaterno = " + datosgeneralesclienteresponseRes.aPaterno);
                Console.WriteLine("aMaterno = " + datosgeneralesclienteresponseRes.aMaterno);
                Console.WriteLine("fechaNacimiento = " + datosgeneralesclienteresponseRes.fechaNacimiento);
                Console.WriteLine("curp = " + datosgeneralesclienteresponseRes.curp);
                Console.WriteLine("rfc = " + datosgeneralesclienteresponseRes.rfc);
                Console.WriteLine("tipoIdentificacion = " + datosgeneralesclienteresponseRes.tipoIdentificacion);
                Console.WriteLine("noIdentificacion = " + datosgeneralesclienteresponseRes.noIdentificacion);
                Console.WriteLine("nacionalidad = " + datosgeneralesclienteresponseRes.nacionalidad);
                Console.WriteLine("paisNacimiento = " + datosgeneralesclienteresponseRes.paisNacimiento);
                Console.WriteLine("entidadFederativaNacimiento = " + datosgeneralesclienteresponseRes.entidadFederativaNacimiento);
                Console.WriteLine("genero = " + datosgeneralesclienteresponseRes.genero);
                Console.WriteLine("edoCivil = " + datosgeneralesclienteresponseRes.edoCivil);
                Console.WriteLine("escolaridad = " + datosgeneralesclienteresponseRes.escolaridad);
                Console.WriteLine("ocupacion = " + datosgeneralesclienteresponseRes.ocupacion);
                Console.WriteLine("scoreBuro = " + datosgeneralesclienteresponseRes.scoreBuro);
            }
            else if (opcion == 6)
            {
                ConsumeDatosDomicilioCliente consumeDatosDomicilioClienteRes = new ConsumeDatosDomicilioCliente();
                DatosDomicilioClienteResponse datosDomicilioClienteResponseRes = consumeDatosDomicilioClienteRes.GetDataAddressClient(8, "financiera06", "gFPdxhPi");
                //recorro las propiedades del obejto con los datos generales del cliente solicitado:
                Console.WriteLine("calle = " + datosDomicilioClienteResponseRes.calle);
                Console.WriteLine("noExterior = " + datosDomicilioClienteResponseRes.noExterior);
                Console.WriteLine("noInterior = " + datosDomicilioClienteResponseRes.noInterior);
                Console.WriteLine("cp = " + datosDomicilioClienteResponseRes.cp);
                Console.WriteLine("colonia = " + datosDomicilioClienteResponseRes.colonia);
                Console.WriteLine("municipio = " + datosDomicilioClienteResponseRes.municipio);
                Console.WriteLine("ciudadPoblacion = " + datosDomicilioClienteResponseRes.ciudadPoblacion);
                Console.WriteLine("entidadFederativa = " + datosDomicilioClienteResponseRes.entidadFederativa);
                Console.WriteLine("pais = " + datosDomicilioClienteResponseRes.pais);
                Console.WriteLine("tipoVivienda = " + datosDomicilioClienteResponseRes.tipoVivienda);
                Console.WriteLine("tiempoResidencia = " + datosDomicilioClienteResponseRes.tiempoResidencia);
            }
            else if (opcion == 7)
            {
                ConsumeContactoCliente consumeContactoClienteRes = new ConsumeContactoCliente();
                DatosContactoClienteResponse datosContactoClienteResponseres = consumeContactoClienteRes.GetContactClient(8, "financiera06", "gFPdxhPi");
                //recorro las propiedades del obejto con los datos generales del cliente solicitado:
                Console.WriteLine("telefonoFijo = " + datosContactoClienteResponseres.telefonoFijo);
                Console.WriteLine("telefonoFijo = " + datosContactoClienteResponseres.celular);
                Console.WriteLine("telefonoFijo = " + datosContactoClienteResponseres.correo);
            }
            else if (opcion == 8)
            {
                // Prueba consumo referencias
                ConsumeReferenciaCliente consumeReferenciaCliente = new ConsumeReferenciaCliente();
                IList<DatosReferenciaClienteResponse> datosReferenciaClienteResponsesList = consumeReferenciaCliente.GetReferenceClient(8, "financiera06", "gFPdxhPi");
                //Lista el Obejto Model propiedades de Cliente
                foreach (DatosReferenciaClienteResponse item in datosReferenciaClienteResponsesList)
                {
                    Console.WriteLine("nombre = " + item.nombre);
                    Console.WriteLine("aPaterno = " + item.aPaterno);
                    Console.WriteLine("aMaterno = " + item.aMaterno);
                    Console.WriteLine("telefono = " + item.telefono);
                    Console.WriteLine("numeroCelular = " + item.numeroCelular);
                    Console.WriteLine("email = " + item.email);
                    Console.WriteLine("parentesco = " + item.parentesco);
                    Console.WriteLine("referenciaTipo = " + item.referenciaTipo);
                }
            }
            else if (opcion == 9)
            {
                ConsumeConsultaDocumento consumeContactoClienteRes = new ConsumeConsultaDocumento();
                ConsultaDocumentosResponse consultaDocumentosResponseres = consumeContactoClienteRes.GetQueryDocument(8, 1, "financiera06", "gFPdxhPi");
                //recorro las propiedades del obejto se muetra la imagen en base64:
                Console.WriteLine("contenido = " + consultaDocumentosResponseres.contenido);
            }
            else if (opcion == 10)
            {
                // Prueba consumo sucursales
                ConsumeSucursal consumeSucursal = new ConsumeSucursal();
                IList<SucursalResponse> sucursalResponseList = consumeSucursal.GetSucursal(1, "financiera06", "gFPdxhPi");

                //Lista el Obejto Model propiedades de Cliente
                foreach (SucursalResponse item in sucursalResponseList)
                {
                    Console.WriteLine("Nombre = " + item.nombre);
                    Console.WriteLine("idEmpresa = " + item.idEmpresa);
                    Console.WriteLine("idSucursalPlaza = " + item.idSucursalPlaza);
                }
            }
            else if (opcion == 11)
            {
                // Prueba consumo empresas
                ConsumeEmpresa consumjeEmpresa = new ConsumeEmpresa();
                IList<EmpresaResponse> empresaResponseList = consumjeEmpresa.GetEmpresa(1, "financiera06", "gFPdxhPi");

                //Lista el Obejto Model propiedades de Cliente
                foreach (EmpresaResponse item in empresaResponseList)
                {
                    Console.WriteLine("id = " + item.id);
                    Console.WriteLine("Nombre = " + item.nombre);
                }
            }
            else if (opcion == 12)
            {
                ConvertDate covierte = new ConvertDate();
                string fechaNew;
                fechaNew = covierte.ConvertDateToMills("18/09/2021");
                Console.WriteLine("Fecha milisegundos: " + fechaNew);
            }
            else if (opcion == 13)
            {
                //Crea Instancia de Clase de conversion de fechas
                ConvertDate covierte = new ConvertDate();
                // Prueba consumo Cliente
                ConsumeCliente consumeCliente = new ConsumeCliente();
                IList<Cliente> micliente = consumeCliente.GetCliente("", covierte.ConvertDateToMills("01/01/2021"), covierte.ConvertDateToMills("18/09/2021"), "", "", "", "", "", "", "", "", "", "", "financiera06", "gFPdxhPi");
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
                    Console.WriteLine("La consulta no devolvió registros con los parametros enviados");
                }
            }
            else if (opcion == 14)
            {
                // Prueba consumo plaza
                ConsumePlaza consumePlaza = new ConsumePlaza();
                IList<PlazaResponse> plazaResponseList = consumePlaza.GetPlaza(1, "financiera06", "gFPdxhPi");

                //Lista el Obejto Model propiedades de plaza
                foreach (PlazaResponse item in plazaResponseList)
                {
                    Console.WriteLine("id = " + item.id);
                    Console.WriteLine("Nombre = " + item.plaza);
                }
            }
            else if (opcion == 15)
            {
                PlazoResponse plazoResponseRes = new PlazoResponse();
                ConsumePlazo consumePlazo = new ConsumePlazo();
                plazoResponseRes = consumePlazo.GetPlazo(2, "financiera06", "gFPdxhPi");
                //recorro las propiedades del objeto plazo:
                Console.WriteLine("Code = " + plazoResponseRes.code);
            }
        }
    }
}
