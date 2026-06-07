using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace CinemaPro.WinForms.DesignFirst.Data
{
    public static class DatabaseHelper
    {
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            var dataTable = new DataTable();
            using (SqlConnection conn = DbConnectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        conn.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = DbConnectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = DbConnectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}