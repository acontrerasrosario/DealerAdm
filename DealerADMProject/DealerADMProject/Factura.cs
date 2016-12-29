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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ConsultaCliente C = new ConsultaCliente();
            C.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
