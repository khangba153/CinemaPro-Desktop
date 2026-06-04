using System.Data.SqlClient;
using CinemaPro.WinForms.DesignFirst.Data;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public class RoomRepository
{
    public List<Room> GetRooms()
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

        var rooms = new List<Room>();

        using var connection =
            new SqlConnection(AppDbConfig.ConnectionString);

        using var command =
            new SqlCommand(sql, connection);

        connection.Open();

        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            rooms.Add(new Room
            {
                RoomId = Convert.ToInt32(reader["RoomId"]),
                RoomCode = reader["RoomCode"].ToString() ?? "",
                RoomName = reader["RoomName"].ToString() ?? "",
                RoomType = reader["RoomType"].ToString() ?? "",
                SeatRowCount = Convert.ToInt32(reader["SeatRowCount"]),
                SeatsPerRow = Convert.ToInt32(reader["SeatsPerRow"]),
                RoomStatus = reader["RoomStatus"].ToString() ?? "",
                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                UpdatedAt = reader["UpdatedAt"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(reader["UpdatedAt"])
            });
        }

        return rooms;
    }
}