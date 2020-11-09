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


          
            try
            {
                string connString = "Server= localhost; Database= store; Integrated Security=True;";

                SqlConnection connection = new SqlConnection(connString);
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


                strBuilder.Clear();
                // clear 
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
            try
            {
                string ConString = "Server= localhost; Database= store; Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    // Creating SqlCommand objcet   
                    SqlCommand cm = new SqlCommand("select * from fabricante", connection);
                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["Codigo"] + ". " + sdr["Nombre"]);
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }

            Console.ReadKey();

            Console.Read();
        }
    }
}