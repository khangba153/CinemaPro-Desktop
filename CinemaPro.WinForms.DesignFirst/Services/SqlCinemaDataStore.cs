using System.Data;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class SqlCinemaDataStore : ICinemaDataStore
{
    public AppUser? Authenticate(string username, string password)
    {
        var service = new AuthService();
        return service.Login(username, password, out _);
    }

    public IReadOnlyList<MovieRow> GetMovies()
    {
        const string sql = """
            SELECT
                Movie.MovieId,
                Movie.MovieTitle,
                Genre.GenreName,
                Movie.DurationMinutes,
                Movie.AgeRating,
                Movie.Director,
                Movie.MovieStatus
            FROM dbo.Movies AS Movie
            INNER JOIN dbo.Genres AS Genre
                ON Genre.GenreId = Movie.GenreId
            ORDER BY Movie.MovieTitle;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var movies = new List<MovieRow>();

        foreach (DataRow row in table.Rows)
        {
            movies.Add(new MovieRow
            {
                MovieId = row["MovieId"].ToString() ?? "",
                Title = row["MovieTitle"].ToString() ?? "",
                Genre = row["GenreName"].ToString() ?? "",
                DurationMinutes = Convert.ToInt32(row["DurationMinutes"]),
                AgeRating = row["AgeRating"].ToString() ?? "",
                Director = row["Director"].ToString() ?? "",
                Status = row["MovieStatus"].ToString() ?? ""
            });
        }

        return movies;
    }

    public IReadOnlyList<RoomRow> GetRooms()
    {
        const string sql = """
            SELECT
                RoomId,
                RoomName,
                RoomType,
                SeatRowCount,
                SeatsPerRow,
                RoomStatus
            FROM dbo.Rooms
            ORDER BY RoomId;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var rooms = new List<RoomRow>();

        foreach (DataRow row in table.Rows)
        {
            rooms.Add(new RoomRow
            {
                RoomId = row["RoomId"].ToString() ?? "",
                RoomName = row["RoomName"].ToString() ?? "",
                RoomType = row["RoomType"].ToString() ?? "",
                Rows = Convert.ToInt32(row["SeatRowCount"]),
                SeatsPerRow = Convert.ToInt32(row["SeatsPerRow"]),
                Status = row["RoomStatus"].ToString() ?? ""
            });
        }

        return rooms;
    }

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

    public IReadOnlyList<TicketRow> GetTickets()
    {
        const string sql = """
            SELECT
                TicketCode,
                MovieTitle,
                ShowtimeText,
                RoomName,
                SeatCodes,
                TotalAmount,
                PaymentMethod,
                TicketStatus,
                SoldAt,
                SoldBy
            FROM dbo.v_SoldTickets
            ORDER BY SoldAt DESC;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var tickets = new List<TicketRow>();

        foreach (DataRow row in table.Rows)
        {
            tickets.Add(new TicketRow
            {
                TicketCode = row["TicketCode"].ToString() ?? "",
                MovieTitle = row["MovieTitle"].ToString() ?? "",
                ShowtimeText = row["ShowtimeText"].ToString() ?? "",
                RoomName = row["RoomName"].ToString() ?? "",
                Seats = row["SeatCodes"].ToString() ?? "",
                TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                PaymentMethod = ToDisplayPaymentMethod(row["PaymentMethod"].ToString() ?? ""),
                Status = ToAppTicketStatus(row["TicketStatus"].ToString() ?? ""),
                SoldAt = Convert.ToDateTime(row["SoldAt"]),
                StaffName = row["SoldBy"].ToString() ?? ""
            });
        }

        return tickets;
    }

    public IReadOnlyList<EmployeeRow> GetEmployees()
    {
        var service = new UserService();
        return service.GetEmployees();
    }

    public IReadOnlyList<RevenueRow> GetRevenueRows()
    {
        const string sql = """
            SELECT
                RevenueDate,
                MovieTitle,
                PaymentMethod,
                TicketCount,
                RevenueAmount
            FROM dbo.v_RevenueReport
            ORDER BY RevenueDate DESC, MovieTitle;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql);
        var rows = new List<RevenueRow>();

        foreach (DataRow row in table.Rows)
        {
            rows.Add(new RevenueRow
            {
                Date = Convert.ToDateTime(row["RevenueDate"]),
                MovieTitle = row["MovieTitle"].ToString() ?? "",
                TicketCount = Convert.ToInt32(row["TicketCount"]),
                Revenue = Convert.ToDecimal(row["RevenueAmount"]),
                PaymentMethod = ToDisplayPaymentMethod(row["PaymentMethod"].ToString() ?? "")
            });
        }

        return rows;
    }

    public IReadOnlyList<SeatInfo> GetSeats(string roomId)
    {
        const string sql = """
            SELECT
                Seat.RoomId,
                Seat.SeatCode,
                Seat.RowLabel,
                Seat.SeatNumber,
                Seat.SeatStatus
            FROM dbo.Seats AS Seat
            WHERE Seat.RoomId = @RoomId
            ORDER BY Seat.RowLabel, Seat.SeatNumber;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@RoomId", ToInt(roomId)));
        return MapSeats(table, null);
    }

    public IReadOnlyList<SeatInfo> GetSeatsForShowtime(string showtimeId)
    {
        const string sql = """
            SELECT
                Seat.RoomId,
                Seat.SeatCode,
                Seat.RowLabel,
                Seat.SeatNumber,
                Seat.SeatStatus,
                CASE
                    WHEN EXISTS
                    (
                        SELECT 1
                        FROM dbo.TicketDetails AS TicketDetail
                        INNER JOIN dbo.Tickets AS Ticket
                            ON Ticket.TicketId = TicketDetail.TicketId
                        WHERE TicketDetail.ShowtimeId = @ShowtimeId
                            AND TicketDetail.SeatId = Seat.SeatId
                            AND TicketDetail.TicketDetailStatus = N'Active'
                            AND Ticket.TicketStatus <> N'Cancelled'
                    )
                    THEN 1
                    ELSE 0
                END AS IsSold
            FROM dbo.Seats AS Seat
            INNER JOIN dbo.Showtimes AS Showtime
                ON Showtime.RoomId = Seat.RoomId
            WHERE Showtime.ShowtimeId = @ShowtimeId
            ORDER BY Seat.RowLabel, Seat.SeatNumber;
            """;

        var table = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@ShowtimeId", ToInt(showtimeId)));
        return MapSeats(table, "IsSold");
    }

    public void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            using (var updateRoom = new SqlCommand("""
                UPDATE dbo.Rooms
                SET
                    SeatRowCount = @SeatRowCount,
                    SeatsPerRow = @SeatsPerRow,
                    UpdatedAt = SYSDATETIME()
                WHERE RoomId = @RoomId;
                """, connection, transaction))
            {
                updateRoom.Parameters.AddWithValue("@RoomId", ToInt(roomId));
                updateRoom.Parameters.AddWithValue("@SeatRowCount", rowCount);
                updateRoom.Parameters.AddWithValue("@SeatsPerRow", columnCount);
                updateRoom.ExecuteNonQuery();
            }

            foreach (var seat in seats.OrderBy(item => item.RowIndex).ThenBy(item => item.ColumnIndex))
            {
                using var upsertSeat = new SqlCommand("""
                    IF EXISTS
                    (
                        SELECT 1
                        FROM dbo.Seats
                        WHERE RoomId = @RoomId
                            AND SeatCode = @SeatCode
                    )
                    BEGIN
                        UPDATE dbo.Seats
                        SET
                            RowLabel = @RowLabel,
                            SeatNumber = @SeatNumber,
                            SeatStatus = N'Active'
                        WHERE RoomId = @RoomId
                            AND SeatCode = @SeatCode;
                    END
                    ELSE
                    BEGIN
                        INSERT INTO dbo.Seats
                        (
                            RoomId,
                            SeatCode,
                            RowLabel,
                            SeatNumber,
                            SeatStatus
                        )
                        VALUES
                        (
                            @RoomId,
                            @SeatCode,
                            @RowLabel,
                            @SeatNumber,
                            N'Active'
                        );
                    END;
                    """, connection, transaction);

                var rowLabel = GetRowLabel(seat.RowIndex);
                upsertSeat.Parameters.AddWithValue("@RoomId", ToInt(roomId));
                upsertSeat.Parameters.AddWithValue("@SeatCode", seat.SeatCode);
                upsertSeat.Parameters.AddWithValue("@RowLabel", rowLabel);
                upsertSeat.Parameters.AddWithValue("@SeatNumber", ExtractSeatNumber(seat.SeatCode));
                upsertSeat.ExecuteNonQuery();
            }

            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    public ShowtimeRow? FindShowtime(string showtimeId)
    {
        return GetShowtimes().FirstOrDefault(showtime => showtime.ShowtimeId == showtimeId);
    }

    public TicketRow? FindTicket(string ticketCode)
    {
        return GetTickets().FirstOrDefault(ticket =>
            string.Equals(ticket.TicketCode, ticketCode.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    public TicketRow CreateTicket(PaymentSummary summary, string staffName)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            var ticketCode = GetNextCode(connection, transaction, "dbo.Tickets", "TicketCode", "TK", 6);
            var paymentCode = GetNextCode(connection, transaction, "dbo.Payments", "PaymentCode", "PM", 6);
            var soldByUserId = GetCurrentUserId(connection, transaction);
            var paymentMethod = ToDatabasePaymentMethod(summary.PaymentMethod);
            var showtimeId = ToInt(summary.ShowtimeId);

            var ticketId = InsertTicket(connection, transaction, ticketCode, showtimeId, soldByUserId, summary.TotalAmount);

            foreach (var seatCode in summary.Seats)
            {
                var seatId = GetSeatId(connection, transaction, ToInt(summary.RoomId), seatCode);
                InsertTicketDetail(connection, transaction, ticketId, showtimeId, seatId, summary.TotalAmount / summary.Seats.Count);
            }

            InsertPayment(connection, transaction, paymentCode, ticketId, paymentMethod, summary.TotalAmount);
            transaction.Commit();

            return FindTicket(ticketCode) ?? new TicketRow
            {
                TicketCode = ticketCode,
                MovieTitle = summary.MovieTitle,
                ShowtimeText = summary.ShowtimeText,
                RoomName = summary.RoomName,
                Seats = string.Join(", ", summary.Seats),
                TotalAmount = summary.TotalAmount,
                PaymentMethod = summary.PaymentMethod,
                Status = "Unused",
                SoldAt = DateTime.Now,
                StaffName = staffName
            };
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    public bool MarkTicketUsed(string ticketCode)
    {
        using var connection = DbConnectionFactory.CreateConnection();
        connection.Open();
        DatabaseHelper.PrepareConnection(connection);
        using var transaction = connection.BeginTransaction();

        try
        {
            var ticketId = GetTicketIdOrNull(connection, transaction, ticketCode);
            var checkedByUserId = GetCurrentUserId(connection, transaction);

            if (ticketId is null)
            {
                InsertTicketCheck(connection, transaction, null, ticketCode, checkedByUserId, "NotFound", "Không tìm thấy vé.");
                transaction.Commit();
                return false;
            }

            var status = GetTicketStatus(connection, transaction, ticketId.Value);
            if (status != "Unused")
            {
                InsertTicketCheck(connection, transaction, ticketId, ticketCode, checkedByUserId, ToCheckResult(status), "Vé không còn ở trạng thái chưa dùng.");
                transaction.Commit();
                return false;
            }

            using (var updateTicket = new SqlCommand("""
                UPDATE dbo.Tickets
                SET TicketStatus = N'Used'
                WHERE TicketId = @TicketId;
                """, connection, transaction))
            {
                updateTicket.Parameters.AddWithValue("@TicketId", ticketId.Value);
                updateTicket.ExecuteNonQuery();
            }

            InsertTicketCheck(connection, transaction, ticketId, ticketCode, checkedByUserId, "Valid", "Đã xác nhận khách vào rạp.");
            transaction.Commit();
            return true;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    private static IReadOnlyList<SeatInfo> MapSeats(DataTable table, string? soldColumnName)
    {
        var seats = new List<SeatInfo>();

        foreach (DataRow row in table.Rows)
        {
            var seatStatus = row["SeatStatus"].ToString() ?? "";
            var isSold = soldColumnName is not null && Convert.ToInt32(row[soldColumnName]) == 1;

            seats.Add(new SeatInfo
            {
                RoomId = row["RoomId"].ToString() ?? "",
                SeatCode = row["SeatCode"].ToString() ?? "",
                RowIndex = RowLabelToIndex(row["RowLabel"].ToString() ?? "A"),
                ColumnIndex = Convert.ToInt32(row["SeatNumber"]) - 1,
                Status = isSold
                    ? SeatStatus.Sold
                    : seatStatus == "Maintenance" ? SeatStatus.Maintenance : SeatStatus.Available
            });
        }

        return seats;
    }

    private static int InsertTicket(SqlConnection connection, SqlTransaction transaction, string ticketCode, int showtimeId, int soldByUserId, decimal totalAmount)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.Tickets
            (
                TicketCode,
                ShowtimeId,
                SoldByUserId,
                CustomerName,
                TotalAmount,
                TicketStatus,
                PaymentStatus
            )
            VALUES
            (
                @TicketCode,
                @ShowtimeId,
                @SoldByUserId,
                N'Khách lẻ',
                @TotalAmount,
                N'Unused',
                N'Paid'
            );

            SELECT CONVERT(INT, SCOPE_IDENTITY());
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketCode", ticketCode);
        command.Parameters.AddWithValue("@ShowtimeId", showtimeId);
        command.Parameters.AddWithValue("@SoldByUserId", soldByUserId);
        command.Parameters.AddWithValue("@TotalAmount", totalAmount);

        return Convert.ToInt32(command.ExecuteScalar());
    }

    private static void InsertTicketDetail(SqlConnection connection, SqlTransaction transaction, int ticketId, int showtimeId, int seatId, decimal unitPrice)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.TicketDetails
            (
                TicketId,
                ShowtimeId,
                SeatId,
                UnitPrice,
                TicketDetailStatus
            )
            VALUES
            (
                @TicketId,
                @ShowtimeId,
                @SeatId,
                @UnitPrice,
                N'Active'
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", ticketId);
        command.Parameters.AddWithValue("@ShowtimeId", showtimeId);
        command.Parameters.AddWithValue("@SeatId", seatId);
        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
        command.ExecuteNonQuery();
    }

    private static void InsertPayment(SqlConnection connection, SqlTransaction transaction, string paymentCode, int ticketId, string paymentMethod, decimal amount)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.Payments
            (
                PaymentCode,
                TicketId,
                PaymentMethod,
                Amount,
                Status,
                TransactionRef,
                PaidAt
            )
            VALUES
            (
                @PaymentCode,
                @TicketId,
                @PaymentMethod,
                @Amount,
                N'Success',
                @TransactionRef,
                SYSDATETIME()
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@PaymentCode", paymentCode);
        command.Parameters.AddWithValue("@TicketId", ticketId);
        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
        command.Parameters.AddWithValue("@Amount", amount);
        command.Parameters.AddWithValue("@TransactionRef", paymentMethod == "VNPAY_SANDBOX" ? $"VNPAY-DEMO-{paymentCode}" : DBNull.Value);
        command.ExecuteNonQuery();
    }

    private static void InsertTicketCheck(SqlConnection connection, SqlTransaction transaction, int? ticketId, string ticketCodeInput, int checkedByUserId, string result, string note)
    {
        using var command = new SqlCommand("""
            INSERT INTO dbo.TicketChecks
            (
                TicketId,
                TicketCodeInput,
                CheckedByUserId,
                CheckResult,
                Note
            )
            VALUES
            (
                @TicketId,
                @TicketCodeInput,
                @CheckedByUserId,
                @CheckResult,
                @Note
            );
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", (object?)ticketId ?? DBNull.Value);
        command.Parameters.AddWithValue("@TicketCodeInput", ticketCodeInput);
        command.Parameters.AddWithValue("@CheckedByUserId", checkedByUserId);
        command.Parameters.AddWithValue("@CheckResult", result);
        command.Parameters.AddWithValue("@Note", note);
        command.ExecuteNonQuery();
    }

    private static string GetNextCode(SqlConnection connection, SqlTransaction transaction, string tableName, string columnName, string prefix, int digitCount)
    {
        using var command = new SqlCommand($"""
            SELECT
                ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING({columnName}, {prefix.Length + 1}, 20))), 0) + 1
            FROM {tableName}
            WHERE {columnName} LIKE @PrefixLike;
            """, connection, transaction);

        command.Parameters.AddWithValue("@PrefixLike", prefix + "%");
        var nextNumber = Convert.ToInt32(command.ExecuteScalar());
        return prefix + nextNumber.ToString(new string('0', digitCount));
    }

    private static int GetCurrentUserId(SqlConnection connection, SqlTransaction transaction)
    {
        using var command = new SqlCommand("""
            SELECT TOP 1 UserId
            FROM dbo.Users
            WHERE UserCode = @UserCode
                OR Username = @Username
            ORDER BY UserId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@UserCode", UserSession.UserId);
        command.Parameters.AddWithValue("@Username", UserSession.Username);

        var result = command.ExecuteScalar();
        if (result is not null)
        {
            return Convert.ToInt32(result);
        }

        throw new InvalidOperationException("Không tìm thấy tài khoản nhân viên hiện tại trong database.");
    }

    private static int GetSeatId(SqlConnection connection, SqlTransaction transaction, int roomId, string seatCode)
    {
        using var command = new SqlCommand("""
            SELECT SeatId
            FROM dbo.Seats
            WHERE RoomId = @RoomId
                AND SeatCode = @SeatCode;
            """, connection, transaction);

        command.Parameters.AddWithValue("@RoomId", roomId);
        command.Parameters.AddWithValue("@SeatCode", seatCode);

        var result = command.ExecuteScalar();
        if (result is not null)
        {
            return Convert.ToInt32(result);
        }

        throw new InvalidOperationException($"Không tìm thấy ghế {seatCode} trong phòng đang chọn.");
    }

    private static int? GetTicketIdOrNull(SqlConnection connection, SqlTransaction transaction, string ticketCode)
    {
        using var command = new SqlCommand("""
            SELECT TicketId
            FROM dbo.Tickets
            WHERE TicketCode = @TicketCode;
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketCode", ticketCode.Trim());
        var result = command.ExecuteScalar();
        return result is null ? null : Convert.ToInt32(result);
    }

    private static string GetTicketStatus(SqlConnection connection, SqlTransaction transaction, int ticketId)
    {
        using var command = new SqlCommand("""
            SELECT TicketStatus
            FROM dbo.Tickets
            WHERE TicketId = @TicketId;
            """, connection, transaction);

        command.Parameters.AddWithValue("@TicketId", ticketId);
        return command.ExecuteScalar()?.ToString() ?? "";
    }

    private static int ToInt(string value)
    {
        return int.TryParse(value, out var number) ? number : 0;
    }

    private static string ToDisplayPaymentMethod(string paymentMethod)
    {
        return paymentMethod switch
        {
            "Cash" => "Tiền mặt",
            "VNPAY_SANDBOX" => "VNPAY Sandbox",
            _ => paymentMethod
        };
    }

    private static string ToDatabasePaymentMethod(string paymentMethod)
    {
        return paymentMethod.Contains("VNPAY", StringComparison.OrdinalIgnoreCase)
            ? "VNPAY_SANDBOX"
            : "Cash";
    }

    private static string ToAppTicketStatus(string ticketStatus)
    {
        return ticketStatus == "Cancelled" ? "Canceled" : ticketStatus;
    }

    private static string ToCheckResult(string ticketStatus)
    {
        return ticketStatus switch
        {
            "Used" => "Used",
            "Cancelled" or "Canceled" => "Cancelled",
            _ => "Valid"
        };
    }

    private static int RowLabelToIndex(string rowLabel)
    {
        var value = 0;

        foreach (var character in rowLabel.ToUpperInvariant())
        {
            if (character < 'A' || character > 'Z')
            {
                continue;
            }

            value = value * 26 + character - 'A' + 1;
        }

        return Math.Max(0, value - 1);
    }

    private static string GetRowLabel(int rowIndex)
    {
        var label = "";
        var value = rowIndex;

        do
        {
            label = (char)('A' + value % 26) + label;
            value = value / 26 - 1;
        }
        while (value >= 0);

        return label;
    }

    private static int ExtractSeatNumber(string seatCode)
    {
        var digits = new string(seatCode.Where(char.IsDigit).ToArray());
        return int.TryParse(digits, out var number) ? number : 1;
    }
}
