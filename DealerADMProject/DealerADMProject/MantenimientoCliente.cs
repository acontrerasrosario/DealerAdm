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
            FillDataGRID();
        }
        //Variables Globales
        SQLCRUD Con = new SQLCRUD();
        int indexRow;
        int idCliente;

        //Prepara el formulario para ingresar un nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clean_Fields();
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
        }

        bool emptydata()
        {
            
            if (string.IsNullOrEmpty(tbxCedula.Text) || string.IsNullOrEmpty(tbxApellido.Text) || 
                string.IsNullOrEmpty(tbxNombre.Text) || string.IsNullOrEmpty(tbxDireccion.Text) || 
                string.IsNullOrEmpty(cmbEstado.Text) || string.IsNullOrEmpty(tbxEmail.Text) || 
                string.IsNullOrEmpty(mtbxTelfono.Text) || string.IsNullOrEmpty(tbxProvincia.Text) ||
                string.IsNullOrEmpty(tbxCalle.Text))
            {
                return true;

            }

            return false;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!emptydata())
            {
                string Query = @"INSERT INTO Clientes(Cedula, Nombre, Apellido, Email, Telefono, Provincia, Calle, Direccion, Comentario,Estado) 
                        Values ('" + tbxCedula.Text + "','" + tbxNombre.Text + "','" + tbxApellido.Text + "','" + tbxEmail.Text + "','" + mtbxTelfono.Text + "','" + tbxProvincia.Text + "','" + tbxCalle.Text + "','" + tbxDireccion.Text + "','" + rtbComentario.Text + "','" + cmbEstado.Text + "')";
                if (Con.INSERT(Query))
                {
                    MessageBox.Show("Cliente registrado correctamente");
                    Clean_Fields();
                    FillDataGRID();
                }
                else
                {
                    MessageBox.Show("Error No se pudo alcemanar el usuario");
                }
            }
            else
            {
                MessageBox.Show("llenar todos los campos.");
            }

            
        }

        //Elimina un registro con la cedula
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!emptydata())
            {
                try
                {
                    if (rtbComentario.Equals("") || rtbComentario.Equals(" ") || rtbComentario.Equals(null))
                    {
                        rtbComentario.Text = null;
                    }
                    String Query = "UPDATE Clientes SET[Nombre] =" + "'" + tbxNombre.Text + "'" + ", [Apellido] =" + "'" + tbxApellido.Text + "'" + ", [Email] =" + "'" + tbxEmail.Text + "'" + ", [Cedula] =" + "'" + tbxCedula.Text + "'" + ", [Telefono] =" + "'" + mtbxTelfono.Text + "'" + ", [Calle] =" + "'" + tbxCalle.Text + "'" + ", [Provincia] =" + "'" + tbxProvincia.Text + "'" + ", [Direccion] =" + "'" + tbxDireccion.Text + "'" + ", [Comentario] =" + "'" + rtbComentario.Text + "'" + ", [Estado] = " + "'" + cmbEstado.Text + "'" + " WHERE[ID] =" + idCliente;
                    if (Con.UPDATE(Query))
                    {
                        MessageBox.Show("Cliente Modificado Correctamente");
                        Clean_Fields();
                        FillDataGRID();
                        tbcCliente.SelectedIndex = 1;
                    }

                }
                catch
                {
                    MessageBox.Show("Error al modificar usuario");
                }
            }
            else
            {
                MessageBox.Show("Llenar campos ");
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
                Query = "SELECT * From Clientes WHERE Cedula LIKE" +"'%"+ tbxCampo.Text+"%'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbApellido.Checked == true)
            {
                Query = "SELECT * From Clientes WHERE Apellido LIKE "+"'%"+ tbxCampo.Text+"%'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbDireccion.Checked==true)
            {
                Query = "SELECT * From Clientes WHERE Direccion LIKE" + "'%" + tbxCampo.Text + "%'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else if (rbEmail.Checked==true)
            {
                Query = "SELECT * From Clientes WHERE Email LIKE" + "'%" + tbxCampo.Text + "%'";
                dgvCliente.DataSource = Con.SELECT(Query);
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un campo");
            }
            
        }

        private void tbxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace
        }

        private void mtbxTelfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace

        }

        void FillDataGRID()
        {
            string QueryCliente = "SELECT * FROM CLIENTES";
            dgvCliente.DataSource = Con.SELECT(QueryCliente);
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            tbcCliente.SelectedIndex = 0;
            btnGuardar.Visible = false;
            btnModificar.Visible = true;
            DataGridViewRow row = dgvCliente.Rows[indexRow];
            idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());
            tbxCedula.Text = row.Cells[4].Value.ToString();
            tbxNombre.Text = row.Cells[1].Value.ToString();
            tbxApellido.Text = row.Cells[2].Value.ToString();
            tbxDireccion.Text = row.Cells[8].Value.ToString();
            tbxEmail.Text = row.Cells[3].Value.ToString();
            mtbxTelfono.Text = row.Cells[5].Value.ToString();
            tbxProvincia.Text = row.Cells[7].Value.ToString();
            tbxCalle.Text = row.Cells[6].Value.ToString();
            rtbComentario.Text = row.Cells[9].Value.ToString();
            if (row.Cells[10].Value.Equals("ACTIVO"))
            {
                cmbEstado.SelectedIndex = 0;
            }
            else
            {
                cmbEstado.SelectedIndex = 1;
            }
        }

        private void tbxCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rbCedula.Checked == true)
            {
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
           
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbxProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
