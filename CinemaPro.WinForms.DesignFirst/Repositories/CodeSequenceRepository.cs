namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class CodeSequenceRepository
{
    public string GetNextCode(SqlConnection connection, SqlTransaction transaction, string tableName, string columnName, string prefix, int digitCount)
    {
        using var command = new SqlCommand($"""
            SELECT
                ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING({columnName}, {prefix.Length + 1}, 20))), 0) + 1
            FROM {tableName}
            WHERE {columnName} LIKE @PrefixLike;
            """, connection, transaction);

        command.Parameters.AddWithValue("@PrefixLike", prefix + "%");
        var nextNumber = Convert.ToInt32(command.ExecuteScalar());
        return prefix + nextNumber.ToString(new string('0', digitCount));
    }
}
