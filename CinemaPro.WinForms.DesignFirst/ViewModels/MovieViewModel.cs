namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public sealed class MovieRow
{
    public string MovieId { get; set; } = "";
    public string Title { get; set; } = "";
    public string Genre { get; set; } = "";
    public int DurationMinutes { get; set; }
    public string AgeRating { get; set; } = "";
    public string Director { get; set; } = "";
    public string Status { get; set; } = "";
}
