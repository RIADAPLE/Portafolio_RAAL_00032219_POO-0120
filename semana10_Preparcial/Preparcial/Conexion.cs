using System.Data;
using System.Security.Cryptography.X509Certificates;
using Npgsql;

namespace Preparcial
{
    public static class Conexion
        {
            private static string sConection =
                "Server=127.0.0.1;Port=5432;User Id=postgres;Password=carro0707;Database=preParcial";

            public static DataTable realizarConsulta(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConection);
                DataSet ds = new DataSet();

                connection.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                da.Fill(ds);
            
                connection.Close();

                return ds.Tables[0];
            }

            public static void realizarAccion(string act)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConection);
                
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(act, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    
}