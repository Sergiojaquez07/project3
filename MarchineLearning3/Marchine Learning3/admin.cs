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
    public partial class admin : Form
    {
        public admin(string Nombre)
        {
            InitializeComponent();
            lbladmin.Text = Nombre;

        }
    }
}
