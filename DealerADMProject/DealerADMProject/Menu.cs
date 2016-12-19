using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerADMProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //private void TxtFactura_Load(object sender , EventArgs e)
        //{
        //    this.Show();
        //}

        private void btnFactura_Hover(object sender , EventArgs e)
        {
            TxtFactura.Visible = true;
            TxtFactura.Text = "Facturacion de vehiculos para venta";
        }

        private void btnCotizacion_Hover(object sender, EventArgs e)
        {
            TxtFactura.Visible = true;
            TxtFactura.Text = "Cotizacion de valor de venta del vehiculo";
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            Hide();
            Cotizacion c = new Cotizacion();
            c.Show();
        }

        private void btnDealer_Hover(object sender, EventArgs e)
        {
            TxtFactura.Visible = true;
            TxtFactura.Text = "Sistema de administracion y consulta de vehiculos para venta";
        }
    }
}
