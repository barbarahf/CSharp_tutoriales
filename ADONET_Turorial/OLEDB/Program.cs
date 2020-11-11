using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text.Json;

namespace OLEDB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Factura> facturas = new List<Factura>();
            //Array de facturas
            string connectionString = "Provider=SQLOLEDB;Server=localhost;Database=Compras; Trusted_Connection=yes;";
            /*
             * Obtener un listado de las facturas realizadas indicando numero de factura, nombre del cliente, nombre
             * del producto, cantidad y precio
             */
            string consulta01 =
                "SELECT numFactura,nombre,nombreprod,cantidad,cantidad*precio FROM ((producto JOIN item_ventas on codiprod=codigoProducto) JOIN ventas ON numFactura=numeroFactura JOIN cliente ON codigo=codigoCliente);";

            CrearObjeto(connectionString, consulta01, facturas);
            // foreach (var eFactura in facturas)
            // {
            //     Console.WriteLine(eFactura.ToString());
            // }

            // Serializar objeto a Json
            // var example = new Factura(888, "Isabel", "Mesa de escritorio", 88, 1111);
            // string jsonString;
            // jsonString = JsonSerializer.Serialize();

            // //Sincrono
            // File.WriteAllText(@"C:\Users\herre\OneDrive\Documentos\dotnet\ADONET_Turorial\OLEDB\jsonFactura.json",
            //     jsonString);
        }


        private static void CrearObjeto(string connectionString, string insertSql, List<Factura> facturas)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(insertSql);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();


                    while (reader.Read()) //cada columnna
                    {
                        int numFactura = (int) reader[0];
                        String nombre = reader[1].ToString();
                        string nombreProducto = reader[2].ToString();
                        int cantidad = (int) reader[3];
                        String cantidadTotal = reader[4].ToString();
                        facturas.Add(new Factura(numFactura, nombre, nombreProducto, cantidad,
                            Int16.Parse(cantidadTotal)));
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Consulta(string connectionString, string insertSql) //Solo para mostrar
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(insertSql);

                command.Connection = connection;

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();


                    while (reader.Read()) //cada columnna
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i] + " ");
                        }

                        Console.WriteLine();
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}