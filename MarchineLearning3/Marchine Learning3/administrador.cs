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
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 0)
            {
                panel1.Width = 177;
            }
            else
            {
                panel1.Width = 0;
            }
        }

        private void administrador_Load(object From_hijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            Form fh = From_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void administrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 0)
            {
                panel1.Width = 177;
            }
            else
            {
                panel1.Width = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            administrador_Load(new perdido());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            administrador_Load(new Comparacion());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            administrador_Load(new fotosdesaparecidos());
        }
    }
}
