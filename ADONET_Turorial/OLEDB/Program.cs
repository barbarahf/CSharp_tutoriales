using System;
using System.Data.OleDb;

namespace OLEDB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Provider=SQLOLEDB;Server=localhost;Database=Compras; Trusted_Connection=yes;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string consultas =
                    "SELECT numFactura,nombre,nombreprod,cantidad,cantidad*precio FROM ((producto JOIN item_ventas on codiprod=codigoProducto) JOIN ventas ON numFactura=numeroFactura JOIN cliente ON codigo=codigoCliente);";

                try
                {
                    OleDbCommand command = new OleDbCommand(consultas, connection);

                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i].ToString() + " ");
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
// Console.WriteLine("Conected");
// Console.WriteLine("ServerVersion: {0} \nDataSource: {1}", connection.ServerVersion,
//     connection.DataSource);