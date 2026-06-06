namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Showtime
{
    public int ShowtimeId { get; set; }
    public string ShowtimeCode { get; set; } = "";
    public int MovieId { get; set; }
    public int RoomId { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public decimal BasePrice { get; set; }
    public string ShowtimeFormat { get; set; } = "";
    public string ShowtimeStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
