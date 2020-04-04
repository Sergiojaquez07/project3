using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Marchine_Learning3
{
    class Datos
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S2UC465\\SQLEXPRESS;Initial Catalog=guardar;Integrated Security=True");
        SqlCommand comando;

        //metodo
        public void Guardar(string nom, string apelli, string ultima, int edad, string fecha, string Hora)
        {
            conn.Open();
            string lineaComando = $"insert into Desapareci values('{nom}','{apelli}' ,'{ultima}' ,{edad} ,'{fecha}','{Hora}' )";
            comando = new SqlCommand(lineaComando,conn);
            comando.ExecuteNonQuery();
            conn.Close();  
        }
        public void Actualizar(string nom, string apelli, string ultima, int edad, string fecha,  string Hora)  
        {
            conn.Open();
            string lineaComando = $"update Desapareci set Apellido='{apelli}', Ultima='{ultima}', edad={edad}, fecha='{fecha}', Hora='{Hora}' where Nombre= '{nom}'";
            comando = new SqlCommand(lineaComando, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public void Borrar(string nom)
        {
            conn.Open();
            string lineaComando = $"delete from Desapareci where Nombre = '{nom}'";
            comando = new SqlCommand(lineaComando, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        
        public DataTable LlenarGrid()
        {
            conn.Open();
            string lineaComando = "select * from Desapareci";
            comando = new SqlCommand(lineaComando, conn);

            comando.ExecuteNonQuery();
            //adaptamos los datos es decir mostrarlo en el lugar que quiero jajjjajaj
            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            conn.Close();

            return table;

        }
        public DataTable Buscar(string nom)
        {
            conn.Open();
            string lineaComando = $"select * from Desapareci where Nombre = '{nom}'";
            comando = new SqlCommand(lineaComando, conn);

            comando.ExecuteNonQuery();
            //adaptamos los datos es decir mostrarlo en el lugar que quiero jajjjajaj
            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            conn.Close();

            return table;

        }

    }
}
