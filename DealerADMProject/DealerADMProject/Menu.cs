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

        
        //Click Events
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente Mc = new MantenimientoCliente();
            Mc.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoVehiculos v = new MantenimientoVehiculos();
            v.ShowDialog();
        }

        private void LiquidacuinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiquidacionImpuestos c = new LiquidacionImpuestos();
            c.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            f.Show();
        }
    }
}
