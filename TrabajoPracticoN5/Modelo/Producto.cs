using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoN5.Modelo
{
    public class Producto
    {
        public int Código { get; set; }
        public string Descripción { get; set;}
        public double Csi { get; set; }
        public double Pi { get; set; }
        public double Cci { get; set; }
        public double Mg { get; set; }
        public double Pf { get; set; }
        public Estado Estado { get; set; }
    }
}
