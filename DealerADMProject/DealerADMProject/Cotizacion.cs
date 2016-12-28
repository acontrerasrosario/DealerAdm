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

        private DataTable dt = new DataTable();
        public Cotizacion()
        {
            
            InitializeComponent();
            fillComboBox();
        }

        public void fillComboBox()
        {
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIAS", conString);

                using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    cmd.ExecuteNonQuery();
                }
                
                
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxMarca.Items.Add(dt.Rows[i]["Nombre"]);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
