namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Payment
{
    public int PaymentId { get; set; }
    public string PaymentCode { get; set; } = "";
    public int TicketId { get; set; }
    public string PaymentMethod { get; set; } = "";
    public decimal Amount { get; set; }
    public string Status { get; set; } = "";
    public string TransactionRef { get; set; } = "";
    public DateTime? PaidAt { get; set; }
    public DateTime CreatedAt { get; set; }
}
