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
    public partial class imagen2 : Form
    
    {
        imagenes img = new imagenes();
        public imagen2()
        {
            InitializeComponent();
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
        {
           MessageBox.Show(img.insertarImagen(txtDescripcion.Text, pictureBox1));
            cbListaFotos.Items.Clear();
            img.cargarImagenes(cbListaFotos);
            txtDescripcion.Clear();
           
        }

        private void imagen2_Load(object sender, EventArgs e)
        {
            img.abrirConexion();
            img.cargarImagenes(cbListaFotos);
            cbListaFotos.SelectedIndex = 0; 

        }

        private void cbListaFotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            img.verImagen(pictureBox1, cbListaFotos.SelectedItem.ToString());
        }
    }
   
}
