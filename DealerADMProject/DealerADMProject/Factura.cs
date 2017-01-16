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
        int clienteid;
        int vehiculoid;
        double quantity, unitprice, totalamount;
        double discount;
        double d;

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

        void fillGridDetFactura(int id, string detalle, string chasis)
        {
            ArrayList row = new ArrayList();
            row.Add(id);
            row.Add(detalle);
            row.Add(chasis);
            dgvDetFactura.Rows.Add(row.ToArray());

        }

        // aqui se busca el vehiculo por numero de chasis
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT ve.ID ,Ma.Nombre AS MARCA, mo.Nombre AS MODELO, ve.AñoRegistro AS AÑO, ca.Nombre AS CATEGORIA, ve.Color AS COLOR, ve.PrecioVenta AS PRECIO " +
                                "FROM Vehiculos ve join Modelos mo ON (ve.ModeloID = mo.ModeloID) " +
                                "JOIN Marcas ma ON(mo.MarcaID = ma.MarcaID) JOIN Categorias ca ON(ca.Id = ve.CategoriaID) " +
                                "WHERE ve.Chasis = " + "'" + tbxChasis.Text + "'";
                dt = Con.SELECT(Query);
                foreach (DataRow item in dt.Rows)
                {
                    tbxMarca.Text = item["MARCA"].ToString();
                    tbxModelo.Text = item["MODELO"].ToString();
                    tbxAño.Text = item["AÑO"].ToString();
                    tbxCat.Text = item["CATEGORIA"].ToString();
                    tbxColor.Text = item["COLOR"].ToString();
                    tbxPrecio.Text =  item["PRECIO"].ToString();
                    unitprice = double.Parse(item["PRECIO"].ToString());
                    vehiculoid = Convert.ToInt32(item["ID"]);
                    fillGridDetFactura(vehiculoid, tbxMarca.Text + " " + tbxModelo.Text + " " + tbxAño.Text, tbxChasis.Text);

                }

            }
            catch
            {
                MessageBox.Show("Error al cargar informacion del vehiculo");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string fecha = System.DateTime.Now.ToString();
                       
            string QueryVenta = @"INSERT INTO Venta(ClienteID,VehiculoID,FechaVenta,PrecioVenta,PrecioFinal,DetalleVenta) 
                     Values ("+clienteid+","+vehiculoid+","+"'"+fecha+"'"+","+tbxPrecio.Text+","+tbxTotal.Text+","+"'"+tbxDetalleVenta.Text+"'"+")";

            bool proceder = false;
            
            if (Con.INSERT(QueryVenta))
            {

                int idVenta = Validar.ValidarIDVENTA((fecha));
                string QueryFactura = @"INSERT INTO Facturas(VentaID,ClienteID,EmpleadoID,RNC,FechaVencimiento,Total)
                     Values (" + idVenta + "," + clienteid + "," + 1 + "," + "'" + tbxRNC.Text + "'" + "," + "'" + Convert.ToDateTime(FechaVencimiento.Text) + "'" + "," + tbxTotal.Text + ")";
                if (Con.INSERT(QueryFactura))
                {
                    string QueryDetFactura = @"INSERT INTO [Detalle Factura](FacturaID,VehiculoID,Cantidad,Descuento,Precio)
                     Values (" + Validar.ValidarIDFactura(idVenta) + "," + vehiculoid + "," + CantidadCompra.Value + "," + CantDiscount.Value + "," + tbxTotal.Text + ")";
                    
                    
                }

                else
                    MessageBox.Show("Ha habido un error en la factura");



            }
            else
                MessageBox.Show("Ha habido un error en la venta");
        }

        void cleanAll()
        {
            this.tbxTotal.Text = this.tbxRNC.Text = this.tbxPrecio.Text = this.tbxModelo.Text = this.tbxMarca.Text = this.tbxDetalleVenta.Text = this.tbxColor.Text = this.tbxChasis.Text = this.tbxCat.Text = this.tbxAño.Text = "";
            this.CantidadCompra.Value = this.CantDiscount.Value = 0;
            SETFechaVencimiento();
        }

        private void CantDiscount_ValueChanged(object sender, EventArgs e)
        {
            discount = Convert.ToDouble(CantDiscount.Value);
            quantity = Convert.ToDouble(CantidadCompra.Value);

            d = quantity * unitprice;
            if (discount == 0)
            {
                totalamount = d;
            }
            else
            {
                totalamount = (d) - ((d *(discount)) / 100);

            }

            tbxTotal.Text = totalamount.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void CantidadCompra_ValueChanged(object sender, EventArgs e)
        {
            discount = Convert.ToDouble(CantDiscount.Value);
            quantity = Convert.ToDouble(CantidadCompra.Value);

            d = quantity * unitprice;
            if (discount == 0)
            {
                totalamount = d;
            }
            else
            {
                totalamount = ((d * discount) / 100);
            }

            tbxTotal.Text = totalamount.ToString();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // el 8 es el backspace
            
               
            
        
        }
        /*
* TODO 
* ARREGLAR BOTONES
* DE ELIMINAR, CANCELAR Y MODIFICAR
*/
    }
}
