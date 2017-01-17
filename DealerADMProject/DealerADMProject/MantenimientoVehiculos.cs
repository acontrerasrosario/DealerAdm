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
            btnMod.Hide();
        }

        //Variables globales
        SQLCRUD Con = new SQLCRUD();
        string Query;
        bool WasSelected=false;
        bool WasClicked= false;
        int IdVehiculo;
        int modelo=0;

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
            cmbModelo.Text="";
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
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
                     
            Query = @"INSERT INTO Vehiculos(Chasis,CategoriaID,MarcaID,ModeloID,Color,CantPuertas,CantCilindros,KmActual,PrecioAdquirido,PrecioVenta,Detalles,AñoRegistro,FechaAquisicion) 
                     Values (" +"'"+ tbxChasis.Text+"'"+ "," + cmbCategoria.SelectedValue + "," +  cmbMarca.SelectedValue  + "," + cmbModelo.SelectedValue + "," + "'" + cmbColor.Text + "'" + "," + cmbPuertas.SelectedValue + "," + cmbCilindros.SelectedValue + "," +  tbxKm.Text  + "," + tbxPrecioAdq.Text + "," + tbxPrecio.Text + "," + "'" + rtbxDetalles.Text + "'" + "," + cmbAños.Text + "," + "'" + dtpAdqusicion.Value.ToString("MM-dd-yyyy") +"'"+")";

            try
            {
                if (Con.INSERT(Query))
                {
                    MessageBox.Show("La informacion del vehiculo ha sido almacenada correctamente");
                    Clean_Fields();
                }
                else MessageBox.Show("La informacion no ha podido ser almacenada");
            }
            catch 
            {

                MessageBox.Show("Ha habido un error , revise los campos");
            }
        }
        //Eliminar un registro de la base de datos 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Con.DELETE("Vehiculos", "Chasis=" + "'"+this.tbxChasis.Text+"'");
                MessageBox.Show("El cliente ha sido eliminado satisfactoriamente");
                Clean_Fields();
            }
            catch
            {
                MessageBox.Show("Error al eliminar vehiculo");
            }

        }

        // Limpia los valores del formulario de Vehiculos
        public void Clean_Fields()
        {
            this.tbxChasis.Text = this.tbxKm.Text = this.tbxPrecioAdq.Text =this.rtbxDetalles.Text= "";
            this.cmbMarca.SelectedValue = this.cmbAños.SelectedValue = this.cmbColor.SelectedValue = this.cmbModelo.SelectedValue = this.cmbCategoria.SelectedValue = 0;
        }
  
        
        private void tbxCampo_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string Query;
            if (rbChasis.Checked == true)
            {
                
                Query = @"SELECT vh.ID,vh.MarcaID,vh.ModeloID,vh.CategoriaID,Chasis,mc.Nombre as Marca,md.Nombre as Modelo,ctg.Nombre as Categoria,Color,CantPuertas,CantCilindros,KmActual as KM,AñoRegistro as Año, vh.Detalles
                From Vehiculos vh 
                Join Marcas mc On (vh.MarcaID=mc.MarcaID) 
                Join Modelos md On (vh.ModeloID=md.ModeloID)
                Join Categorias ctg On (vh.CategoriaID=ctg.Id)
                WHERE Chasis LIKE '%" +tbxCampo.Text + "%'";
                dgvVeh.DataSource = Con.SELECT(Query);
                dgvVeh.Columns["ID"].Visible= dgvVeh.Columns["MarcaID"].Visible = dgvVeh.Columns["ModeloID"].Visible=dgvVeh.Columns["CategoriaID"].Visible=false;
                
            }
            else if (rbMarca.Checked == true)
            {
                
                Query = "SELECT * From Vehiculos ve join Marcas ma ON(ve.MarcaID=ma.MarcaID) WHERE ma.Nombre LIKE" + "'%" + tbxCampo.Text + "%'";
                dgvVeh.DataSource = Con.SELECT(Query);
            }
            else if (rbModelo.Checked == true)
            {
                
                Query = "SELECT * From Vehiculos ve join Modelos mo ON(ve.ModeloID=mo.ModeloID) WHERE mo.Nombre LIKE" + "'%" + tbxCampo.Text + "%'";
                dgvVeh.DataSource = Con.SELECT(Query);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un campo");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (WasSelected)
            {
                try
                {

                    Query = "UPDATE Vehiculos SET [Chasis]=" + "'" + tbxChasis.Text + "'" + ",[MarcaID]=" + "'" + cmbMarca.SelectedValue + "'" + ",[ModeloID]=" + "'" + cmbModelo.SelectedValue + "'"
                     + ",[Color]=" + "'" + cmbColor.Text + "'" + "WHERE [ID]=" + IdVehiculo;

                }
                catch
                {
                    MessageBox.Show("Error al cargar informacion de modelos");
                }
            }
            else
            {
                Query = "UPDATE Vehiculos SET [Chasis]=" + "'" + tbxChasis.Text + "'" + ",[MarcaID]=" + "'" + cmbMarca.SelectedValue + "'" + ",[ModeloID]=" + "'" + modelo + "'"
                     + ",[Color]=" + "'" + cmbColor.Text + "'" + "WHERE [ID]=" + IdVehiculo;
            }
    
            try
            {
                if (Con.UPDATE(Query))
                {
                    MessageBox.Show("Vehiculo Modificado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar vehiculo");
                }
            }
            catch 
            {

                MessageBox.Show("Error");
            }
        }
        //se mueve hacia la otra pestaña cuando se selecciona un dato del datagridview
        private void dgvVeh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tcVehiculos.SelectedIndex = 0;
            DataGridViewRow row = this.dgvVeh.Rows[e.RowIndex];
            IdVehiculo = Int32.Parse(row.Cells["ID"].Value.ToString());
            tbxChasis.Text = row.Cells["Chasis"].Value.ToString();
            cmbMarca.Text = row.Cells["Marca"].Value.ToString();
            cmbModelo.Text = row.Cells["Modelo"].Value.ToString();
            cmbCategoria.Text= row.Cells["Categoria"].Value.ToString();
            cmbAños.Text = row.Cells["Año"].Value.ToString();
            cmbColor.Text= row.Cells["Color"].Value.ToString();
            cmbCilindros.Text= row.Cells["CantCilindros"].Value.ToString();
            cmbPuertas.Text = row.Cells["CantPuertas"].Value.ToString();
            tbxKm.Text= row.Cells["Km"].Value.ToString();
            rtbxDetalles.Text = row.Cells["Detalles"].Value.ToString();
            modelo = Int32.Parse(row.Cells["ModeloID"].Value.ToString());
            btnGuardar.Hide();
            btnMod.Show();
        }

        //LLena el dgv cuando se carga la pagina
        private void dgvVeh_Fill(object sender, EventArgs e)
        {
            btnGuardar.Show();
            Query = @"SELECT vh.ID,vh.MarcaID,vh.ModeloID,vh.CategoriaID,Chasis,mc.Nombre as Marca,md.Nombre as Modelo,ctg.Nombre as Categoria,Color,CantPuertas,CantCilindros,KmActual as KM,AñoRegistro as Año, vh.Detalles
                From Vehiculos vh 
                Join Marcas mc On (vh.MarcaID=mc.MarcaID) 
                Join Modelos md On (vh.ModeloID=md.ModeloID)
                Join Categorias ctg On (vh.CategoriaID=ctg.Id)";
            dgvVeh.DataSource=Con.SELECT(Query);
            dgvVeh.Columns["ID"].Visible = dgvVeh.Columns["MarcaID"].Visible = dgvVeh.Columns["ModeloID"].Visible = dgvVeh.Columns["CategoriaID"].Visible = false;
        }

    }
}
