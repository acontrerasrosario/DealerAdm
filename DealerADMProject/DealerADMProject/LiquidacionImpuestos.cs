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
    public partial class LiquidacionImpuestos : Form
    {
<<<<<<< HEAD

=======
        //klk
>>>>>>> 0794f43f15c25ab14e2f9c03d7e339d62fd9957e
        private DataTable dt = new DataTable();
        public LiquidacionImpuestos()
        {
            
            InitializeComponent();
            

        }
        string Query;
        SQLCRUD Con=new SQLCRUD();
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            Query = "SELECT ID FROM Vehiculos WHERE Chasis ="+tbxChasis.Text;
=======
            Query = "SELECT ID FROM Vehiculos WHERE Chasis ="+"'"+tbxChasis.Text+"'";
>>>>>>> 0794f43f15c25ab14e2f9c03d7e339d62fd9957e
            if (Con.EXIST(Query))
            {
                DataRow row = Con.SELECT(Query).Rows[0];
                tbxVehiculo.Text = row["ID"].ToString();
                
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el vehiculo");
            }
            
        }


        private void Enable_gbForm()
        {
            tbxArancelID.Enabled = tbxFOB.Enabled=tbxFlete.Enabled=ckbDrCafta.Enabled= true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbxChasis.Text = tbxVehiculo.Text = tbxArancelID.Text = tbxFOB.Text = tbxFlete.Text =tbxOtros.Text=tbxMulta.Text="";
            ckbDrCafta.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Query = "SELECT LiquidacionID FROM Liquidaciones WHERE liquidacionID="+ tbxLiquidacionID.Text;
            if (Con.EXIST(Query))
            {
                Agregar_Item();
                dgvItem_View();
            }
            else
            {
                Query = @"INSERT INTO Liquidaciones (LiquidacionID,FechaDecl,FechaLLegada,Agencia,Consignatario,Declaracion,Detalle)
                        Values('"+tbxLiquidacionID.Text+"','"+dtpFechaDecl.Value.ToString("MM-dd-yyyy")+"','"+dtpFechaLLega.Value.ToString("MM-dd-yyyy")+ "','"+tbxAgencia.Text+ "','"+tbxConsignatario.Text+ "','"+tbxDeclaracionID.Text+ "','"+richTextBox1.Text+"')";
                Con.INSERT(Query);

                Agregar_Item();
                dgvItem_View();
            }

        }

        private void Agregar_Item()
        {
            int value = 0;
            if (ckbDrCafta.Checked) value = 1;
            Query = @"INSERT INTO [Detalle Liquidacion] (ItemID,VehiculoID,LiquidacionID,FOB,Flete,Otros,Multa,TLC)
                VALUES('" + tbxArancelID.Text + "','" + tbxVehiculo.Text + "','" + tbxLiquidacionID.Text + "','" + tbxFOB.Text + "','" + tbxFlete.Text + "','" + tbxOtros.Text + "','" + tbxMulta.Text + "','" + value + "')";

            if (Con.INSERT(Query))
            {
                MessageBox.Show("Registro guardado exitosamente");
            }
            else
            {
                MessageBox.Show("No se ha podido almacenar el registro");
            }
        }

        private void dgvItem_View()
        {
            Query = @"SELECT Dl.ItemID,vh.Chasis,mc.Nombre AS Marca ,md.Nombre AS Modelo,vh.AñoRegistro,vh.Color FROM  [Detalle Liquidacion] Dl
                    JOIN Vehiculos vh ON (Dl.VehiculoID=vh.ID)
                    JOIN Marcas mc ON (vh.MarcaID = mc.MarcaID)
                    JOIN Modelos md ON(vh.ModeloID = md.ModeloID)
                    WHERE Dl.LiquidacionID=" + tbxLiquidacionID.Text;

            dgvInfoVeh.DataSource = Con.SELECT(Query);
            dgvInfoVeh.ReadOnly = true;
            
        }

        //TAB Registros de liquidacion

        private void Buscar (object sender , EventArgs e)
        {
            try
            {
                if (rbLiqID.Checked == true)
                {
                    Query = "SELECT LiquidacionID,Consignatario,FechaDecl,FechaLLegada FROM Liquidaciones WHERE LiquidacionID=" + tbxCampo.Text;
                }
                else if (rbAgencia.Checked == true)
                {
                    Query = "SELECT LiquidacionID,Consignatario,FechaDecl,FechaLLegada FROM Liquidaciones WHERE Agencia=" + tbxCampo.Text;
                }
                else if (rbFechallegada.Checked == true)
                {

                    Query = "SELECT LiquidacionID,Consignatario,FechaDecl,FechaLLegada FROM Liquidaciones WHERE FechaLLegada BETWEEN + '"+dtpRangoInicial.Value.ToString("MM-dd-yyyy")+"' AND '" + dtpRangoFinal.Value.ToString("MM-dd-yyyy") +"'";
                }
                else
                {
                    MessageBox.Show("Elegir un campo");
                }
                dgvResgistrosLiq.DataSource = Con.SELECT(Query);
            }
            catch
            {
                MessageBox.Show("Escriba un valor");
            }
            dgvResgistrosLiq.ReadOnly = true;
        }

        private void dgvRegistrosLiquidacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvResgistrosLiq.Rows[e.RowIndex];
                string val = row.Cells["LiquidacionID"].Value.ToString();
                int ID = Int32.Parse(val);
                dgvDetalle_View(ID);
            }
        }

        private void dgvDetalle_View(int ID)
        {

            Query = @"SELECT ItemID ,vh.Chasis,mc.Nombre AS Marca,md.Nombre AS Modelo,LiquidacionID,FOB,Flete,Otros,Multa,
                    CASE WHEN TLC=1 THEN 'DR-CAFT' END As Acuerdo,
                    (FOB*0.02) As Seguro,(FOB+Flete+(FOB*0.02)+Otros)As CIF,
                    CASE WHEN TLC=1THEN (FOB+Flete+(FOB*0.02)+Otros)*0.1 ELSE 0 END AS ImpuestoAduanal,
                    CASE WHEN TLC=1 THEN (FOB+Flete+(FOB*0.02)+Otros)*0.18 ELSE ((FOB+Flete+(FOB*0.02)+Otros)+(FOB+Flete+(FOB*0.02)+Otros)*0.1)*0.18 END AS ITEBIS
                     FROM [Detalle Liquidacion] 
                     JOIN Vehiculos vh ON(Vh.ID=VehiculoID)
                     JOIN Marcas mc ON (vh.MarcaID = mc.MarcaID)
                     JOIN Modelos md ON(vh.ModeloID = md.ModeloID)
                     WHERE LiquidacionID=" + ID;

            dgvDetalle.DataSource = Con.SELECT(Query);
            dgvDetalle.ReadOnly = true;
            CalTotal(Query, ID);
        }


        private void CalTotal(string Query,int ID)
        {
            dt = Con.SELECT(Query);
            decimal TFOB=(decimal)dt.Compute("Sum(FOB)", "LiquidacionID=" + ID);
            decimal TSeguro=(decimal)dt.Compute("Sum(Seguro)","LiquidacionID="+ID);
            decimal TFlete= (decimal)dt.Compute("Sum(Flete)", "LiquidacionID=" + ID);
            decimal TOtros = (decimal)dt.Compute("Sum(Otros)", "LiquidacionID=" + ID);
            decimal TCIF = (decimal)dt.Compute("Sum(CIF)", "LiquidacionID=" + ID);
            decimal TITEBIS = (decimal)dt.Compute("Sum(ITEBIS)", "LiquidacionID="+ ID);
            decimal TMultas = (decimal)dt.Compute("Sum(Multa)", "LiquidacionID=" + ID);
            decimal Total = TCIF + TITEBIS + TMultas;
            lblTFOB.Text = TFOB.ToString("0.00");
            lblVTSeguro.Text=TSeguro.ToString("0.00");
            lblVTFlete.Text = TFlete.ToString("0.00");
            lblVTotros.Text = TOtros.ToString("0.00");
            lblMulta.Text = TMultas.ToString("0.00");
            lblTCIF.Text = TCIF.ToString("0.00");
            lblItbis.Text = TITEBIS.ToString("0.00");
            lblVTMulta.Text = TMultas.ToString("0.00");
            lbltotal.Text = Total.ToString("0.00");

        }
<<<<<<< HEAD

=======
        
>>>>>>> 0794f43f15c25ab14e2f9c03d7e339d62fd9957e
    }
}