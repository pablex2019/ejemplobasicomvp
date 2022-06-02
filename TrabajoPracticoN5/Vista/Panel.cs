using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoN5.Interfaces;
using TrabajoPracticoN5.Modelo;

namespace TrabajoPracticoN5
{
    public partial class Panel : Form,IPanel
    {
        private Presentador.PanelPresentador _presentador;

        public Panel()
        {
            InitializeComponent();
            _presentador = new Presentador.PanelPresentador(this);
        }
        public void MostrarArticulos(Producto producto)
        {
            bindingSource1.DataSource = producto;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var producto = _presentador.BuscarProducto(txtCodigo.Text);
            txtDescripcion.Text = producto==null? "-":producto.Descripción;
        }
    }
}
