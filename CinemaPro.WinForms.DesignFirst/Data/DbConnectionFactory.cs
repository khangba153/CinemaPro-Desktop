using Microsoft.Data.SqlClient;

namespace CinemaPro.WinForms.DesignFirst.Data;

public static class DbConnectionFactory
{
    public static SqlConnection CreateConnection()
    {
        return new SqlConnection(AppDbConfig.ConnectionString);
    }
}