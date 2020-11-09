using System;
using System.Data.OleDb;

namespace OLEDB
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           
            string connectionString = "Provider=SQLOLEDB;Server=localhost;Database=store; Trusted_Connection=yes;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conected");
                    Console.WriteLine("ServerVersion: {0} \nDataSource: {1}",
                        connection.ServerVersion, connection.DataSource);
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