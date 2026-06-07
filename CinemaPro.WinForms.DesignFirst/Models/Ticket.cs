namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Ticket
{
    public int TicketId { get; set; }
    public string TicketCode { get; set; } = "";
    public int ShowtimeId { get; set; }
    public int SoldByUserId { get; set; }
    public string CustomerName { get; set; } = "";
    public string CustomerPhone { get; set; } = "";
    public decimal TotalAmount { get; set; }
    public string TicketStatus { get; set; } = "";
    public string PaymentStatus { get; set; } = "";
    public DateTime SoldAt { get; set; }
    public DateTime? CancelledAt { get; set; }
}
