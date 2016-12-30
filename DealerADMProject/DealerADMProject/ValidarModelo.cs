using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerADMProject
{
    class ValidarModelo
    {
        public static int valida(string nombreModelo)
        {
            int id = 0;

            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                string Query = "SELECT MODELOID FROM MODELOS WHERE Nombre =" + "'" + nombreModelo + "'";
                SqlCommand cmd = new SqlCommand(Query, conString);
                SqlDataReader sqlReader = cmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    id = Convert.ToInt32(sqlReader["MODELOID"]);
                }
            }



            return id;
        }
    }
}
