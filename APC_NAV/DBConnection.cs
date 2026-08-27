using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using System;
using System.Data;
using System.Data.SqlClient;

namespace APC_NAV
{
    class DBConnection
    {
        // Nombre de la variable de entorno
        private const string ENV_CONNECTION = "APC_CONNECTION_STRING";

        // Se lee una sola vez al iniciar la aplicación
        private static readonly string connectionString =
            Environment.GetEnvironmentVariable(
                ENV_CONNECTION,
                EnvironmentVariableTarget.Machine);

        /// <summary>
        /// Obtiene una conexión abierta a SQL Server.
        /// </summary>
        /// <returns>SqlConnection</returns>
        private static SqlConnection getConnect()
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception(
                    "No se encontró la variable de entorno '" +
                    ENV_CONNECTION +
                    "'.");
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        /// <summary>
        /// Ejecuta un SELECT y retorna un DataTable.
        /// </summary>
        public static DataTable queryTable(string query)
        {
            using (SqlConnection connection = getConnect())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// Ejecuta INSERT, UPDATE o DELETE.
        /// </summary>
        public static void executeOnTable(string query)
        {
            using (SqlConnection connection = getConnect())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Verifica si la conexión es válida.
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = getConnect())
                {
                    return connection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
/*
namespace APC_NAV
{
    class DBConnection
    {

        private static SqlConnection getConnect()
        {

          
            SqlConnection connex = new SqlConnection("Data Source=192.168.1.55; Initial Catalog=mydatabase;User ID=sa;Password=123456789");
            connex.Open();
            return connex;
        }


        public static DataTable queryTable(String query)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, getConnect());
            SqlDataAdapter adap = new SqlDataAdapter(command);
            adap.Fill(dt);
            command.Connection.Close();
            return dt;
        }


        public static void executeOnTable(String query)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, getConnect());
            command.ExecuteNonQuery();
            command.Connection.Close();
        }



    }
}*/
