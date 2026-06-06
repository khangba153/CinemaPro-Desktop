using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class GenreRepository
{
    public IReadOnlyList<Genre> GetActiveGenres()
    {
        const string sql = """
            SELECT
                GenreId,
                GenreCode,
                GenreName,
                GenreStatus
            FROM dbo.Genres
            WHERE GenreStatus = N'Active'
            ORDER BY GenreName;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var genres = new List<Genre>();

        foreach (DataRow row in table.Rows)
        {
            genres.Add(new Genre
            {
                GenreId = Convert.ToInt32(row["GenreId"]),
                GenreCode = row["GenreCode"].ToString() ?? "",
                GenreName = row["GenreName"].ToString() ?? "",
                GenreStatus = row["GenreStatus"].ToString() ?? ""
            });
        }

        return genres;
    }
}