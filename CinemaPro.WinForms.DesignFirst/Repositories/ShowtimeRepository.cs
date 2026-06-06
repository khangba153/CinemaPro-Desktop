namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class ShowtimeRepository
{
    public IReadOnlyList<ShowtimeRow> GetShowtimes()
    {
        const string sql = """
            SELECT
                Showtime.ShowtimeId,
                Showtime.MovieId,
                Movie.MovieTitle,
                Showtime.RoomId,
                Room.RoomName,
                Showtime.StartAt,
                Showtime.EndAt,
                Showtime.BasePrice,
                Showtime.ShowtimeFormat,
                Showtime.ShowtimeStatus
            FROM dbo.Showtimes AS Showtime
            INNER JOIN dbo.Movies AS Movie
                ON Movie.MovieId = Showtime.MovieId
            INNER JOIN dbo.Rooms AS Room
                ON Room.RoomId = Showtime.RoomId
            WHERE Showtime.ShowtimeStatus <> N'Cancelled'
            ORDER BY Showtime.StartAt;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var showtimes = new List<ShowtimeRow>();

        foreach (DataRow row in table.Rows)
        {
            var startAt = Convert.ToDateTime(row["StartAt"]);
            var endAt = Convert.ToDateTime(row["EndAt"]);

            showtimes.Add(new ShowtimeRow
            {
                ShowtimeId = row["ShowtimeId"].ToString() ?? "",
                MovieId = row["MovieId"].ToString() ?? "",
                MovieTitle = row["MovieTitle"].ToString() ?? "",
                RoomId = row["RoomId"].ToString() ?? "",
                RoomName = row["RoomName"].ToString() ?? "",
                Date = startAt.Date,
                StartTime = startAt.TimeOfDay,
                EndTime = endAt.TimeOfDay,
                Price = Convert.ToDecimal(row["BasePrice"]),
                Format = row["ShowtimeFormat"].ToString() ?? "",
                Status = row["ShowtimeStatus"].ToString() ?? ""
            });
        }

        return showtimes;
    }

    public string GetNextShowtimeCode()
    {
        const string sql = """
            SELECT ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(ShowtimeCode, 3, 10))), 0) + 1
            FROM dbo.Showtimes
            WHERE ShowtimeCode LIKE N'SC%';
            """;

        var number = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql));
        return "SC" + number.ToString("000");
    }

    public bool HasRoomConflict(int roomId, DateTime startAt, DateTime endAt, int? exceptShowtimeId = null)
    {
        const string sql = """
            SELECT COUNT(*)
            FROM dbo.Showtimes
            WHERE RoomId = @RoomId
                AND ShowtimeStatus <> N'Cancelled'
                AND (@ExceptShowtimeId IS NULL OR ShowtimeId <> @ExceptShowtimeId)
                AND StartAt < @EndAt
                AND EndAt > @StartAt;
            """;

        var count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@StartAt", startAt),
            new SqlParameter("@EndAt", endAt),
            new SqlParameter("@ExceptShowtimeId", (object?)exceptShowtimeId ?? DBNull.Value)));

        return count > 0;
    }

    public void Insert(int movieId, int roomId, DateTime startAt, DateTime endAt, decimal price, string format, string status)
    {
        const string sql = """
            INSERT INTO dbo.Showtimes
            (
                ShowtimeCode,
                MovieId,
                RoomId,
                StartAt,
                EndAt,
                BasePrice,
                ShowtimeFormat,
                ShowtimeStatus
            )
            VALUES
            (
                @ShowtimeCode,
                @MovieId,
                @RoomId,
                @StartAt,
                @EndAt,
                @BasePrice,
                @ShowtimeFormat,
                @ShowtimeStatus
            );
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@ShowtimeCode", GetNextShowtimeCode()),
            new SqlParameter("@MovieId", movieId),
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@StartAt", startAt),
            new SqlParameter("@EndAt", endAt),
            new SqlParameter("@BasePrice", price),
            new SqlParameter("@ShowtimeFormat", format),
            new SqlParameter("@ShowtimeStatus", status));
    }

    public void Update(int showtimeId, int movieId, int roomId, DateTime startAt, DateTime endAt, decimal price, string format, string status)
    {
        const string sql = """
            UPDATE dbo.Showtimes
            SET
                MovieId = @MovieId,
                RoomId = @RoomId,
                StartAt = @StartAt,
                EndAt = @EndAt,
                BasePrice = @BasePrice,
                ShowtimeFormat = @ShowtimeFormat,
                ShowtimeStatus = @ShowtimeStatus,
                UpdatedAt = SYSDATETIME()
            WHERE ShowtimeId = @ShowtimeId;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@ShowtimeId", showtimeId),
            new SqlParameter("@MovieId", movieId),
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@StartAt", startAt),
            new SqlParameter("@EndAt", endAt),
            new SqlParameter("@BasePrice", price),
            new SqlParameter("@ShowtimeFormat", format),
            new SqlParameter("@ShowtimeStatus", status));
    }

    public void Cancel(int showtimeId)
    {
        const string sql = """
            UPDATE dbo.Showtimes
            SET
                ShowtimeStatus = N'Cancelled',
                UpdatedAt = SYSDATETIME()
            WHERE ShowtimeId = @ShowtimeId;
            """;

        DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@ShowtimeId", showtimeId));
    }
}
