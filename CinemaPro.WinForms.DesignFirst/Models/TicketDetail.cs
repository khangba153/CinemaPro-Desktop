namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class TicketDetail
{
    public int TicketDetailId { get; set; }
    public int TicketId { get; set; }
    public int ShowtimeId { get; set; }
    public int SeatId { get; set; }
    public decimal UnitPrice { get; set; }
    public string TicketDetailStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}
