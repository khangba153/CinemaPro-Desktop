namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class ShowtimeRow
{
    public string ShowtimeId { get; set; } = "";
    public string MovieId { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public decimal Price { get; set; }
    public string Format { get; set; } = "";
    public string Status { get; set; } = "";

    public string DateText => Date.ToString("dd/MM/yyyy");
    public string TimeText => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
    public string DisplayText => $"{TimeText} | {RoomName} | {Format}";
}
