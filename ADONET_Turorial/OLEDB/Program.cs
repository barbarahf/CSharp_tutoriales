using System;
using System.Data.OleDb;

namespace OLEDB
{
    internal class Program
    {
        public static void Main(string[] args)
        {//Provider=SQLNCLI10;Server=localhost;Database=store; Trusted_Connection=yes;
            string connectionString = "Provider=SQLOLEDB;Server= localhost; Database= store; Integrated Security=True;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("ServerVersion: {0} \nDataSource: {1}",
                        connection.ServerVersion, connection.DataSource);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}