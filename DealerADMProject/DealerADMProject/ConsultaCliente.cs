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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();

                string Query = @"INSERT INTO Clientes(Cedula, Nombre, Apellido, Email, Telefono, Provincia, Calle, Direccion, Comentario) 
                                Values ('" + tbxCedula.Text + "','" + tbxNombre.Text + "','" + tbxApellido.Text + "','" + tbxEmail.Text + "','" + mtbxTelfono.Text + "','" + tbxProvincia.Text + "','" + tbxCalle.Text + "','" + tbxDireccion.Text + "','" + rtbComentario.Text + "')";

                SqlCommand cmd = new SqlCommand(Query, conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
