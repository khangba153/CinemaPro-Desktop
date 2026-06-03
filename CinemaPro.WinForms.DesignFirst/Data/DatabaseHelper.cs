using System.Data;
using Microsoft.Data.SqlClient;

namespace CinemaPro.WinForms.DesignFirst.Data;

public static class DatabaseHelper
{
    public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
    {
        using var conn = DbConnectionFactory.CreateConnection();
        using var cmd = new SqlCommand(sql, conn);

        if (parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        using var adapter = new SqlDataAdapter(cmd);
        var table = new DataTable();

        adapter.Fill(table);
        return table;
    }

    public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
    {
        using var conn = DbConnectionFactory.CreateConnection();
        using var cmd = new SqlCommand(sql, conn);

        if (parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        conn.Open();
        return cmd.ExecuteNonQuery();
    }

    public static object? ExecuteScalar(string sql, params SqlParameter[] parameters)
    {
        using var conn = DbConnectionFactory.CreateConnection();
        using var cmd = new SqlCommand(sql, conn);

        if (parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        conn.Open();
        return cmd.ExecuteScalar();
    }

    public static bool CanConnect()
    {
        try
        {
            using var conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public static string GetConnectionTestMessage()
    {
        try
        {
            using var conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            return "Kết nối database thành công.";
        }
        catch (Exception ex)
        {
            return "Kết nối database thất bại: " + ex.Message;
        }
    }
}
