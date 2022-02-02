using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConexionSqlN
    {
        ConexionSql cn = new ConexionSql ();


        public int conSQL(string user, string pass)
        {

            return cn.consultalogin(user, pass);   

        }



    }
}
