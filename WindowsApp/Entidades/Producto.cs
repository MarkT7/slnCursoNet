using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double Iva { get; set; }
        public decimal PrecioBruto { 
            get {
                return PrecioCosto + Convert.ToDecimal(Margen);
            }
        }
        public decimal PrecioVenta { 
            get {
                return PrecioBruto + Convert.ToDecimal(Iva);
            } 
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        


    }
}
