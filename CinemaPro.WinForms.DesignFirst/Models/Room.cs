namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Room
{
    public int RoomId { get; set; }
    public string RoomCode { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string RoomType { get; set; } = "";
    public int SeatRowCount { get; set; }
    public int SeatsPerRow { get; set; }
    public string RoomStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}