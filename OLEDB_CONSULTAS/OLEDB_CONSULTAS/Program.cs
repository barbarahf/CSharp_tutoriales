using System;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace OLEDB_CONSULTAS
{
    class Program
    {//Data Source=localhost;Initial Catalog=store;Integrated Security=True;
        //Proveedor de datos .NET Framework para servidor SQL Server
        //DESKTOP-SJNQGEP\herre
        static void Main(string[] args)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["AspnetdbconnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "SELECT * FROM ...";
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            // do stuff
                        }
                    }
                }
            }
        }
        //private static void ReadData(string connectionString)
        //{
        //    string queryString = "SELECT OrderID, CustomerID FROM Orders";
        //    using (OracleConnection connection = new OracleConnection(connectionString))
        //    {
        //        OracleCommand command = new OracleCommand(queryString, connection);
        //        connection.Open();
        //        OracleDataReader reader;
        //        reader = command.ExecuteReader();

        //        // Always call Read before accessing data.
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(reader.GetInt32(0) + ", " + reader.GetString(1));
        //        }

        //        // Always call Close when done reading.
        //        reader.Close();
        //    }
        //}
    }
    
}
