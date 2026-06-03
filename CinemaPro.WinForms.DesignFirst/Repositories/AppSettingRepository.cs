namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class AppSettingRepository
{
    public Dictionary<string, string> GetAllAsDictionary()
    {
        const string sql = """
            SELECT
                SettingKey,
                SettingValue
            FROM dbo.AppSettings
            ORDER BY SettingKey;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var settings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (DataRow row in table.Rows)
        {
            var key = row["SettingKey"].ToString() ?? "";
            var value = row["SettingValue"].ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(key))
            {
                settings[key] = value;
            }
        }

        return settings;
    }

    public void Upsert(string key, string value, string description)
    {
        const string updateSql = """
            UPDATE dbo.AppSettings
            SET
                SettingValue = @SettingValue,
                Description = @Description,
                UpdatedAt = SYSDATETIME()
            WHERE SettingKey = @SettingKey;
            """;

        var affectedRows = DatabaseHelper.ExecuteNonQuery(
            updateSql,
            new SqlParameter("@SettingKey", key),
            new SqlParameter("@SettingValue", value),
            new SqlParameter("@Description", description));

        if (affectedRows > 0)
        {
            return;
        }

        const string insertSql = """
            INSERT INTO dbo.AppSettings
            (
                SettingKey,
                SettingValue,
                Description
            )
            VALUES
            (
                @SettingKey,
                @SettingValue,
                @Description
            );
            """;

        DatabaseHelper.ExecuteNonQuery(
            insertSql,
            new SqlParameter("@SettingKey", key),
            new SqlParameter("@SettingValue", value),
            new SqlParameter("@Description", description));
    }
}
