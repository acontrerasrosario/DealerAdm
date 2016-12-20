using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DealerADMProject
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            fillComboBox();
            InitializeComponent();
        }

        public void fillComboBox()
        {

            try
            {
                SqlConnection conn = new SqlConnection(DatabaseConnection.conndb);
                string marcaQuery = "SELECT Nombre FROM Categorias";
                SqlCommand sc = new SqlCommand(marcaQuery, conn);
                conn.Open();
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Marcas", typeof(string));
                dt.Load(reader);

                
                comboBoxMarca.DisplayMember = "Marca";
                comboBoxMarca.DataSource = dt;

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Ocurred Filling Comobox");
            }
           

        
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAnoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAcuerdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
