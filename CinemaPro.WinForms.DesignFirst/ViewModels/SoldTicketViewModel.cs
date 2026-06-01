namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class TicketRow
{
    public string TicketCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string ShowtimeText { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string Seats { get; set; } = "";
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; } = "";
    public string Status { get; set; } = "";
    public DateTime SoldAt { get; set; }
    public string StaffName { get; set; } = "";
}

public sealed class PaymentSummary
{
    public string TicketCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string ShowtimeId { get; set; } = "";
    public string ShowtimeText { get; set; } = "";
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public List<string> Seats { get; set; } = [];
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; } = "";
}
