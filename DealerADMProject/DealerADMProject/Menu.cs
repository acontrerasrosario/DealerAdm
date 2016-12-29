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

        
        //Hover Events
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


        private void btnDealer_Hover(object sender, EventArgs e)
        {
            TxtFactura.Visible = true;
            TxtFactura.Text = "Sistema de administracion y consulta de vehiculos para venta";
        }

        //Click Events
        private void btnFactura_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            
            Cotizacion c = new Cotizacion();
            c.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            
            MantenimientoVehiculos v = new MantenimientoVehiculos();
            v.ShowDialog();
        }

        
    }
}
