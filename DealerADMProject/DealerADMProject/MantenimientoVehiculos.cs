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

    public partial class MantenimientoVehiculos : Form
    {
        public MantenimientoVehiculos()
        {
            InitializeComponent();
            
        }

        //Variables globales
        SQLCRUD Con = new SQLCRUD();
        string Query;
        bool WasSelected=false;
        bool WasClicked = false;
        


        //LLena todos los combo box cuando carga la ventana de vehiculos
        private void Vehiculos_Load(object sender, EventArgs e)
        {
            try
            {
                Query = "SELECT * FROM Marcas"; 
                cmbMarca.DataSource = Con.SELECT(Query);
                cmbMarca.DisplayMember = "Nombre";
                cmbMarca.ValueMember = "MarcaID";
                cmbMarca.Text = "";
                cmbMarca.Refresh();

            }
            catch
            {
                MessageBox.Show("Error al cargar informacion");
            }

            
            try
            {
                Query = "SELECT * FROM Categorias";
                cmbCategoria.DataSource = Con.SELECT(Query);
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.Text = "";
                cmbCategoria.Refresh();
            }
            catch
            {
                MessageBox.Show("Error al cargar informacion");
            }

           
            List<int> Puertas = new List<int> {2,3,4,5};
            cmbPuertas.DataSource = Puertas;
            cmbPuertas.Text = "";
            cmbPuertas.Refresh();

            List<int> Cilindros = new List<int> {3,4,5,6,8,12};
            cmbCilindros.DataSource = Cilindros;
            cmbCilindros.Text = "";
            cmbCilindros.Refresh();

        }

        //Comfirma que el valor del Combo box de Marca fue cambiado
        private void cmbMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            WasSelected = true;
        }
        //Confirma que el valor del Combo box de Modelos fue cambiado
        private void cmbMarca_Click(object sender, EventArgs e)
        {
            WasClicked = true;
        }

        //Llena el Combo Box de Modelos cada vez que cambia la Marca
        private void cmbModelos_Click(object sender, EventArgs e)
        {
            if (WasClicked == true && WasSelected == true)
            {
                try
                {
                    string Query = "SELECT * FROM Modelos  WHERE MarcaID =" + cmbMarca.SelectedValue;
                    cmbModelo.DataSource = Con.SELECT(Query);
                    cmbModelo.DisplayMember = "Nombre";
                    cmbModelo.ValueMember = "ModeloID";
                    cmbModelo.Text = "";
                    cmbModelo.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error al cargar informacion de modelos");
                }
            }
        }

        //Reinicia los campos para agregar un nuevos producto
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clean_Fields();
        }

        //*TODO Arreglar funcion 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
                     
            Query = @"INSERT INTO Vehiculos(Chasis,CategoriaID,MarcaID,ModeloID,Color,CantPuertas,CantCilindros,KmActual, PrecioAdquirido, Detalles,FechaRegistro,FechaAquisicion) 
                     Values ('" + tbxChasis.Text + "','" + cmbCategoria.SelectedValue + "','" + cmbMarca.SelectedValue + "','" + cmbModelo.SelectedValue + "','" + tbxColor.Text + "','" + cmbPuertas.SelectedValue + "','" + cmbCilindros.SelectedValue + "','" + tbxKm.Text + "','" + tbxPrecioAdq.Text + "','" + rtbxDetalles.Text + "','" + DateTime.Today.ToString("MM-dd-yyyy") + "','" + dtpAdqusicion.Value.ToString("MM-dd-yyyy") + "')";

            if (Con.INSERT(Query))
            {
                MessageBox.Show("La informacion del vehiculo ha sido almacenada correctamente");
                Clean_Fields();
            }
            else MessageBox.Show("Ha habido un error ");
        }
        //Eliminar un registro de la base de datos 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Con.DELETE("Vehiculos", "Chasis=" + this.tbxChasis.Text);
                MessageBox.Show("El cliente ha sido eliminado satisfactoriamente");
                Clean_Fields();
            }
            catch
            {
                MessageBox.Show("Error al eliminar usuario");
            }

        }

        // Limpia los valores del formulario de Vehiculos
        public void Clean_Fields()
        {
            this.tbxChasis.Text = this.tbxAño.Text = this.tbxColor.Text = this.tbxKm.Text = this.tbxPrecioAdq.Text =this.rtbxDetalles.Text= "";
            this.cmbMarca.SelectedValue = this.cmbModelo.SelectedValue = this.cmbCategoria.SelectedValue = 0;
        }



        //TAB VEHICULOS REGISTRADOS [Imcompleto
        private void tbxCampo_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string Query;
            if (rbChasis.Checked == true)
            {
                Query = "SELECT * From Vehiculos WHERE Chasis=" + tbxCampo.Text;
                dgvVeh.DataSource = Con.SELECT(Query);
            }
            //else if (rbMarca.Checked == true)
            //{
            //    Query = "SELECT * From Vehiculos WHERE =" + "'" + tbxCampo.Text + "'";
            //    dgvVeh.DataSource = Con.SELECT(Query);
            //}
            //else if (rbModelo.Checked == true)
            //{
            //    Query = "SELECT * From Vehiculos WHERE =" + "'" + tbxCampo.Text + "'";
            //    dgvVeh.DataSource = Con.SELECT(Query);
            //}
            else
            {
                MessageBox.Show("Porfavor, seleccione un campo");
            }

        }


    }
}
