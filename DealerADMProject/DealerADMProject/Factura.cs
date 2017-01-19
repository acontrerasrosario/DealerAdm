using System;
using System.Collections;
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
            SETFechaVencimiento();
        }

        SQLCRUD Con = new SQLCRUD();
        DataTable dt = new DataTable();
        string Query;
        int clienteid, facturaid;
        int vehiculoid;
        double unitprice, totalamount;
        double discount;

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            MantenimientoCliente C = new MantenimientoCliente();
            C.ShowDialog();
        }
        void SETFechaVencimiento()
        {
            // aqui agrego que la factura va a vencer 90 dias despues de haberse creado
            DateTime endDate = System.DateTime.Now.AddDays(90);
            FechaVencimiento.Text = endDate.ToString();
        }   


        // aqui se busca al cliente por cedula
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM CLIENTES WHERE CEDULA = "+"'"+tbCedula.Text+"'";
                dt = Con.SELECT(Query);
                foreach (DataRow item in dt.Rows)
                {
                    tbClienteName.Text = item["Nombre"].ToString() + " " + item["Apellido"].ToString();
                    mtbTelf.Text = item["Telefono"].ToString();
                    txbDir.Text = item["Direccion"].ToString();
                    clienteid = Convert.ToInt32(item["ID"]);
                }
                
            }
            catch
            {
                MessageBox.Show("Error al cargar informacion del cliente");
            }
        }

        void fillGridDetFactura(int id, string detalle, string chasis, double precio)
        {
            ArrayList row = new ArrayList();
            row.Add(id);
            row.Add(detalle);
            row.Add(chasis);
            row.Add(precio);
            row.Add(0);
            row.Add(precio);
            if (!CheckExist(id))
            {
                dgvDetFactura.Rows.Add(row.ToArray());
            }
            else
            {
                MessageBox.Show("Vehiculo ya existe en factura");
            }
            

        }

        bool CheckExist(int id)
        {
            for (int i = 0; i < dgvDetFactura.Rows.Count; i++)
            {
                if (dgvDetFactura.Rows[i].Cells[0].Value != null && id == int.Parse(dgvDetFactura.Rows[i].Cells[0].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        // aqui se busca el vehiculo por numero de chasis
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT ve.ID ,Ma.Nombre AS MARCA, mo.Nombre AS MODELO, ve.AñoRegistro AS AÑO, ca.Nombre AS CATEGORIA, ve.Color AS COLOR, ve.PrecioVenta AS PRECIO " +
                                "FROM Vehiculos ve join Modelos mo ON (ve.ModeloID = mo.ModeloID) " +
                                "JOIN Marcas ma ON(mo.MarcaID = ma.MarcaID) JOIN Categorias ca ON(ca.Id = ve.CategoriaID) " +
                                "WHERE ve.Chasis = " + "'" + tbxChasis.Text + "'" + "AND ve.Estado !=" + "'VENDIDO'";

                dt = Con.SELECT(Query);
                if (dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            tbxMarca.Text = item["MARCA"].ToString();
                            tbxModelo.Text = item["MODELO"].ToString();
                            tbxAño.Text = item["AÑO"].ToString();
                            tbxCat.Text = item["CATEGORIA"].ToString();
                            tbxColor.Text = item["COLOR"].ToString();
                            tbxPrecio.Text = item["PRECIO"].ToString();
                            unitprice = double.Parse(item["PRECIO"].ToString());
                            vehiculoid = Convert.ToInt32(item["ID"]);

                            fillGridDetFactura(vehiculoid, tbxMarca.Text + " " + tbxModelo.Text + " " + tbxAño.Text, tbxChasis.Text, unitprice);

                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Este carro no esta disponible para venta");
                    }
                }
                else
                {
                    MessageBox.Show("Este carro no esta disponible para venta");
                }
               
            }
            catch
            {
                MessageBox.Show("Error al cargar informacion del vehiculo");
            }
        }

        private void dgvDetFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double TotalSum = 0;
            if(dgvDetFactura.Rows.Count > 0)
            {
                unitprice = double.Parse(dgvDetFactura.Rows[e.RowIndex].Cells["PrecioColumn"].Value.ToString());
                discount = double.Parse(dgvDetFactura.Rows[e.RowIndex].Cells["DescColumn"].Value.ToString());
                if (discount == 0)
                {

                    dgvDetFactura.Rows[e.RowIndex].Cells["TotalColumn"].Value = (unitprice).ToString();
                }
                else
                {
                    totalamount = (unitprice - ((unitprice * discount) / 100));
                    dgvDetFactura.Rows[e.RowIndex].Cells["TotalColumn"].Value = (totalamount).ToString();
                }

               

                for (int i = 0; i < dgvDetFactura.Rows.Count; i++)
                {
                    TotalSum += Convert.ToDouble(dgvDetFactura.Rows[i].Cells["TotalColumn"].Value);
                }
                
                 
    
            }

            tbxTotal.Text = TotalSum.ToString();




        }

        void cleanAll()
        {
            this.tbxTotal.Text = this.tbxRNC.Text = this.tbxPrecio.Text = this.tbxModelo.Text = this.tbxMarca.Text = this.tbxDetalleVenta.Text = this.tbxColor.Text = this.tbxChasis.Text = this.tbxCat.Text = this.tbxAño.Text = "";
            SETFechaVencimiento();
        }

        private void dgvDetFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double TotalSum = 0;
            if (dgvDetFactura.Rows.Count > 0)
            {


                unitprice = double.Parse(dgvDetFactura.Rows[e.RowIndex].Cells["PrecioColumn"].Value.ToString());
                discount = double.Parse(dgvDetFactura.Rows[e.RowIndex].Cells["DescColumn"].Value.ToString());
                if (discount == 0)
                {

                    dgvDetFactura.Rows[e.RowIndex].Cells["TotalColumn"].Value = (unitprice).ToString();
                }
                else
                {
                    totalamount = (unitprice - ((unitprice * discount) / 100));
                    dgvDetFactura.Rows[e.RowIndex].Cells["TotalColumn"].Value = (totalamount).ToString();
                }



                for (int i = 0; i < dgvDetFactura.Rows.Count; i++)
                {
                    TotalSum += Convert.ToDouble(dgvDetFactura.Rows[i].Cells["TotalColumn"].Value);
                }



            }

            tbxTotal.Text = TotalSum.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace
        }

        private void tbxRNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace
        }

        private void dgvDetFactura_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("please enter numeric");
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {


                string QueryFactura = "INSERT INTO Facturas(ClienteID,EmpleadoID,RNC,FechaVencimiento,Total)" +
                    "Values(" + clienteid + "," + 1 + "," + "'" + tbxRNC.Text + "'" + "," + "'" + Convert.ToDateTime(FechaVencimiento.Text) + "'" + "," + Convert.ToDouble(tbxTotal.Text) + ")";

                

                if (Con.INSERT(QueryFactura))
                {
                    dt = Con.SELECT("SELECT TOP 1 ID FROM Facturas ORDER BY ID desc");

                    foreach (DataRow item in dt.Rows)
                    {
                        facturaid = Int32.Parse(item["ID"].ToString());
                    }
                    // CREANDO DETALLE FACTURA
                    for (int i = 0; i < dgvDetFactura.Rows.Count; i++)
                    {
                        string QueryDetFactura = "INSERT INTO [Detalle Factura](FacturaID,VehiculoID,Descuento,Precio)" +
                        "Values(" + facturaid + "," + (Convert.ToInt32(dgvDetFactura.Rows[i].Cells["IdColumn"].Value.ToString())) + "," + (Convert.ToInt32(dgvDetFactura.Rows[i].Cells["DescColumn"].Value.ToString())) + "," + (Convert.ToInt32(dgvDetFactura.Rows[i].Cells["PrecioColumn"].Value.ToString())) + ")";

                        if (Con.INSERT(QueryDetFactura))
                        {
                            if(i == dgvDetFactura.Rows.Count-1)
                            {
                                MessageBox.Show("La compra fue hecha con exito");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en el detalle de factura");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error creando factura");
                }
            }
            catch
            {
                MessageBox.Show("Error agregando factura");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace
        }
    }
}
