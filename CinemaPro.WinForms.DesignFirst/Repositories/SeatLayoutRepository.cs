namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class SeatLayoutRepository
{
    public static void EnsureSeatPositionSchema()
    {
        const string sql = """
            IF COL_LENGTH(N'dbo.Seats', N'PhysicalRowIndex') IS NULL
            BEGIN
                EXEC(N'ALTER TABLE dbo.Seats ADD PhysicalRowIndex INT NULL;');
            END;

            IF COL_LENGTH(N'dbo.Seats', N'PhysicalColumnIndex') IS NULL
            BEGIN
                EXEC(N'ALTER TABLE dbo.Seats ADD PhysicalColumnIndex INT NULL;');
            END;

            EXEC(N'
                UPDATE dbo.Seats
                SET PhysicalRowIndex =
                    CASE
                        WHEN LEN(RowLabel) = 1
                            AND UNICODE(UPPER(RowLabel)) BETWEEN 65 AND 90
                        THEN UNICODE(UPPER(RowLabel)) - 65
                        ELSE 0
                    END
                WHERE PhysicalRowIndex IS NULL;

                UPDATE dbo.Seats
                SET PhysicalColumnIndex = SeatNumber - 1
                WHERE PhysicalColumnIndex IS NULL;
            ');

            IF EXISTS
            (
                SELECT 1
                FROM sys.check_constraints
                WHERE name = N'CK_Seats_SeatStatus'
                    AND parent_object_id = OBJECT_ID(N'dbo.Seats')
                    AND OBJECT_DEFINITION(object_id) NOT LIKE N'%Inactive%'
            )
            BEGIN
                ALTER TABLE dbo.Seats
                DROP CONSTRAINT CK_Seats_SeatStatus;

                ALTER TABLE dbo.Seats
                ADD CONSTRAINT CK_Seats_SeatStatus
                CHECK (SeatStatus IN (N'Active', N'Maintenance', N'Inactive'));
            END;
            """;

        DatabaseHelper.ExecuteNonQuery(sql);
    }

    public void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats)
    {
        EnsureSeatPositionSchema();

        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            UpdateRoomSize(connection, transaction, roomId, rowCount, columnCount);
            DeactivateCurrentSeats(connection, transaction, roomId);
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

    private static void DeactivateCurrentSeats(SqlConnection connection, SqlTransaction transaction, string roomId)
    {
        using var command = new SqlCommand("""
            UPDATE dbo.Seats
            SET SeatStatus = N'Inactive'
            WHERE RoomId = @RoomId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@RoomId", ToInt(roomId));
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
                        PhysicalRowIndex = @PhysicalRowIndex,
                        PhysicalColumnIndex = @PhysicalColumnIndex,
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
                        PhysicalRowIndex,
                        PhysicalColumnIndex,
                        SeatStatus
                    )
                    VALUES
                    (
                        @RoomId,
                        @SeatCode,
                        @RowLabel,
                        @SeatNumber,
                        @PhysicalRowIndex,
                        @PhysicalColumnIndex,
                        N'Active'
                    );
                END;
                """, connection, transaction);

            command.Parameters.AddWithValue("@RoomId", ToInt(roomId));
            command.Parameters.AddWithValue("@SeatCode", seat.SeatCode);
            command.Parameters.AddWithValue("@RowLabel", GetRowLabel(seat.RowIndex));
            command.Parameters.AddWithValue("@SeatNumber", ExtractSeatNumber(seat.SeatCode));
            command.Parameters.AddWithValue("@PhysicalRowIndex", seat.RowIndex);
            command.Parameters.AddWithValue("@PhysicalColumnIndex", seat.ColumnIndex);
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
