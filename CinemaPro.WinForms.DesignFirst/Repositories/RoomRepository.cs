using System.Data;
using System.Data.SqlClient;
using CinemaPro.WinForms.DesignFirst.Data;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Repositories;

public class RoomRepository
{
    public List<RoomRow> GetRooms()
    {
        const string sql = """
            SELECT RoomId, RoomCode, RoomName, RoomType,
                   SeatRowCount, SeatsPerRow, RoomStatus
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

    public RoomRow? GetById(string roomId)
    {
        const string sql = """
            SELECT RoomId, RoomName, RoomType,
                   SeatRowCount, SeatsPerRow, RoomStatus
            FROM dbo.Rooms
            WHERE RoomId = @RoomId;
        """;

        var table = DatabaseHelper.ExecuteQuery(
            sql,
            new SqlParameter("@RoomId", roomId)
        );

        if (table.Rows.Count == 0)
            return null;

        var row = table.Rows[0];

        return new RoomRow
        {
            RoomId = row["RoomId"].ToString() ?? "",
            RoomName = row["RoomName"].ToString() ?? "",
            RoomType = row["RoomType"].ToString() ?? "",
            Rows = Convert.ToInt32(row["SeatRowCount"]),
            SeatsPerRow = Convert.ToInt32(row["SeatsPerRow"]),
            Status = row["RoomStatus"].ToString() ?? ""
        };
    }

    public bool ExistsByName(string roomName)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM dbo.Rooms
            WHERE RoomName = @RoomName;
        """;

        var result = DatabaseHelper.ExecuteScalar(
            sql,
            new SqlParameter("@RoomName", roomName.Trim())
        );

        return Convert.ToInt32(result) > 0;
    }

    public bool ExistsByNameExceptId(string roomName, string roomId)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM dbo.Rooms
            WHERE RoomName = @RoomName
              AND RoomId <> @RoomId;
        """;

        var result = DatabaseHelper.ExecuteScalar(
            sql,
            new SqlParameter("@RoomName", roomName.Trim()),
            new SqlParameter("@RoomId", roomId)
        );

        return Convert.ToInt32(result) > 0;
    }

    public void Insert(string roomName, string roomType, int rows, int seatsPerRow, string status)
    {
        const string sql = """
            INSERT INTO dbo.Rooms
            (RoomCode, RoomName, RoomType, SeatRowCount, SeatsPerRow, RoomStatus)
            VALUES
            (@RoomCode, @RoomName, @RoomType, @SeatRowCount, @SeatsPerRow, @RoomStatus);
        """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomCode", GenerateRoomCode()),
            new SqlParameter("@RoomName", roomName),
            new SqlParameter("@RoomType", roomType),
            new SqlParameter("@SeatRowCount", rows),
            new SqlParameter("@SeatsPerRow", seatsPerRow),
            new SqlParameter("@RoomStatus", status)
        );
    }

    public void Update(string roomId, string roomName, string roomType, string status)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomName = @RoomName,
                RoomType = @RoomType,
                RoomStatus = @RoomStatus,
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@RoomName", roomName),
            new SqlParameter("@RoomType", roomType),
            new SqlParameter("@RoomStatus", status)
        );
    }

    public void SetMaintenance(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Maintenance',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId)
        );
    }

    public void SetActive(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Active',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId)
        );
    }

    public string GenerateRoomCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(RoomCode, 2, 10))), 0) + 1
            FROM dbo.Rooms
            WHERE RoomCode LIKE N'R%';
        """;

        var result = DatabaseHelper.ExecuteScalar(sql);
        var number = Convert.ToInt32(result);

        return "R" + number.ToString("000");
    }
}