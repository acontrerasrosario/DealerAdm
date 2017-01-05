using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerADMProject
{
    class Validar
    {
        static SQLCRUD con = new SQLCRUD();
        static DataTable dt = new DataTable();
        public static int ValidarIDVENTA(string fecha )
        {
            
                int id = 0;

                string Query = "SELECT ID FROM VENTA WHERE FechaVenta =" + "'" + fecha + "'";
                dt = con.SELECT(Query);
                foreach (DataRow item in dt.Rows)
                {
                    id = Convert.ToInt32(item["ID"]);
                }
                return id;
          
        }

        public static int ValidarIDFactura(int VentaID)
        {
            int id = 0;

            string Query = "SELECT ID FROM FACTURAS WHERE VENTAID =" + VentaID;
            dt = con.SELECT(Query);
            foreach (DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item["ID"]);
            }
            return id;
        }
    }
}
