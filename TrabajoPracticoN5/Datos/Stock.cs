using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN5.Modelo;

namespace TrabajoPracticoN5.Datos
{
    public class Stock
    {
        private static List<Modelo.Producto> _productos = new List<Modelo.Producto>();

        public static void Iniciarlizar()
        {
            _productos.Add(new Modelo.Producto
            {
                Código = 1,
                Descripción = "Lapicera",
                Csi = 103,
                Pi = 21,
                Cci = 125,
                Mg = 42,
                Pf = 177.5,
                Estado = Estado.Activo
            });
        }
        public static Producto BuscarP(int codigo)
        {
            return _productos.FirstOrDefault(c => c.Código == codigo);
        }
        /*
        public List<Modelo.Producto> Listado()
        {
            List<Modelo.Producto> listado = new List<Modelo.Producto>();
            //Producto 1
            Modelo.Producto productoA = new Modelo.Producto();
            productoA.Código = 1;
            productoA.Descripción = "Lapicera";
            productoA.Csi = 125;
            productoA.Pi = 21;
            productoA.Cci = productoA.Csi + productoA.Csi * productoA.Pi;
            productoA.Mg = 42;
            productoA.Pf =((productoA.Mg* productoA.Cci)/100);
            productoA.Estado = Modelo.Estado.Activo;
            listado.Add(productoA);
            return listado;
        }
        */
    }
}
