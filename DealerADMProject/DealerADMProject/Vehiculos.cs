using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerADMProject
{
    // Formulario para registrar Vehiculos en la base de datos

    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
            Display_Grid();
        }
             
        /*TODO Arreglar funcion 
               Agregar campos que faltan al Insert
        */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                
                string Query = @"INSERT INTO Vehiculos(Color,KmActual, PrecioAdquirido, Detalles,FechaRegistro,FechaAquisicion) 
                                Values ('" + textColor.Text + "','" + textKm.Text + "','" + textPrecioAdq.Text + "','" + richtextDetalles.Text + "','" + DateTime.Today.ToString("MM-dd-yyyy") + "','" + dateTimeAdq.Value.ToString("MM-dd-yyyy") + "')";

                SqlCommand cmd = new SqlCommand(Query, conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            Display_Grid();
        }
        
        //Muestra el Grid con los Vehiculos almacenados en la base de datos
        public void Display_Grid()
        {
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                SqlCommand cmd = new SqlCommand
                    ("SELECT * FROM vehiculos", conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.ExecuteNonQuery();
                    da.Fill(dt);
                    dataGridViewVeh.DataSource = dt;
                    dataGridViewVeh.ReadOnly = true;
                }


            }
        }

        public void fillComboBox()
        {
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIAS", conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    cmd.ExecuteNonQuery();
                }


            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCategoria.Items.Add(dt.Rows[i]["Nombre"]);
            }



        }
    }
}
