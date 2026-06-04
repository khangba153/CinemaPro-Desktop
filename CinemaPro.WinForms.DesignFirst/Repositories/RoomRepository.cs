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
}