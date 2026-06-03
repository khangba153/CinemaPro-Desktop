namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class RoomRepository
{
    public string GetNextRoomCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(RoomCode, 2, 10))), 0) + 1
            FROM dbo.Rooms
            WHERE RoomCode LIKE N'R%';
            """;

        var number = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql));
        return "R" + number.ToString("000");
    }

    public void Insert(string roomName, string roomType, int rowCount, int seatsPerRow, string status)
    {
        const string sql = """
            INSERT INTO dbo.Rooms
            (
                RoomCode,
                RoomName,
                RoomType,
                SeatRowCount,
                SeatsPerRow,
                RoomStatus
            )
            VALUES
            (
                @RoomCode,
                @RoomName,
                @RoomType,
                @SeatRowCount,
                @SeatsPerRow,
                @RoomStatus
            );
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomCode", GetNextRoomCode()),
            new SqlParameter("@RoomName", roomName),
            new SqlParameter("@RoomType", roomType),
            new SqlParameter("@SeatRowCount", rowCount),
            new SqlParameter("@SeatsPerRow", seatsPerRow),
            new SqlParameter("@RoomStatus", status));
    }

    public void Update(int roomId, string roomName, string roomType, int rowCount, int seatsPerRow, string status)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET
                RoomName = @RoomName,
                RoomType = @RoomType,
                SeatRowCount = @SeatRowCount,
                SeatsPerRow = @SeatsPerRow,
                RoomStatus = @RoomStatus,
                UpdatedAt = SYSDATETIME()
            WHERE RoomId = @RoomId;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@RoomName", roomName),
            new SqlParameter("@RoomType", roomType),
            new SqlParameter("@SeatRowCount", rowCount),
            new SqlParameter("@SeatsPerRow", seatsPerRow),
            new SqlParameter("@RoomStatus", status));
    }

    public void SetMaintenance(int roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET
                RoomStatus = N'Maintenance',
                UpdatedAt = SYSDATETIME()
            WHERE RoomId = @RoomId;
            """;

        DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@RoomId", roomId));
    }
}
