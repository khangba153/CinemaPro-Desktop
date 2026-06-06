namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class RoomRepository
{
    public IReadOnlyList<RoomRow> GetRooms()
    {
        const string sql = """
            SELECT
                RoomId,
                RoomName,
                RoomType,
                SeatRowCount,
                SeatsPerRow,
                RoomStatus
            FROM dbo.Rooms
            ORDER BY RoomId;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var rooms = new List<RoomRow>();

        foreach (DataRow row in table.Rows)
        {
            rooms.Add(new RoomRow
            {
                RoomId = row["RoomId"].ToString() ?? "",
                RoomName = row["RoomName"].ToString() ?? "",
                RoomType = row["RoomType"].ToString() ?? "",
                Rows = Convert.ToInt32(row["SeatRowCount"]),
                SeatsPerRow = Convert.ToInt32(row["SeatsPerRow"]),
                Status = row["RoomStatus"].ToString() ?? ""
            });
        }

        return rooms;
    }

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
        UpdateStatus(roomId, "Maintenance");
    }

    public void UpdateStatus(int roomId, string status)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET
                RoomStatus = @RoomStatus,
                UpdatedAt = SYSDATETIME()
            WHERE RoomId = @RoomId;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@RoomStatus", status));
    }
}
