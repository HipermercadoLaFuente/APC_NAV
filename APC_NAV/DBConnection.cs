using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace APC_NAV
{
    class DBConnection
    {

        private static SqlConnection getConnect()
        {
            //SqlConnection connex = new SqlConnection("Data Source=192.168.5.59; Initial Catalog=LAFUENTE_PRE_15;User ID=sa;Password=Volumen1");
            SqlConnection connex = new SqlConnection("Data Source=192.168.5.54; Initial Catalog=LAFUENTE_NAV_LSR63;User ID=sa;Password=HlfSq1@2017");
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
}
