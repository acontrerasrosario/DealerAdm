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
            /* muestra en un grid, el resultado de la tabla vehiculo, 
             * donde muestra todos los datos de los vehiculos registrados */
            Display_Grid();
            fillYear(); // llena el combobox donde estan los años
            fillMarcas(); // llena el combobox donde estan las marcas
            fillComboBoxCategoria(); // llena el combobox donde estan las categorias
        }

        void fillYear()
        {

            /*
             * Agrega desde el 2007 hasta el año actual en un combobox
             */
            int year;
            int currentyear = System.DateTime.Now.Year;
            for (year = 2007 ; year < currentyear; year++)
            {
                comboBoxYear.Items.Add(year + 1);
            }
        }


        void fillMarcas()
        {
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                string Query = "SELECT NOMBRE FROM MARCAS";
                SqlCommand cmd = new SqlCommand(Query, conString);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    CBoxMarca.Items.Add(sqlReader["Nombre"].ToString());
                }
            }
        }
             
        /*
         * Aqui cuando se presiona el boton de agregar, se realiza un query inserta el vehiculo a la base de datos
         * donde queda totalmente registrado.
         */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                
                string Query = @"INSERT INTO Vehiculos(CategoriaID,MarcaID,ModeloID,Chasis,Color,CantPuertas,CantCilindros,KmActual, AñoRegistro, FechaAquisicion,Detalles,  PrecioAdquirido, PrecioVenta) "+ 
                                "Values ("+ValidarCategoria.valida(cbCategoria.Text)+","+ValidarMarca.valida(CBoxMarca.Text)+ ","+ValidarModelo.valida(comboBoxModelos.Text)+","+
                                        "'"+textBoxChasis.Text+"'"+","+"'"+comboBoxColor.Text+"'"+","+
                                        comboBoxPuertas.Text+","+comboBoxCilindros.Text+","+textKm.Text+","+comboBoxYear.Text+","
                                        +"'"+Convert.ToDateTime(dateTimeAdq.Text)+"'" + ","+"'"+richtextDetalles.Text+"'" + ","+textPrecioAdq.Text
                                        +","+textPrecioVenta.Text+")";
                SqlCommand cmd = new SqlCommand(Query, conString);
                cmd.ExecuteNonQuery();
                conString.Close();
                
            }
            Display_Grid();
        }
       
        public void Display_Grid()
        {
            /*
             * Aqui se da una mejor vision a los vehiculos ya registrados en la ventana de agregar vehiculo 
             */
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

        public void fillComboBoxCategoria()
        {

            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                string Query = "SELECT NOMBRE FROM CATEGORIAS";
                SqlCommand cmd = new SqlCommand(Query, conString);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbCategoria.Items.Add(sqlReader["Nombre"].ToString());
                }
            }

        }
        
        private void CBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * esto tiene el proposito de mostrar en un combobox los modelos de las marcas seleccionada en el
             * combobox de MARCAS 
             */
            comboBoxModelos.Items.Clear();
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                string Query = "SELECT mo.Nombre FROM MODELOS mo " +
                                "JOIN Marcas ma " +
                                "ON(mo.MarcaID = ma.MarcaID) " +
                                "WHERE ma.Nombre =" + "'" + CBoxMarca.Text + "'"; 
                
                SqlCommand cmd = new SqlCommand(Query, conString);
                 SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comboBoxModelos.Items.Add(sqlReader["Nombre"].ToString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*
             * Aqui al ser presionado el boton de cancelar, cierra la ventana de agregar vehiculo
             * 
             */
            this.Close();
        }

    }
}
