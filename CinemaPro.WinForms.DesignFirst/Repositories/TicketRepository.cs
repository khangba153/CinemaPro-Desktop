namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class TicketRepository
{
    private readonly CodeSequenceRepository _codeSequenceRepository = new();
    private readonly PaymentRepository _paymentRepository = new();
    private readonly SeatRepository _seatRepository = new();
    private readonly TicketDetailRepository _ticketDetailRepository = new();
    private readonly UserRepository _userRepository = new();

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
                PaymentMethod = PaymentMethodHelper.ToDisplayText(row["PaymentMethod"].ToString() ?? ""),
                Status = ToAppTicketStatus(row["TicketStatus"].ToString() ?? ""),
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

    public int? GetTicketIdOrNull(SqlConnection connection, SqlTransaction transaction, string ticketCode)
    {
        using var command = new SqlCommand("""
            SELECT TicketId
            FROM dbo.Tickets
            WHERE TicketCode = @TicketCode;
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketCode", ticketCode.Trim());
        var result = command.ExecuteScalar();
        return result is null ? null : Convert.ToInt32(result);
    }

    public string GetTicketStatus(SqlConnection connection, SqlTransaction transaction, int ticketId)
    {
        using var command = new SqlCommand("""
            SELECT TicketStatus
            FROM dbo.Tickets
            WHERE TicketId = @TicketId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", ticketId);
        return command.ExecuteScalar()?.ToString() ?? "";
    }

    public void MarkAsUsed(SqlConnection connection, SqlTransaction transaction, int ticketId)
    {
        using var command = new SqlCommand("""
            UPDATE dbo.Tickets
            SET TicketStatus = N'Used'
            WHERE TicketId = @TicketId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", ticketId);
        command.ExecuteNonQuery();
    }

    public TicketRow CreateTicket(PaymentSummary summary, string staffName)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            var ticketCode = _codeSequenceRepository.GetNextCode(connection, transaction, "dbo.Tickets", "TicketCode", "TK", 6);
            var paymentCode = _codeSequenceRepository.GetNextCode(connection, transaction, "dbo.Payments", "PaymentCode", "PM", 6);
            var soldByUserId = _userRepository.GetCurrentSessionUserId(connection, transaction);
            var paymentMethod = PaymentMethodHelper.ToDatabaseValue(summary.PaymentMethod);
            var showtimeId = ToInt(summary.ShowtimeId);

            var ticketId = InsertTicket(connection, transaction, ticketCode, showtimeId, soldByUserId, summary.TotalAmount);

            foreach (var seatCode in summary.Seats)
            {
                var seatId = _seatRepository.GetSeatId(connection, transaction, ToInt(summary.RoomId), seatCode);
                _ticketDetailRepository.Insert(connection, transaction, ticketId, showtimeId, seatId, summary.TotalAmount / summary.Seats.Count);
            }

            _paymentRepository.InsertSuccessfulPayment(connection, transaction, paymentCode, ticketId, paymentMethod, summary.TotalAmount);
            transaction.Commit();

            return FindByCode(ticketCode) ?? new TicketRow
            {
                TicketCode = ticketCode,
                MovieTitle = summary.MovieTitle,
                ShowtimeText = summary.ShowtimeText,
                RoomName = summary.RoomName,
                Seats = string.Join(", ", summary.Seats),
                TotalAmount = summary.TotalAmount,
                PaymentMethod = summary.PaymentMethod,
                Status = "Unused",
                SoldAt = DateTime.Now,
                StaffName = staffName
            };
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    private static int InsertTicket(SqlConnection connection, SqlTransaction transaction, string ticketCode, int showtimeId, int soldByUserId, decimal totalAmount)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.Tickets
            (
                TicketCode,
                ShowtimeId,
                SoldByUserId,
                CustomerName,
                TotalAmount,
                TicketStatus,
                PaymentStatus
            )
            VALUES
            (
                @TicketCode,
                @ShowtimeId,
                @SoldByUserId,
                N'Khach le',
                @TotalAmount,
                N'Unused',
                N'Paid'
            );

            SELECT CONVERT(INT, SCOPE_IDENTITY());
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketCode", ticketCode);
        command.Parameters.AddWithValue("@ShowtimeId", showtimeId);
        command.Parameters.AddWithValue("@SoldByUserId", soldByUserId);
        command.Parameters.AddWithValue("@TotalAmount", totalAmount);

        return Convert.ToInt32(command.ExecuteScalar());
    }

    private static int ToInt(string value)
    {
        return int.TryParse(value, out var number) ? number : 0;
    }

    private static string ToAppTicketStatus(string ticketStatus)
    {
        return ticketStatus == "Cancelled" ? "Canceled" : ticketStatus;
    }
}
