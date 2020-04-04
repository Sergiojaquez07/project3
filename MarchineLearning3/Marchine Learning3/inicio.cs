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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Close();
            Login login = new Login();
            login.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Close();
            Registro registro = new Registro();
            registro.Show();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
