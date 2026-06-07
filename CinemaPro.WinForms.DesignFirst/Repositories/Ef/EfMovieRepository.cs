using CinemaPro.WinForms.DesignFirst.Data.Ef;
using CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.WinForms.DesignFirst.Repositories.Ef;

public sealed class EfMovieRepository
{
    public IReadOnlyList<MovieRow> GetMovies()
    {
        using var db = new CinemaProDbContext();

        return db.Movies
            .AsNoTracking()
            .Include(movie => movie.Genre)
            .OrderBy(movie => movie.MovieTitle)
            .Select(movie => new MovieRow
            {
                MovieId = movie.MovieId.ToString(),
                Title = movie.MovieTitle,
                Genre = movie.Genre == null ? "" : movie.Genre.GenreName,
                DurationMinutes = movie.DurationMinutes,
                AgeRating = movie.AgeRating,
                Director = movie.Director ?? "",
                Status = movie.MovieStatus
            })
            .ToList();
    }

    public IReadOnlyList<string> GetGenreNames()
    {
        using var db = new CinemaProDbContext();

        return db.Genres
            .AsNoTracking()
            .Where(genre => genre.GenreStatus == "Active")
            .OrderBy(genre => genre.GenreName)
            .Select(genre => genre.GenreName)
            .ToList();
    }

    public void Insert(string title, string genreName, int durationMinutes, string ageRating, string director, string status)
    {
        using var db = new CinemaProDbContext();

        db.Movies.Add(new MovieEntity
        {
            MovieCode = GetNextMovieCode(db),
            MovieTitle = title,
            GenreId = GetGenreIdByName(db, genreName),
            DurationMinutes = durationMinutes,
            AgeRating = ageRating,
            Director = string.IsNullOrWhiteSpace(director) ? null : director,
            MovieStatus = status
        });

        db.SaveChanges();
    }

    public void Update(int movieId, string title, string genreName, int durationMinutes, string ageRating, string director, string status)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Movies.FirstOrDefault(movie => movie.MovieId == movieId);
        if (entity is null)
        {
            return;
        }

        entity.MovieTitle = title;
        entity.GenreId = GetGenreIdByName(db, genreName);
        entity.DurationMinutes = durationMinutes;
        entity.AgeRating = ageRating;
        entity.Director = string.IsNullOrWhiteSpace(director) ? null : director;
        entity.MovieStatus = status;
        entity.UpdatedAt = DateTime.Now;

        db.SaveChanges();
    }

    public void UpdateStatus(int movieId, string status)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Movies.FirstOrDefault(movie => movie.MovieId == movieId);
        if (entity is null)
        {
            return;
        }

        entity.MovieStatus = status;
        entity.UpdatedAt = DateTime.Now;

        db.SaveChanges();
    }

    private static string GetNextMovieCode(CinemaProDbContext db)
    {
        var currentMax = db.Movies
            .AsNoTracking()
            .Where(movie => movie.MovieCode.StartsWith("MV"))
            .Select(movie => movie.MovieCode.Substring(2))
            .AsEnumerable()
            .Select(text => int.TryParse(text, out var number) ? number : 0)
            .DefaultIfEmpty(0)
            .Max();

        return "MV" + (currentMax + 1).ToString("000");
    }

    private static int GetGenreIdByName(CinemaProDbContext db, string genreName)
    {
        var genreId = db.Genres
            .AsNoTracking()
            .Where(genre => genre.GenreName == genreName)
            .Select(genre => (int?)genre.GenreId)
            .FirstOrDefault();

        if (genreId is not null)
        {
            return genreId.Value;
        }

        return db.Genres
            .AsNoTracking()
            .OrderBy(genre => genre.GenreId)
            .Select(genre => genre.GenreId)
            .First();
    }
}
