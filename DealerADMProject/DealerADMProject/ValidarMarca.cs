using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerADMProject
{
    class ValidarMarca
    {
        public static int valida(string nombreMarca)
        {
            int id = 0;

            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                string Query = "SELECT MARCAID FROM MARCAS WHERE Nombre ="+"'"+nombreMarca+"'";
                SqlCommand cmd = new SqlCommand(Query, conString);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    id = Convert.ToInt32(sqlReader["MARCAID"]);
                }
            }



            return id;
        }

            
    }
}
