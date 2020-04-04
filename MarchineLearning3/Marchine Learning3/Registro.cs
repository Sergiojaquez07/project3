using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marchine_Learning3
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aqui
            
            Usuario Usuario = new Usuario();
            Usuario.Id = int.Parse( this.txtId.Text);
            Usuario.Nombre = txtNombre.Text;
            Usuario.Correo = txtCorreo.Text;
            Usuario.Contraseña = txtContraseña.Text;

                 int resultado =   UsuarioDal.Agregar(Usuario);

            if(resultado > 0)
            {
                MessageBox.Show("Registro Correctamente", "Datos Guardados ",MessageBoxButtons.OK, MessageBoxIcon.Information);

                 this.Hide();
             
                 
            }
            else
            {
                MessageBox.Show("Registro No guardado", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            txtContraseña.Clear();
            txtCorreo.Clear();
            txtId.Clear();
            txtNombre.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtId.Text = ""; 
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
