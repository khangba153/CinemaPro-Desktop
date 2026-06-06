namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class SeatLayoutRepository
{
    public void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            UpdateRoomSize(connection, transaction, roomId, rowCount, columnCount);
            UpsertSeats(connection, transaction, roomId, seats);
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    private static void UpdateRoomSize(SqlConnection connection, SqlTransaction transaction, string roomId, int rowCount, int columnCount)
    {
        using var command = new SqlCommand("""
            UPDATE dbo.Rooms
            SET
                SeatRowCount = @SeatRowCount,
                SeatsPerRow = @SeatsPerRow,
                UpdatedAt = SYSDATETIME()
            WHERE RoomId = @RoomId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@RoomId", ToInt(roomId));
        command.Parameters.AddWithValue("@SeatRowCount", rowCount);
        command.Parameters.AddWithValue("@SeatsPerRow", columnCount);
        command.ExecuteNonQuery();
    }

    private static void UpsertSeats(SqlConnection connection, SqlTransaction transaction, string roomId, IReadOnlyList<SeatInfo> seats)
    {
        foreach (var seat in seats.OrderBy(item => item.RowIndex).ThenBy(item => item.ColumnIndex))
        {
            using var command = new SqlCommand("""
                IF EXISTS
                (
                    SELECT 1
                    FROM dbo.Seats
                    WHERE RoomId = @RoomId
                        AND SeatCode = @SeatCode
                )
                BEGIN
                    UPDATE dbo.Seats
                    SET
                        RowLabel = @RowLabel,
                        SeatNumber = @SeatNumber,
                        SeatStatus = N'Active'
                    WHERE RoomId = @RoomId
                        AND SeatCode = @SeatCode;
                END
                ELSE
                BEGIN
                    INSERT INTO dbo.Seats
                    (
                        RoomId,
                        SeatCode,
                        RowLabel,
                        SeatNumber,
                        SeatStatus
                    )
                    VALUES
                    (
                        @RoomId,
                        @SeatCode,
                        @RowLabel,
                        @SeatNumber,
                        N'Active'
                    );
                END;
                """, connection, transaction);

            command.Parameters.AddWithValue("@RoomId", ToInt(roomId));
            command.Parameters.AddWithValue("@SeatCode", seat.SeatCode);
            command.Parameters.AddWithValue("@RowLabel", GetRowLabel(seat.RowIndex));
            command.Parameters.AddWithValue("@SeatNumber", ExtractSeatNumber(seat.SeatCode));
            command.ExecuteNonQuery();
        }
    }

    private static int ToInt(string value)
    {
        return int.TryParse(value, out var number) ? number : 0;
    }

    private static string GetRowLabel(int rowIndex)
    {
        var label = "";
        var value = rowIndex;

        do
        {
            label = (char)('A' + value % 26) + label;
            value = value / 26 - 1;
        }
        while (value >= 0);

        return label;
    }

    private static int ExtractSeatNumber(string seatCode)
    {
        var digits = new string(seatCode.Where(char.IsDigit).ToArray());
        return int.TryParse(digits, out var number) ? number : 1;
    }
}
