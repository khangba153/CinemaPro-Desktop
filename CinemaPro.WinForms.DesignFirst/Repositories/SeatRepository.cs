namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class SeatRepository
{
    public IReadOnlyList<SeatInfo> GetSeats(string roomId)
    {
        const string sql = """
            SELECT
                Seat.RoomId,
                Seat.SeatCode,
                Seat.RowLabel,
                Seat.SeatNumber,
                Seat.SeatStatus
            FROM dbo.Seats AS Seat
            WHERE Seat.RoomId = @RoomId
            ORDER BY Seat.RowLabel, Seat.SeatNumber;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@RoomId", ToInt(roomId)));
        return MapSeats(table, null);
    }

    public IReadOnlyList<SeatInfo> GetSeatsForShowtime(string showtimeId)
    {
        const string sql = """
            SELECT
                Seat.RoomId,
                Seat.SeatCode,
                Seat.RowLabel,
                Seat.SeatNumber,
                Seat.SeatStatus,
                CASE
                    WHEN EXISTS
                    (
                        SELECT 1
                        FROM dbo.TicketDetails AS TicketDetail
                        INNER JOIN dbo.Tickets AS Ticket
                            ON Ticket.TicketId = TicketDetail.TicketId
                        WHERE TicketDetail.ShowtimeId = @ShowtimeId
                            AND TicketDetail.SeatId = Seat.SeatId
                            AND TicketDetail.TicketDetailStatus = N'Active'
                            AND Ticket.TicketStatus <> N'Cancelled'
                    )
                    THEN 1
                    ELSE 0
                END AS IsSold
            FROM dbo.Seats AS Seat
            INNER JOIN dbo.Showtimes AS Showtime
                ON Showtime.RoomId = Seat.RoomId
            WHERE Showtime.ShowtimeId = @ShowtimeId
            ORDER BY Seat.RowLabel, Seat.SeatNumber;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@ShowtimeId", ToInt(showtimeId)));
        return MapSeats(table, "IsSold");
    }

    public void UpdateSeatStatus(int roomId, string seatCode, string status)
    {
        const string sql = """
            UPDATE dbo.Seats
            SET SeatStatus = @SeatStatus
            WHERE RoomId = @RoomId
                AND SeatCode = @SeatCode;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@SeatCode", seatCode),
            new SqlParameter("@SeatStatus", status));
    }

    public int GetSeatId(SqlConnection connection, SqlTransaction transaction, int roomId, string seatCode)
    {
        using var command = new SqlCommand("""
            SELECT SeatId
            FROM dbo.Seats
            WHERE RoomId = @RoomId
                AND SeatCode = @SeatCode;
            """, connection, transaction);

        command.Parameters.AddWithValue("@RoomId", roomId);
        command.Parameters.AddWithValue("@SeatCode", seatCode);

        var result = command.ExecuteScalar();
        if (result is not null)
        {
            return Convert.ToInt32(result);
        }

        throw new InvalidOperationException($"Khong tim thay ghe {seatCode} trong phong dang chon.");
    }

    private static IReadOnlyList<SeatInfo> MapSeats(DataTable table, string? soldColumnName)
    {
        var seats = new List<SeatInfo>();

        foreach (DataRow row in table.Rows)
        {
            var seatStatus = row["SeatStatus"].ToString() ?? "";
            var isSold = soldColumnName is not null && Convert.ToInt32(row[soldColumnName]) == 1;

            seats.Add(new SeatInfo
            {
                RoomId = row["RoomId"].ToString() ?? "",
                SeatCode = row["SeatCode"].ToString() ?? "",
                RowIndex = RowLabelToIndex(row["RowLabel"].ToString() ?? "A"),
                ColumnIndex = Convert.ToInt32(row["SeatNumber"]) - 1,
                Status = isSold
                    ? SeatStatus.Sold
                    : seatStatus == "Maintenance" ? SeatStatus.Maintenance : SeatStatus.Available
            });
        }

        return seats;
    }

    private static int ToInt(string value)
    {
        return int.TryParse(value, out var number) ? number : 0;
    }

    private static int RowLabelToIndex(string rowLabel)
    {
        var value = 0;

        foreach (var character in rowLabel.ToUpperInvariant())
        {
            if (character < 'A' || character > 'Z')
            {
                continue;
            }

            value = value * 26 + character - 'A' + 1;
        }

        return Math.Max(0, value - 1);
    }

}
