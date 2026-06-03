namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class UserRepository
{
    public User? FindByUsername(string username)
    {
        const string sql = """
            SELECT TOP 1
                UserId,
                UserCode,
                FullName,
                Username,
                PasswordHash,
                Role,
                UserStatus,
                CreatedAt,
                UpdatedAt
            FROM dbo.Users
            WHERE Username = @Username;
            """;

        var table = DatabaseHelper.ExecuteQuery(
            sql,
            new SqlParameter("@Username", username.Trim()));

        return table.Rows.Count == 0 ? null : MapUser(table.Rows[0]);
    }

    public IReadOnlyList<User> GetAll()
    {
        const string sql = """
            SELECT
                UserId,
                UserCode,
                FullName,
                Username,
                PasswordHash,
                Role,
                UserStatus,
                CreatedAt,
                UpdatedAt
            FROM dbo.Users
            ORDER BY UserId;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var users = new List<User>();

        foreach (DataRow row in table.Rows)
        {
            users.Add(MapUser(row));
        }

        return users;
    }

    public User? FindByCode(string userCode)
    {
        const string sql = """
            SELECT TOP 1
                UserId,
                UserCode,
                FullName,
                Username,
                PasswordHash,
                Role,
                UserStatus,
                CreatedAt,
                UpdatedAt
            FROM dbo.Users
            WHERE UserCode = @UserCode;
            """;

        var table = DatabaseHelper.ExecuteQuery(
            sql,
            new SqlParameter("@UserCode", userCode));

        return table.Rows.Count == 0 ? null : MapUser(table.Rows[0]);
    }

    public bool UsernameExists(string username, string? exceptUserCode = null)
    {
        const string sql = """
            SELECT COUNT(*)
            FROM dbo.Users
            WHERE Username = @Username
                AND (@ExceptUserCode IS NULL OR UserCode <> @ExceptUserCode);
            """;

        var count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(
            sql,
            new SqlParameter("@Username", username.Trim()),
            new SqlParameter("@ExceptUserCode", (object?)exceptUserCode ?? DBNull.Value)));

        return count > 0;
    }

    public string GetNextUserCode()
    {
        const string sql = """
            SELECT
                ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(UserCode, 2, 10))), 0) + 1
            FROM dbo.Users
            WHERE UserCode LIKE N'U%';
            """;

        var nextNumber = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql));
        return "U" + nextNumber.ToString("000");
    }

    public void Insert(User user)
    {
        const string sql = """
            INSERT INTO dbo.Users
            (
                UserCode,
                FullName,
                Username,
                PasswordHash,
                Role,
                UserStatus
            )
            VALUES
            (
                @UserCode,
                @FullName,
                @Username,
                @PasswordHash,
                @Role,
                @UserStatus
            );
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@UserCode", user.UserCode),
            new SqlParameter("@FullName", user.FullName),
            new SqlParameter("@Username", user.Username),
            new SqlParameter("@PasswordHash", user.PasswordHash),
            new SqlParameter("@Role", user.Role),
            new SqlParameter("@UserStatus", user.UserStatus));
    }

    public void Update(User user)
    {
        const string sql = """
            UPDATE dbo.Users
            SET
                FullName = @FullName,
                Username = @Username,
                Role = @Role,
                UserStatus = @UserStatus,
                UpdatedAt = SYSDATETIME()
            WHERE UserCode = @UserCode;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@UserCode", user.UserCode),
            new SqlParameter("@FullName", user.FullName),
            new SqlParameter("@Username", user.Username),
            new SqlParameter("@Role", user.Role),
            new SqlParameter("@UserStatus", user.UserStatus));
    }

    public void UpdateStatus(string userCode, string status)
    {
        const string sql = """
            UPDATE dbo.Users
            SET
                UserStatus = @UserStatus,
                UpdatedAt = SYSDATETIME()
            WHERE UserCode = @UserCode;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@UserCode", userCode),
            new SqlParameter("@UserStatus", status));
    }

    private static User MapUser(DataRow row)
    {
        return new User
        {
            UserId = Convert.ToInt32(row["UserId"]),
            UserCode = row["UserCode"].ToString() ?? "",
            FullName = row["FullName"].ToString() ?? "",
            Username = row["Username"].ToString() ?? "",
            PasswordHash = row["PasswordHash"].ToString() ?? "",
            Role = row["Role"].ToString() ?? "",
            UserStatus = row["UserStatus"].ToString() ?? "",
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
            UpdatedAt = row["UpdatedAt"] == DBNull.Value ? null : Convert.ToDateTime(row["UpdatedAt"])
        };
    }
}
