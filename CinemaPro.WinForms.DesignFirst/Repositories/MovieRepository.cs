namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class MovieRepository
{
    public IReadOnlyList<string> GetGenreNames()
    {
        const string sql = """
            SELECT GenreName
            FROM dbo.Genres
            WHERE GenreStatus = N'Active'
            ORDER BY GenreName;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        return table.Rows.Cast<DataRow>().Select(row => row["GenreName"].ToString() ?? "").Where(item => item != "").ToList();
    }

    public string GetNextMovieCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(MovieCode, 3, 10))), 0) + 1
            FROM dbo.Movies
            WHERE MovieCode LIKE N'MV%';
            """;

        var number = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql));
        return "MV" + number.ToString("000");
    }

    public int GetGenreIdByName(string genreName)
    {
        const string sql = """
            SELECT TOP 1 GenreId
            FROM dbo.Genres
            WHERE GenreName = @GenreName;
            """;

        var result = DatabaseHelper.ExecuteScalar(sql, new SqlParameter("@GenreName", genreName));
        if (result is not null)
        {
            return Convert.ToInt32(result);
        }

        const string fallbackSql = """
            SELECT TOP 1 GenreId
            FROM dbo.Genres
            ORDER BY GenreId;
            """;

        return Convert.ToInt32(DatabaseHelper.ExecuteScalar(fallbackSql));
    }

    public void Insert(string title, string genreName, int durationMinutes, string ageRating, string director, string status)
    {
        const string sql = """
            INSERT INTO dbo.Movies
            (
                MovieCode,
                MovieTitle,
                GenreId,
                DurationMinutes,
                AgeRating,
                Director,
                MovieStatus
            )
            VALUES
            (
                @MovieCode,
                @MovieTitle,
                @GenreId,
                @DurationMinutes,
                @AgeRating,
                @Director,
                @MovieStatus
            );
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@MovieCode", GetNextMovieCode()),
            new SqlParameter("@MovieTitle", title),
            new SqlParameter("@GenreId", GetGenreIdByName(genreName)),
            new SqlParameter("@DurationMinutes", durationMinutes),
            new SqlParameter("@AgeRating", ageRating),
            new SqlParameter("@Director", director),
            new SqlParameter("@MovieStatus", status));
    }

    public void Update(int movieId, string title, string genreName, int durationMinutes, string ageRating, string director, string status)
    {
        const string sql = """
            UPDATE dbo.Movies
            SET
                MovieTitle = @MovieTitle,
                GenreId = @GenreId,
                DurationMinutes = @DurationMinutes,
                AgeRating = @AgeRating,
                Director = @Director,
                MovieStatus = @MovieStatus,
                UpdatedAt = SYSDATETIME()
            WHERE MovieId = @MovieId;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@MovieId", movieId),
            new SqlParameter("@MovieTitle", title),
            new SqlParameter("@GenreId", GetGenreIdByName(genreName)),
            new SqlParameter("@DurationMinutes", durationMinutes),
            new SqlParameter("@AgeRating", ageRating),
            new SqlParameter("@Director", director),
            new SqlParameter("@MovieStatus", status));
    }

    public void Stop(int movieId)
    {
        const string sql = """
            UPDATE dbo.Movies
            SET
                MovieStatus = N'Stopped',
                UpdatedAt = SYSDATETIME()
            WHERE MovieId = @MovieId;
            """;

        DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@MovieId", movieId));
    }
}
