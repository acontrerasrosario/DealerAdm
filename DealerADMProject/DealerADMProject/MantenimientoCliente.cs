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
    public partial class MantenimientoCliente : Form
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        //Variables Globales
        SQLCRUD Con = new SQLCRUD();

        //Prepara el formulario para ingresar un nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clean_Fields();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Query = @"INSERT INTO Clientes(Cedula, Nombre, Apellido, Email, Telefono, Provincia, Calle, Direccion, Comentario) 
                        Values ('" + tbxCedula.Text + "','" + tbxNombre.Text + "','" + tbxApellido.Text + "','" + tbxEmail.Text + "','" + mtbxTelfono.Text + "','" + tbxProvincia.Text + "','" + tbxCalle.Text + "','" + tbxDireccion.Text + "','" + rtbComentario.Text + "')";
            if (Con.INSERT(Query))
            {
                MessageBox.Show("Cliente registrado correctamente");
                Clean_Fields();
            }
            else
            {
                MessageBox.Show("Error No se pudo alcemanar el usuario");
            }
        }

        //Elimina un registro con la cedula
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            String Condicion = this.tbxCedula.Text;
            try 
            {
                Con.DELETE("Clientes","Cedula="+ this.tbxCedula.Text);
                MessageBox.Show("El cliente ha sido eliminado satisfactoriamente");
                Clean_Fields();
            }
            catch
            {
                MessageBox.Show("Error al eliminar usuario");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion para Limpiar los valores del formulario Cliente
        public void Clean_Fields()
        {
            this.tbxCedula.Text = this.tbxNombre.Text = this.tbxApellido.Text = this.tbxEmail.Text = this.tbxProvincia.Text =
                this.tbxCalle.Text = this.tbxDireccion.Text = this.rtbComentario.Text = this.mtbxTelfono.Text = "";
        }



        //TAB CLIENTES REGISTRADOS
        private void tbxCampo_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string Query;
            if (rbCedula.Checked == true)
            {
                Query = "SELECT * From Clientes WHERE Cedula=" + tbxCampo.Text;
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbApellido.Checked == true)
            {
                Query = "SELECT * From Clientes WHERE Apellido="+"'"+ tbxCampo.Text+"'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbDireccion.Checked==true)
            {
                Query = "SELECT * From Clientes WHERE Direccion=" + "'" + tbxCampo.Text + "'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbEmail.Checked==true)
            {
                Query = "SELECT * From Clientes WHERE Email =" + "'" + tbxCampo.Text + "'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un campo");
            }
            
        }
    }
}
