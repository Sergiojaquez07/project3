using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marchine_Learning3
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public Usuario () { }

        public Usuario(int pId, string pNombre, string pCorreo, string pContraseña)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Correo = pCorreo;
            this.Contraseña = pContraseña;
        }
    }
}
