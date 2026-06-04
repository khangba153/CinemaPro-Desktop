using System.Data.SqlClient;
using CinemaPro.WinForms.DesignFirst.Data;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public class RoomRepository
{
    public List<RoomRow> GetRooms()
    {
        const string sql = """
            SELECT
                RoomId,
                RoomCode,
                RoomName,
                RoomType,
                SeatRowCount,
                SeatsPerRow,
                RoomStatus,
                CreatedAt,
                UpdatedAt
            FROM dbo.Rooms
            ORDER BY RoomId;
            """;

        using var connection = new SqlConnection(AppDbConfig.ConnectionString);
        using var command = new SqlCommand(sql, connection);

        connection.Open();

        using var reader = command.ExecuteReader();

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

    public void Insert(string roomName, string roomType, int rowCount, int seatsPerRow, string status)
    {
        const string sql = """
            INSERT INTO dbo.Rooms (RoomCode, RoomName, RoomType, SeatRowCount, SeatsPerRow, RoomStatus)
            VALUES (@RoomCode, @RoomName, @RoomType, @SeatRowCount, @SeatsPerRow, @RoomStatus);
            """;
        using var connection = new SqlConnection(AppDbConfig.ConnectionString);
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@RoomCode", GenerateRoomCode());
        command.Parameters.AddWithValue("@RoomName", roomName);
        command.Parameters.AddWithValue("@RoomType", roomType);
        command.Parameters.AddWithValue("@SeatRowCount", rowCount);
        command.Parameters.AddWithValue("@SeatsPerRow", seatsPerRow);
        command.Parameters.AddWithValue("@RoomStatus", status);
        connection.Open();
        command.ExecuteNonQuery();
    }

    public string GenerateRoomCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(RoomCode, 2, 10))), 0) + 1
            FROM dbo.Rooms
            WHERE RoomCode LIKE N'R%';
            """;

        var number = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql));
        return "R" + number.ToString("000");
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
        using var connection = new SqlConnection(AppDbConfig.ConnectionString);
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@RoomId", roomId);
        command.Parameters.AddWithValue("@RoomName", roomName);
        command.Parameters.AddWithValue("@RoomType", roomType);
        command.Parameters.AddWithValue("@SeatRowCount", rowCount);
        command.Parameters.AddWithValue("@SeatsPerRow", seatsPerRow);
        command.Parameters.AddWithValue("@RoomStatus", status);
        connection.Open();
        command.ExecuteNonQuery();
    }
    public void SetMaintenance(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Maintenance',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
            """;
        using var connection = new SqlConnection(AppDbConfig.ConnectionString);
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@RoomId", roomId);
        connection.Open();
        command.ExecuteNonQuery();
    }
    public void SetActive(string roomId)
    {
        const string sql = """
            UPDATE dbo.Rooms
            SET RoomStatus = 'Active',
                UpdatedAt = GETDATE()
            WHERE RoomId = @RoomId;
            """;
        using var connection = new SqlConnection(AppDbConfig.ConnectionString);
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@RoomId", roomId);
        connection.Open();
        command.ExecuteNonQuery();
    }
}