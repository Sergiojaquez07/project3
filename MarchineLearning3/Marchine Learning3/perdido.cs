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
    public partial class perdido : Form
    {
        public perdido()
        {
            InitializeComponent();
        }

        private void perdido_Load(object sender, EventArgs e)
        {
          
            this.desapareciTableAdapter.Fill(this.guardarDataSet2.Desapareci);
           

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
        
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
