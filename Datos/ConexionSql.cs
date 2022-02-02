using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class ConexionSql

    {
        static string conexionstring = "server= localhost; database= logins; " +
            "integrated security= true";

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);


        public int consultalogin(string Usuario, string contrasena)
        {

            int count;
            con.Open();
            string Query = "Select Count(*) From persona where usuario = '" + Usuario + "' " +
                " and contrasena = '" + contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;


        }


    }

}
