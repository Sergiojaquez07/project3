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
    public partial class FormLink1 : Form
    {
        string Nombre, Apellido, Ultima, Fecha, Hora;
        int Edad;
        //instanciar la clase datos
        Datos obj = new Datos();

        public FormLink1()
        {
            InitializeComponent();
        }

        

           //Metodo Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = (txtNombre.Text);
                Apellido = (txtApellido.Text);
                Ultima = (txtultima.Text);
                Edad = int.Parse(txtEdad.Text);
                Fecha = (dtmFecha.Text);
                Hora = (txtHora.Text);
               

                obj.Actualizar(Nombre, Apellido, Ultima, Edad, Fecha, Hora);

                MessageBox.Show("Datos de laa Persona Actualizados...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            llenarGrip();
            
        }

        // borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = (txtNombre.Text);

                obj.Borrar(Nombre);

                MessageBox.Show("Datos de la Persona Eliminados Exitosamente...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
           llenarGrip();
            
        }

        private void FormLink1_Load(object sender, EventArgs e)
        {
            llenarGrip();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Nombre = txtbuscar.Text;

            dataGridView1.DataSource = obj.Buscar(Nombre);
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtbuscar.Clear();
            txtEdad.Clear();
            txtHora.Clear();
            txtNombre.Clear();
            txtultima.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = (txtNombre.Text);
                Apellido = (txtApellido.Text);
                Ultima = (txtultima.Text);
                Edad = int.Parse(txtEdad.Text);
                Fecha = (dtmFecha.Text);
                Hora = (txtHora.Text);
               

                obj.Guardar(Nombre, Apellido, Ultima, Edad, Fecha, Hora);

                MessageBox.Show("Datos de la Persona Guardado Exitosamente...");
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

           llenarGrip();
 
        }
        public void llenarGrip()
        {
            dataGridView1.DataSource = obj.LlenarGrid();
        }
              
    }
}

