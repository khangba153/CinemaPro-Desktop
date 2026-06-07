namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class TicketDetailRepository
{
    public void Insert(SqlConnection connection, SqlTransaction transaction, int ticketId, int showtimeId, int seatId, decimal unitPrice)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.TicketDetails
            (
                TicketId,
                ShowtimeId,
                SeatId,
                UnitPrice,
                TicketDetailStatus
            )
            VALUES
            (
                @TicketId,
                @ShowtimeId,
                @SeatId,
                @UnitPrice,
                N'Active'
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", ticketId);
        command.Parameters.AddWithValue("@ShowtimeId", showtimeId);
        command.Parameters.AddWithValue("@SeatId", seatId);
        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
        command.ExecuteNonQuery();
    }
}
