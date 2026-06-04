namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Seat
{
    public int SeatId { get; set; }
    public int RoomId { get; set; }
    public string SeatCode { get; set; } = "";
    public string RowLabel { get; set; } = "";
    public int SeatNumber { get; set; }
    public string SeatStatus { get; set; } = "";
}
