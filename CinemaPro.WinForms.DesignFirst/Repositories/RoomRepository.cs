using System.Data.SqlClient;
using CinemaPro.WinForms.DesignFirst.Data;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

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

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        conn.Open();
        using var reader = cmd.ExecuteReader();

        var rooms = new List<RoomRow>();

        while (reader.Read())
        {
            rooms.Add(new RoomRow
            {
                RoomId = reader["RoomId"].ToString() ?? "",
                RoomName = reader["RoomName"].ToString() ?? "",
                RoomType = reader["RoomType"].ToString() ?? "",
                Rows = Convert.ToInt32(reader["SeatRowCount"]),
                SeatsPerRow = Convert.ToInt32(reader["SeatsPerRow"]),
                Status = reader["RoomStatus"].ToString() ?? ""
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

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomId", roomId);

        conn.Open();
        using var reader = cmd.ExecuteReader();

        if (!reader.Read())
            return null;

        return new RoomRow
        {
            RoomId = reader["RoomId"].ToString() ?? "",
            RoomName = reader["RoomName"].ToString() ?? "",
            RoomType = reader["RoomType"].ToString() ?? "",
            Rows = Convert.ToInt32(reader["SeatRowCount"]),
            SeatsPerRow = Convert.ToInt32(reader["SeatsPerRow"]),
            Status = reader["RoomStatus"].ToString() ?? ""
        };
    }

    public bool ExistsByName(string roomName)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM dbo.Rooms
            WHERE RoomName = @RoomName;
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomName", roomName.Trim());

        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }

    public bool ExistsByNameExceptId(string roomName, string roomId)
    {
        const string sql = """
            SELECT COUNT(1)
            FROM dbo.Rooms
            WHERE RoomName = @RoomName
              AND RoomId <> @RoomId;
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomName", roomName.Trim());
        cmd.Parameters.AddWithValue("@RoomId", roomId);

        conn.Open();
        return (int)cmd.ExecuteScalar() > 0;
    }


    public void Insert(string roomName, string roomType, int rowCount, int seatsPerRow, string status)
    {
        const string sql = """
            INSERT INTO dbo.Rooms (RoomCode, RoomName, RoomType, SeatRowCount, SeatsPerRow, RoomStatus)
            VALUES (@RoomCode, @RoomName, @RoomType, @SeatRowCount, @SeatsPerRow, @RoomStatus);
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomCode", GenerateRoomCode());
        cmd.Parameters.AddWithValue("@RoomName", roomName);
        cmd.Parameters.AddWithValue("@RoomType", roomType);
        cmd.Parameters.AddWithValue("@SeatRowCount", rowCount);
        cmd.Parameters.AddWithValue("@SeatsPerRow", seatsPerRow);
        cmd.Parameters.AddWithValue("@RoomStatus", status);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Update(string roomId, string roomName, string roomType, int rowCount, int seatsPerRow, string status)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomName = @RoomName,
                RoomType = @RoomType,
                SeatRowCount = @SeatRowCount,
                SeatsPerRow = @SeatsPerRow,
                RoomStatus = @RoomStatus,
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomId", roomId);
        cmd.Parameters.AddWithValue("@RoomName", roomName);
        cmd.Parameters.AddWithValue("@RoomType", roomType);
        cmd.Parameters.AddWithValue("@SeatRowCount", rowCount);
        cmd.Parameters.AddWithValue("@SeatsPerRow", seatsPerRow);
        cmd.Parameters.AddWithValue("@RoomStatus", status);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void SetMaintenance(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Maintenance',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomId", roomId);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void SetActive(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Active',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@RoomId", roomId);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public string GenerateRoomCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(RoomCode, 2, 10))), 0) + 1
            FROM dbo.Rooms
            WHERE RoomCode LIKE N'R%';
        """;

        using var conn = new SqlConnection(AppDbConfig.ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        conn.Open();
        var result = cmd.ExecuteScalar();

        var number = Convert.ToInt32(result);
        return "R" + number.ToString("000");
    }
}