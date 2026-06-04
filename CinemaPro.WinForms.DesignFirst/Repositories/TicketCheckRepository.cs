namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class TicketCheckRepository
{
    private readonly TicketRepository _ticketRepository = new();
    private readonly UserRepository _userRepository = new();

    public bool MarkTicketUsed(string ticketCode)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            var ticketId = _ticketRepository.GetTicketIdOrNull(connection, transaction, ticketCode);
            var checkedByUserId = _userRepository.GetCurrentSessionUserId(connection, transaction);

            if (ticketId is null)
            {
                InsertTicketCheck(connection, transaction, null, ticketCode, checkedByUserId, "NotFound", "Khong tim thay ve.");
                transaction.Commit();
                return false;
            }

            var status = _ticketRepository.GetTicketStatus(connection, transaction, ticketId.Value);
            if (status != "Unused")
            {
                InsertTicketCheck(connection, transaction, ticketId, ticketCode, checkedByUserId, ToCheckResult(status), "Ve khong con o trang thai chua dung.");
                transaction.Commit();
                return false;
            }

            _ticketRepository.MarkAsUsed(connection, transaction, ticketId.Value);

            InsertTicketCheck(connection, transaction, ticketId, ticketCode, checkedByUserId, "Valid", "Da xac nhan khach vao rap.");
            transaction.Commit();
            return true;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    public IReadOnlyList<TicketCheck> GetRecentChecks(int take = 30)
    {
        const string sql = """
            SELECT TOP (@Take)
                TicketCheckId,
                TicketId,
                TicketCodeInput,
                CheckedByUserId,
                CheckResult,
                Note,
                CheckedAt
            FROM dbo.TicketChecks
            ORDER BY CheckedAt DESC;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@Take", take));
        var checks = new List<TicketCheck>();

        foreach (DataRow row in table.Rows)
        {
            checks.Add(new TicketCheck
            {
                TicketCheckId = Convert.ToInt32(row["TicketCheckId"]),
                TicketId = row["TicketId"] == DBNull.Value ? null : Convert.ToInt32(row["TicketId"]),
                TicketCodeInput = row["TicketCodeInput"].ToString() ?? "",
                CheckedByUserId = Convert.ToInt32(row["CheckedByUserId"]),
                CheckResult = row["CheckResult"].ToString() ?? "",
                Note = row["Note"].ToString() ?? "",
                CheckedAt = Convert.ToDateTime(row["CheckedAt"])
            });
        }

        return checks;
    }

    private static void InsertTicketCheck(SqlConnection connection, SqlTransaction transaction, int? ticketId, string ticketCodeInput, int checkedByUserId, string result, string note)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.TicketChecks
            (
                TicketId,
                TicketCodeInput,
                CheckedByUserId,
                CheckResult,
                Note
            )
            VALUES
            (
                @TicketId,
                @TicketCodeInput,
                @CheckedByUserId,
                @CheckResult,
                @Note
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", (object?)ticketId ?? DBNull.Value);
        command.Parameters.AddWithValue("@TicketCodeInput", ticketCodeInput);
        command.Parameters.AddWithValue("@CheckedByUserId", checkedByUserId);
        command.Parameters.AddWithValue("@CheckResult", result);
        command.Parameters.AddWithValue("@Note", note);
        command.ExecuteNonQuery();
    }

    private static string ToCheckResult(string ticketStatus)
    {
        return ticketStatus switch
        {
            "Used" => "Used",
            "Cancelled" or "Canceled" => "Cancelled",
            _ => "Valid"
        };
    }
}
