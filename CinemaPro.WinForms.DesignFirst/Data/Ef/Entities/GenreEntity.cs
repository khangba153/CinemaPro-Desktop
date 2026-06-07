namespace CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;

public sealed class GenreEntity
{
    public int GenreId { get; set; }
    public string GenreCode { get; set; } = "";
    public string GenreName { get; set; } = "";
    public string GenreStatus { get; set; } = "";

    public List<MovieEntity> Movies { get; } = [];
}
