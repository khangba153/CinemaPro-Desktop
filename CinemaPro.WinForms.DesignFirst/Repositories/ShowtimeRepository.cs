
using CinemaPro.WinForms.DesignFirst.Data;
using CinemaPro.WinForms.DesignFirst.Models;
using CinemaPro.WinForms.DesignFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CinemaPro.WinForms.DesignFirst.Repositories
{
    public class ShowtimeRepository
    {
        public List<ShowtimeRow> GetAllWithDetails()
        {
            var list = new List<ShowtimeRow>();
            string query = @"SELECT s.ShowtimeId, s.MovieId, m.MovieTitle, s.RoomId, r.RoomName, 
                                    s.StartAt, s.EndAt, s.BasePrice, s.ShowtimeFormat, s.ShowtimeStatus
                             FROM dbo.Showtimes s
                             INNER JOIN dbo.Movies m ON s.MovieId = m.MovieId
                             INNER JOIN dbo.Rooms r ON s.RoomId = r.RoomId
                             ORDER BY s.StartAt DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                DateTime startAt = Convert.ToDateTime(row["StartAt"]);
                DateTime endAt = Convert.ToDateTime(row["EndAt"]);

                list.Add(new ShowtimeRow
                {
                    ShowtimeId = row["ShowtimeId"].ToString(),
                    MovieId = row["MovieId"].ToString(),
                    MovieTitle = row["MovieTitle"].ToString(),
                    RoomId = row["RoomId"].ToString(),
                    RoomName = row["RoomName"].ToString(),
                    Date = startAt.Date,
                    StartTime = startAt.TimeOfDay,
                    EndTime = endAt.TimeOfDay,
                    Price = Convert.ToDecimal(row["BasePrice"]),
                    Format = row["ShowtimeFormat"].ToString(),
                    Status = row["ShowtimeStatus"].ToString()
                });
            }
            return list;
        }

        public List<TodayShowtimeViewModel> GetTodayShowtimes()
        {
            var list = new List<TodayShowtimeViewModel>();
            string query = "SELECT * FROM dbo.v_TodayShowtimes ORDER BY StartAt ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                DateTime startAt = Convert.ToDateTime(row["StartAt"]);
                DateTime endAt = Convert.ToDateTime(row["EndAt"]);

                list.Add(new TodayShowtimeViewModel
                {
                    ShowtimeId = row["ShowtimeId"].ToString(),
                    ShowtimeCode = row["ShowtimeCode"].ToString(),
                    MovieCode = row["MovieCode"].ToString(),
                    MovieTitle = row["MovieTitle"].ToString(),
                    RoomCode = row["RoomCode"].ToString(),
                    RoomName = row["RoomName"].ToString(),
                    Date = startAt.Date,
                    StartTime = startAt.TimeOfDay,
                    EndTime = endAt.TimeOfDay,
                    Price = Convert.ToDecimal(row["BasePrice"]),
                    Format = row["ShowtimeFormat"].ToString(),
                    Status = row["ShowtimeStatus"].ToString(),
                    SoldSeatCount = Convert.ToInt32(row["SoldSeatCount"])
                });
            }
            return list;
        }

        public bool IsRoomConflicting(int roomId, DateTime start, DateTime end, int? excludeShowtimeId = null)
        {
            string query = @"SELECT COUNT(1) 
                             FROM dbo.Showtimes 
                             WHERE RoomId = @RoomId 
                               AND ShowtimeStatus <> 'Cancelled'
                               AND StartAt < @EndAt 
                               AND EndAt > @StartAt";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@RoomId", roomId),
                new SqlParameter("@StartAt", start),
                new SqlParameter("@EndAt", end)
            };

            if (excludeShowtimeId.HasValue)
            {
                query += " AND ShowtimeId <> @ExcludeShowtimeId";
                parameters.Add(new SqlParameter("@ExcludeShowtimeId", excludeShowtimeId.Value));
            }

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters.ToArray()));
            return count > 0;
        }

        public bool Insert(Showtime showtime)
        {
            string query = @"INSERT INTO dbo.Showtimes (ShowtimeCode, MovieId, RoomId, StartAt, EndAt, BasePrice, ShowtimeFormat, ShowtimeStatus, CreatedAt)
                             VALUES (@ShowtimeCode, @MovieId, @RoomId, @StartAt, @EndAt, @BasePrice, @ShowtimeFormat, @ShowtimeStatus, SYSDATETIME())";

            SqlParameter[] parameters = {
                new SqlParameter("@ShowtimeCode", showtime.ShowtimeCode),
                new SqlParameter("@MovieId", showtime.MovieId),
                new SqlParameter("@RoomId", showtime.RoomId),
                new SqlParameter("@StartAt", showtime.StartAt),
                new SqlParameter("@EndAt", showtime.EndAt),
                new SqlParameter("@BasePrice", showtime.BasePrice),
                new SqlParameter("@ShowtimeFormat", showtime.ShowtimeFormat),
                new SqlParameter("@ShowtimeStatus", showtime.ShowtimeStatus)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(Showtime showtime)
        {
            string query = @"UPDATE dbo.Showtimes 
                             SET MovieId = @MovieId, RoomId = @RoomId, StartAt = @StartAt, EndAt = @EndAt, 
                                 BasePrice = @BasePrice, ShowtimeFormat = @ShowtimeFormat, ShowtimeStatus = @ShowtimeStatus, UpdatedAt = SYSDATETIME()
                             WHERE ShowtimeId = @ShowtimeId";

            SqlParameter[] parameters = {
                new SqlParameter("@ShowtimeId", showtime.ShowtimeId),
                new SqlParameter("@MovieId", showtime.MovieId),
                new SqlParameter("@RoomId", showtime.RoomId),
                new SqlParameter("@StartAt", showtime.StartAt),
                new SqlParameter("@EndAt", showtime.EndAt),
                new SqlParameter("@BasePrice", showtime.BasePrice),
                new SqlParameter("@ShowtimeFormat", showtime.ShowtimeFormat),
                new SqlParameter("@ShowtimeStatus", showtime.ShowtimeStatus)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}