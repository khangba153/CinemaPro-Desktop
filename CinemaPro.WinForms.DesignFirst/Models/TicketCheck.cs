namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class TicketCheck
{
    public int TicketCheckId { get; set; }
    public int? TicketId { get; set; }
    public string TicketCodeInput { get; set; } = "";
    public int CheckedByUserId { get; set; }
    public string CheckResult { get; set; } = "";
    public string Note { get; set; } = "";
    public DateTime CheckedAt { get; set; }
}
