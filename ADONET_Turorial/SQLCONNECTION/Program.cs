using System;
using System.Data.SqlClient;
using System.Text;

namespace SQLCONNECTION
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");


            string connString = "Server= localhost; Database= store; Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                connection.Open();

                Console.WriteLine("Connection successful!");

                //Query StringBuilder
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("INSERT INTO fabricante (codigo, nombre) VALUES ");
                strBuilder.Append("(N'10', N'Apple computer')");


                string sqlQuery = strBuilder.ToString();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection)) //Coneecion y query
                {
                    command.ExecuteNonQuery(); //ejecutar la consulta
                    Console.WriteLine("Query Executed.");
                }

                strBuilder.Clear(); // clear 
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}