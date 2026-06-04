namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class TicketRepository
{
    public IReadOnlyList<TicketRow> GetSoldTickets()
    {
        const string sql = """
            SELECT
                TicketCode,
                MovieTitle,
                ShowtimeText,
                RoomName,
                SeatCodes,
                TotalAmount,
                PaymentMethod,
                TicketStatus,
                SoldAt,
                SoldBy
            FROM dbo.v_SoldTickets
            ORDER BY SoldAt DESC;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var tickets = new List<TicketRow>();

        foreach (DataRow row in table.Rows)
        {
            tickets.Add(new TicketRow
            {
                TicketCode = row["TicketCode"].ToString() ?? "",
                MovieTitle = row["MovieTitle"].ToString() ?? "",
                ShowtimeText = row["ShowtimeText"].ToString() ?? "",
                RoomName = row["RoomName"].ToString() ?? "",
                Seats = row["SeatCodes"].ToString() ?? "",
                TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                PaymentMethod = row["PaymentMethod"].ToString() ?? "",
                Status = row["TicketStatus"].ToString() ?? "",
                SoldAt = Convert.ToDateTime(row["SoldAt"]),
                StaffName = row["SoldBy"].ToString() ?? ""
            });
        }

        return tickets;
    }

    public TicketRow? FindByCode(string ticketCode)
    {
        return GetSoldTickets().FirstOrDefault(ticket =>
            string.Equals(ticket.TicketCode, ticketCode.Trim(), StringComparison.OrdinalIgnoreCase));
    }
}
