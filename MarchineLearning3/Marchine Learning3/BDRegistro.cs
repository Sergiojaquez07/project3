using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Marchine_Learning3
{
    public class BDRegistro
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S2UC465\\SQLEXPRESS;Initial Catalog=guardar;Integrated Security=True");
            conn.Open();

            return conn;
            //pero esa fue la que puse
        }
    }
}
