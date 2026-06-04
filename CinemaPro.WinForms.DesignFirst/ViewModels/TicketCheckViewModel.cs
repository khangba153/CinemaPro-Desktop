namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class TicketCheckViewModel
{
    public string TicketCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string ShowtimeText { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string Seats { get; set; } = "";
    public string StatusText { get; set; } = "";
    public bool CanConfirmEntry { get; set; }
}
