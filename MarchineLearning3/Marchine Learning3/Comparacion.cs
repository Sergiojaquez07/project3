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
    public partial class Comparacion : Form
    {
        public Comparacion()
        {
            InitializeComponent();
        }

        private void Comparacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guardarDataSet3.imagenes' Puede moverla o quitarla según sea necesario.
            this.imagenesTableAdapter.Fill(this.guardarDataSet3.imagenes);

        }
    }
}
