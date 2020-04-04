using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marchine_Learning3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            TxtContraseña.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S2UC465\\SQLEXPRESS;Initial Catalog=guardar;Integrated Security=True"); 
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Usuario where Nombre='" + txtNombre.Text + "' and Contraseña = '" + TxtContraseña.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            

            if (txtNombre.Text == "admin" && TxtContraseña.Text == "123")
            {
                this.Hide();
                administrador aministarda = new administrador();
                aministarda.Show();
            }
            
            else if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                formulario formu = new formulario();
                formu.Show();

            }
            else
            {
                MessageBox.Show("por favor revisar los datos");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
