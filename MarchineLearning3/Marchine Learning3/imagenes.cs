using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marchine_Learning3
{
      class imagenes
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataRow dr;
        SqlDataReader sqldr;

        public string abrirConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-S2UC465\\SQLEXPRESS;Initial Catalog=guardar;Integrated Security=True");
                cn.Open();
                return "Conectado";
            }
            catch (Exception ex)
            {
                return "No conectado: " + ex.ToString();
            }
        }

        public string insertarImagen(string nombre, PictureBox pbImagen)
        {
            string mensaje = "Se inserto la imagen Correctamente";
            try
            {
                cmd = new SqlCommand("Insert into imagenes(nombre,imagenes) values(@nom,@imagen)", cn);
                cmd.Parameters.Add("@nom", SqlDbType.NChar);
                cmd.Parameters.Add("@imagen", SqlDbType.Image);

                cmd.Parameters["@nom"].Value = nombre;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@imagen"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la imagen: " + ex.ToString();
            }
            return mensaje;
        }
            
        public void verImagen(PictureBox pbFoto, string nombre)
        {
            try
            {
                da = new SqlDataAdapter("Select imagenes  from imagenes where nombre = '" + nombre + "'", cn);
                ds = new DataSet();
                da.Fill(ds, "imagenes"); 
                byte[] datos = new byte[0];
                dr = ds.Tables["imagenes"].Rows[0];
                datos = (byte[])dr["imagenes"]; 
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la Imagen: " + ex.ToString());
            }
        }

        public void cargarImagenes(ComboBox cbImg)
        {
            try
            {
                cmd = new SqlCommand("Select nombre from imagenes", cn);
                sqldr = cmd.ExecuteReader();
                while (sqldr.Read())
                {
                    cbImg.Items.Add(sqldr["nombre"]);
                }
                sqldr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargaron las imagenes en el ComboBox: " + ex.ToString());
            }
        }
    }
}
