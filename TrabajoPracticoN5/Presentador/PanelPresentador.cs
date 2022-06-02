using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoN5.Interfaces;

namespace TrabajoPracticoN5.Presentador
{
    public class PanelPresentador
    {
        private IPanel _panel;
        private Datos.Stock _stock;

        public PanelPresentador(IPanel panel)
        {
            _panel = panel;
            _stock = new Datos.Stock();
        }
        public Modelo.Producto BuscarProducto(string codigo)
        {
            return Datos.Stock.BuscarP(Convert.ToInt32(codigo));            
        }
    }
}
