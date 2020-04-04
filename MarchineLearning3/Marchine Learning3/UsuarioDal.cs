using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Marchine_Learning3
{
   public class UsuarioDal
    {
        public static int Agregar(Usuario pUsuario)
        {
            int retorno = 0;
            using (SqlConnection conn = BDRegistro.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuario (Id, Nombre, Correo,Contraseña) values ('{0}', '{1}', '{2}', '{3}')",
                pUsuario.Id, pUsuario.Nombre, pUsuario.Correo, pUsuario.Contraseña), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
