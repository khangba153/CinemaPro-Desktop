namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class RevenueRow
{
    public DateTime Date { get; set; }
    public string MovieTitle { get; set; } = "";
    public int TicketCount { get; set; }
    public decimal Revenue { get; set; }
    public string PaymentMethod { get; set; } = "";
}
