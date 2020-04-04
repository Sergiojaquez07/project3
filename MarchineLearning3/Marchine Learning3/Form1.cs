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
    public partial class Form1 : Form
    {
        //Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        public void AbrirformInPanel(object From_hijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            Form fh = From_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new Form2());
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
        }
    }
}
