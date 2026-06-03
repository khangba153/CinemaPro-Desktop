using System.Data;
using Microsoft.Data.SqlClient;

namespace CinemaPro.WinForms.DesignFirst.Data;

public static class DatabaseHelper
{
    public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        using var command = new SqlCommand(sql, connection);

        if (parameters.Length > 0)
        {
            command.Parameters.AddRange(parameters);
        }

        using var adapter = new SqlDataAdapter(command);
        var table = new DataTable();

        connection.Open();
        PrepareConnection(connection);
        adapter.Fill(table);
        return table;
    }

    public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        using var command = new SqlCommand(sql, connection);

        if (parameters.Length > 0)
        {
            command.Parameters.AddRange(parameters);
        }

        connection.Open();
        PrepareConnection(connection);
        return command.ExecuteNonQuery();
    }

    public static object? ExecuteScalar(string sql, params SqlParameter[] parameters)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        using var command = new SqlCommand(sql, connection);

        if (parameters.Length > 0)
        {
            command.Parameters.AddRange(parameters);
        }

        connection.Open();
        PrepareConnection(connection);
        return command.ExecuteScalar();
    }

    public static bool CanConnect()
    {
        try
        {
            using var connection = DbConnectionFactory.CreateConnection();
            connection.Open();
            PrepareConnection(connection);

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
            using var connection = DbConnectionFactory.CreateConnection();
            connection.Open();
            PrepareConnection(connection);

            return "Kết nối database thành công.";
        }
        catch (Exception ex)
        {
            return "Kết nối database thất bại: " + ex.Message;
        }
    }

    public static void PrepareConnection(SqlConnection connection)
    {
        using var command = new SqlCommand("""
            SET QUOTED_IDENTIFIER ON;
            SET ANSI_NULLS ON;
            SET ANSI_WARNINGS ON;
            SET ANSI_PADDING ON;
            SET CONCAT_NULL_YIELDS_NULL ON;
            SET ARITHABORT ON;
            SET NUMERIC_ROUNDABORT OFF;
            """, connection);

        command.ExecuteNonQuery();
    }
}
