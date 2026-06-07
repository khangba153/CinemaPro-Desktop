namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class ReportRepository
{
    public IReadOnlyList<RevenueRow> GetRevenueRows()
    {
        const string sql = """
            SELECT
                RevenueDate,
                MovieTitle,
                PaymentMethod,
                TicketCount,
                RevenueAmount
            FROM dbo.v_RevenueReport
            ORDER BY RevenueDate DESC, MovieTitle;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var rows = new List<RevenueRow>();

        foreach (DataRow row in table.Rows)
        {
            rows.Add(new RevenueRow
            {
                Date = Convert.ToDateTime(row["RevenueDate"]),
                MovieTitle = row["MovieTitle"].ToString() ?? "",
                PaymentMethod = row["PaymentMethod"].ToString() ?? "",
                TicketCount = Convert.ToInt32(row["TicketCount"]),
                Revenue = Convert.ToDecimal(row["RevenueAmount"])
            });
        }

        return rows;
    }

    public DataTable GetDashboardSummary()
    {
        return DatabaseHelper.ExecuteQuery("SELECT * FROM dbo.v_DashboardSummary;");
    }
}
