using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsApp.Entidades
{
    public class Vendedor:Persona
    {
        public string DNI { get; set; }
        public Vendedor(string dni, string nombre, string apellido, string email, string telefono, string direccion)
            :base(nombre, apellido, email,telefono,direccion)
        {
            DNI = dni;
        }
    }
}
