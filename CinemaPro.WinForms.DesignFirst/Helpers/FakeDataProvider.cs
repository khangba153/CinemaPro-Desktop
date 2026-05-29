using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class FakeDataProvider
{
    public static List<AppUser> Users()
    {
        return
        [
            new AppUser { UserId = "U001", FullName = "Nguyễn Văn Quản", Username = "admin", Password = "123456", Role = "Admin", Status = "Hoạt động" },
            new AppUser { UserId = "U002", FullName = "Trần Thị Mai", Username = "staff01", Password = "123456", Role = "Staff", Status = "Hoạt động" },
            new AppUser { UserId = "U003", FullName = "Lê Minh Khang", Username = "staff02", Password = "123456", Role = "Staff", Status = "Tạm khóa" }
        ];
    }

    public static List<MovieRow> Movies()
    {
        return
        [
            new MovieRow { MovieId = "MV001", Title = "Avengers: Endgame", Genre = "Hành động", DurationMinutes = 182, AgeRating = "C13", Director = "Anthony Russo", Status = "Đang chiếu" },
            new MovieRow { MovieId = "MV002", Title = "Mai", Genre = "Tâm lý", DurationMinutes = 131, AgeRating = "C18", Director = "Trấn Thành", Status = "Đang chiếu" },
            new MovieRow { MovieId = "MV003", Title = "Dune: Part Two", Genre = "Khoa học viễn tưởng", DurationMinutes = 166, AgeRating = "C13", Director = "Denis Villeneuve", Status = "Đang chiếu" },
            new MovieRow { MovieId = "MV004", Title = "Kung Fu Panda 4", Genre = "Hoạt hình", DurationMinutes = 94, AgeRating = "P", Director = "Mike Mitchell", Status = "Đang chiếu" },
            new MovieRow { MovieId = "MV005", Title = "Lật Mặt 7", Genre = "Gia đình", DurationMinutes = 138, AgeRating = "C13", Director = "Lý Hải", Status = "Sắp chiếu" },
            new MovieRow { MovieId = "MV006", Title = "Inside Out 2", Genre = "Hoạt hình", DurationMinutes = 96, AgeRating = "P", Director = "Kelsey Mann", Status = "Sắp chiếu" }
        ];
    }

    public static List<RoomRow> Rooms()
    {
        return
        [
            new RoomRow { RoomId = "R001", RoomName = "Phòng 1", RoomType = "2D", Rows = 6, SeatsPerRow = 8, Status = "Sẵn sàng" },
            new RoomRow { RoomId = "R002", RoomName = "Phòng 2", RoomType = "3D", Rows = 6, SeatsPerRow = 8, Status = "Sẵn sàng" },
            new RoomRow { RoomId = "R003", RoomName = "IMAX 1", RoomType = "IMAX", Rows = 7, SeatsPerRow = 10, Status = "Sẵn sàng" },
            new RoomRow { RoomId = "R004", RoomName = "VIP 1", RoomType = "VIP", Rows = 5, SeatsPerRow = 6, Status = "Đang bảo trì" },
            new RoomRow { RoomId = "R005", RoomName = "Phòng 5", RoomType = "2D", Rows = 6, SeatsPerRow = 8, Status = "Sẵn sàng" }
        ];
    }

    public static List<ShowtimeRow> Showtimes()
    {
        var today = DateTime.Today;
        return
        [
            new ShowtimeRow { ShowtimeId = "SC001", MovieId = "MV004", MovieTitle = "Kung Fu Panda 4", RoomId = "R001", RoomName = "Phòng 1", Date = today, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(10, 34, 0), Price = 75000, Format = "2D", Status = "Đang bán" },
            new ShowtimeRow { ShowtimeId = "SC002", MovieId = "MV002", MovieTitle = "Mai", RoomId = "R002", RoomName = "Phòng 2", Date = today, StartTime = new TimeSpan(10, 30, 0), EndTime = new TimeSpan(12, 41, 0), Price = 85000, Format = "2D", Status = "Đang bán" },
            new ShowtimeRow { ShowtimeId = "SC003", MovieId = "MV003", MovieTitle = "Dune: Part Two", RoomId = "R003", RoomName = "IMAX 1", Date = today, StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(16, 46, 0), Price = 130000, Format = "IMAX", Status = "Đang bán" },
            new ShowtimeRow { ShowtimeId = "SC004", MovieId = "MV001", MovieTitle = "Avengers: Endgame", RoomId = "R002", RoomName = "Phòng 2", Date = today, StartTime = new TimeSpan(19, 30, 0), EndTime = new TimeSpan(22, 32, 0), Price = 90000, Format = "3D", Status = "Đang bán" },
            new ShowtimeRow { ShowtimeId = "SC005", MovieId = "MV005", MovieTitle = "Lật Mặt 7", RoomId = "R001", RoomName = "Phòng 1", Date = today.AddDays(1), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(21, 18, 0), Price = 85000, Format = "2D", Status = "Sắp chiếu" }
        ];
    }

    public static List<TicketRow> Tickets()
    {
        var now = DateTime.Now;
        return
        [
            new TicketRow { TicketCode = "TK000001", MovieTitle = "Avengers: Endgame", ShowtimeText = "19:30 - 22:32", RoomName = "Phòng 2", Seats = "B6", TotalAmount = 90000, PaymentMethod = "Tiền mặt", Status = "Unused", SoldAt = now.AddMinutes(-18), StaffName = "Trần Thị Mai" },
            new TicketRow { TicketCode = "TK000002", MovieTitle = "Dune: Part Two", ShowtimeText = "14:00 - 16:46", RoomName = "IMAX 1", Seats = "C4, C5", TotalAmount = 260000, PaymentMethod = "VNPAY Sandbox", Status = "Used", SoldAt = now.AddHours(-3), StaffName = "Trần Thị Mai" },
            new TicketRow { TicketCode = "TK000003", MovieTitle = "Mai", ShowtimeText = "10:30 - 12:41", RoomName = "Phòng 2", Seats = "A1", TotalAmount = 85000, PaymentMethod = "Tiền mặt", Status = "Canceled", SoldAt = now.AddHours(-4), StaffName = "Trần Thị Mai" },
            new TicketRow { TicketCode = "TK000004", MovieTitle = "Kung Fu Panda 4", ShowtimeText = "09:00 - 10:34", RoomName = "Phòng 1", Seats = "D2, D3", TotalAmount = 150000, PaymentMethod = "Tiền mặt", Status = "Unused", SoldAt = now.AddMinutes(-42), StaffName = "Trần Thị Mai" }
        ];
    }

    public static List<EmployeeRow> Employees()
    {
        return Users()
            .Select(user => new EmployeeRow
            {
                UserId = user.UserId,
                FullName = user.FullName,
                Username = user.Username,
                Role = user.Role,
                Status = user.Status
            })
            .ToList();
    }

    public static List<RevenueRow> RevenueRows()
    {
        var today = DateTime.Today;
        return
        [
            new RevenueRow { Date = today, MovieTitle = "Avengers: Endgame", TicketCount = 68, Revenue = 6120000, PaymentMethod = "Tiền mặt" },
            new RevenueRow { Date = today, MovieTitle = "Dune: Part Two", TicketCount = 54, Revenue = 7020000, PaymentMethod = "VNPAY Sandbox" },
            new RevenueRow { Date = today, MovieTitle = "Mai", TicketCount = 73, Revenue = 6205000, PaymentMethod = "Tiền mặt" },
            new RevenueRow { Date = today, MovieTitle = "Kung Fu Panda 4", TicketCount = 44, Revenue = 3300000, PaymentMethod = "Tiền mặt" }
        ];
    }

    public static Dictionary<string, List<SeatInfo>> SeatsByRoom()
    {
        var rooms = Rooms();
        var result = new Dictionary<string, List<SeatInfo>>();
        foreach (var room in rooms)
        {
            var seats = new List<SeatInfo>();
            for (var row = 0; row < room.Rows; row++)
            {
                var rowName = ((char)('A' + row)).ToString();
                for (var col = 1; col <= room.SeatsPerRow; col++)
                {
                    seats.Add(new SeatInfo
                    {
                        RoomId = room.RoomId,
                        SeatCode = $"{rowName}{col}",
                        Status = SeatStatus.Available
                    });
                }
            }

            MarkSeat(seats, "A3", SeatStatus.Sold);
            MarkSeat(seats, "A4", SeatStatus.Sold);
            MarkSeat(seats, "B6", SeatStatus.Sold);
            MarkSeat(seats, "C2", SeatStatus.Maintenance);
            MarkSeat(seats, "E7", SeatStatus.Sold);
            result[room.RoomId] = seats;
        }

        return result;
    }

    private static void MarkSeat(List<SeatInfo> seats, string code, SeatStatus status)
    {
        var seat = seats.FirstOrDefault(item => item.SeatCode == code);
        if (seat is not null)
        {
            seat.Status = status;
        }
    }
}
