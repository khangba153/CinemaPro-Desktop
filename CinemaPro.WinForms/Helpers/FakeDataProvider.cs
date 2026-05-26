using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Helpers;

public static class FakeDataProvider
{
    public static AppUser? TryAuthenticate(string username, string password)
    {
        if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "123456")
        {
            return new AppUser("U001", "Nguyễn Văn Quản", "admin", "Admin");
        }

        if (username.Equals("staff01", StringComparison.OrdinalIgnoreCase) && password == "123456")
        {
            return new AppUser("U002", "Trần Thị Mai", "staff01", "Staff");
        }

        return null;
    }

    public static List<MovieRow> GetMovies() =>
    [
        new("MV001", "Avengers: Endgame", "Hành động", 181, "13+", "Anthony Russo", "Đang chiếu"),
        new("MV002", "Dora, Phá Vỡ Pando", "Hoạt hình", 102, "P", "Mike Mitchell", "Đang chiếu"),
        new("MV003", "Godzilla x Kong: Đế chế mới", "Hành động", 115, "13+", "Adam Wingard", "Đang chiếu"),
        new("MV004", "Lật Mặt 7: Một Điều Ước", "Gia đình", 138, "13+", "Lý Hải", "Sắp chiếu"),
        new("MV005", "Dune: Phần Hai", "Khoa học viễn tưởng", 166, "16+", "Denis Villeneuve", "Đang chiếu"),
        new("MV006", "Nhà Bà Nữ", "Tâm lý", 102, "16+", "Trấn Thành", "Ngừng chiếu")
    ];

    public static List<RoomRow> GetRooms() =>
    [
        new("P01", "Phòng 1", "2D", 7, 10, "Đang hoạt động"),
        new("P02", "Phòng 2", "2D", 8, 11, "Đang hoạt động"),
        new("P03", "Phòng 3", "3D", 8, 10, "Đang hoạt động"),
        new("P04", "Phòng 4", "IMAX", 9, 12, "Đang hoạt động"),
        new("P05", "Phòng VIP", "VIP", 6, 8, "Bảo trì")
    ];

    public static List<ShowtimeRow> GetShowtimes()
    {
        var today = DateTime.Today;
        return
        [
            new("SC001", "Avengers: Endgame", "Phòng 2", today.AddHours(9).AddMinutes(30), today.AddHours(12).AddMinutes(32), 90000, "2D", "Đang mở bán"),
            new("SC002", "Dora, Phá Vỡ Pando", "Phòng 1", today.AddHours(11).AddMinutes(30), today.AddHours(13).AddMinutes(12), 70000, "2D", "Đang mở bán"),
            new("SC003", "Godzilla x Kong: Đế chế mới", "Phòng 3", today.AddHours(13), today.AddHours(14).AddMinutes(55), 90000, "3D", "Sắp chiếu"),
            new("SC004", "Lật Mặt 7: Một Điều Ước", "Phòng 2", today.AddHours(15).AddMinutes(30), today.AddHours(17).AddMinutes(48), 90000, "2D", "Sắp chiếu"),
            new("SC005", "Fast & Furious 10", "Phòng 1", today.AddHours(17).AddMinutes(30), today.AddHours(19).AddMinutes(48), 80000, "2D", "Sắp chiếu"),
            new("SC006", "Nhà Bà Nữ", "Phòng 3", today.AddHours(19), today.AddHours(20).AddMinutes(42), 70000, "2D", "Sắp chiếu"),
            new("SC007", "Dune: Phần Hai", "Phòng 4", today.AddHours(21).AddMinutes(15), today.AddHours(23).AddMinutes(58), 120000, "IMAX", "Sắp chiếu"),
            new("SC008", "Avengers: Endgame", "Phòng 2", today.AddHours(19).AddMinutes(30), today.AddHours(22).AddMinutes(32), 90000, "2D", "Đang mở bán")
        ];
    }

    public static List<TicketRow> GetTickets() =>
    [
        new("TK000001", "Avengers: Endgame", "19:30 - 22:32", "Phòng 2", "B6", 90000, "Tiền mặt", "Unused"),
        new("TK000002", "Dora, Phá Vỡ Pando", "17:30 - 19:12", "Phòng 1", "A4", 70000, "VNPAY Sandbox", "Used"),
        new("TK000003", "Godzilla x Kong: Đế chế mới", "21:15 - 23:10", "Phòng 3", "D3, D4", 180000, "Tiền mặt", "Canceled"),
        new("TK000004", "Lật Mặt 7: Một Điều Ước", "15:30 - 17:48", "Phòng 2", "E5, E6", 180000, "VNPAY Sandbox", "Unused")
    ];

    public static List<EmployeeRow> GetEmployees() =>
    [
        new("U001", "Nguyễn Văn Quản", "admin", "Admin", "Hoạt động"),
        new("U002", "Trần Thị Mai", "staff01", "Staff", "Hoạt động"),
        new("U003", "Lê Minh Khoa", "staff02", "Staff", "Hoạt động"),
        new("U004", "Phạm An Nhiên", "staff03", "Staff", "Khóa"),
        new("U005", "Đỗ Minh Tâm", "staff04", "Staff", "Hoạt động")
    ];

    public static List<RevenueRow> GetRevenueRows()
    {
        var today = DateTime.Today;
        return
        [
            new(today, "Avengers: Endgame", 86, 7740000, "19:30"),
            new(today, "Dora, Phá Vỡ Pando", 70, 4900000, "17:30"),
            new(today, "Godzilla x Kong: Đế chế mới", 54, 4860000, "21:15"),
            new(today, "Lật Mặt 7: Một Điều Ước", 48, 4320000, "15:30"),
            new(today.AddDays(-1), "Dune: Phần Hai", 62, 7440000, "21:15"),
            new(today.AddDays(-2), "Avengers: Endgame", 92, 8280000, "19:30")
        ];
    }

    public static List<SeatInfo> GetSeatMap()
    {
        var seats = new List<SeatInfo>();
        var sold = new HashSet<string> { "A4", "A8", "B2", "B3", "D2", "D5", "D8", "F2" };
        var maintenance = new HashSet<string> { "E1", "F8" };

        for (var row = 'A'; row <= 'F'; row++)
        {
            for (var number = 1; number <= 8; number++)
            {
                var code = $"{row}{number}";
                var status = sold.Contains(code)
                    ? SeatStatus.Sold
                    : maintenance.Contains(code)
                        ? SeatStatus.Maintenance
                        : SeatStatus.Available;
                seats.Add(new SeatInfo(code, status));
            }
        }

        return seats;
    }

    public static string NewTicketId() => $"TK{DateTime.Now:HHmmss}";
}
