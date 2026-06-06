namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class Movie
{
    public int MovieId { get; set; }
    public string MovieCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public int GenreId { get; set; }
    public int DurationMinutes { get; set; }
    public string AgeRating { get; set; } = "";
    public string Director { get; set; } = "";
    public string MovieStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}