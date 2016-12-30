using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerADMProject
{
    class SQLCRUD
    {
        public bool INSERT(string Query)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            int i;
            using (conString)
            {
                conString.Open();
                SqlCommand cmd = new SqlCommand(Query, conString);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                     i=cmd.ExecuteNonQuery();
                }
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DELETE(string Tabla ,string Condicion)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            int i;
            using (conString)
            {
                conString.Open();
                string Query = "DELETE FROM " + Tabla + " WHERE " + Condicion;
                SqlCommand cmd = new SqlCommand(Query, conString);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    i = cmd.ExecuteNonQuery();
                }
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SELECT (string Query)
        {
            DataTable dt = new DataTable();
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            using (conString)
            {
                conString.Open();
                SqlCommand cmd = new SqlCommand(Query, conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.ExecuteNonQuery();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable CMB_DATA (string Tabla)
        {
            SqlConnection conString = new SqlConnection(DatabaseConnection.conndb);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            using (conString)
            {
                conString.Open();
                string Query = "SELECT * FROM " + Tabla;
                SqlCommand cmd = new SqlCommand(Query,conString);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds, Tabla);
                    dt = ds.Tables[Tabla];
                    return dt;
                }
            }
            
        }
    }
}
