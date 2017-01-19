using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerADMProject
{
    class Validaciones
    {
        static SQLCRUD con = new SQLCRUD();
        static DataTable dt = new DataTable();
        static string Query;
        public static int ValidarModelo(string name)
        {
            int id=0;

            Query = "SELECT mo.ModeloID FROM MODELOS mo JOIN Marcas ma ON(mo.MarcaID=ma.MarcaID)" +
                            "WHERE mo.Nombre =" + "'" + name + "'";
            dt = con.SELECT(Query);

            foreach(DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item["ModeloID"]);
            }
            
            return id;
        }

        public static int ValidarMarca(string name)
        {
            int id = 0;

            Query = "SELECT ma.MarcaID FROM Marcas ma WHERE ma.Nombre ="+ "'"+name+"'";
            dt = con.SELECT(Query);

            foreach (DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item["MarcaID"]);
            }

            return id;
        }

    }
}
