using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookHaven
{
    public static class DB
    {
        private static readonly string conStr =
            "Data Source=KETHNULEE;Initial Catalog=BookHavenDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }

        public static DataTable GetDataTable(string query)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void Execute(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

