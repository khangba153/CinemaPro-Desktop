namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class TicketCheckRepository
{
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
}
