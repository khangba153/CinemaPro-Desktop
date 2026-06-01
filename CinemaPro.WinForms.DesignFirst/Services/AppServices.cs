using CinemaPro.WinForms.DesignFirst.Services.Interfaces;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Services;

public static class AppServices
{
    public static ICinemaDataStore CinemaStore { get; } = new DesignPreviewCinemaDataStore();

    private sealed class DesignPreviewCinemaDataStore : ICinemaDataStore
    {
        private readonly List<AppUser> _users =
        [
            new AppUser { UserId = "U001", FullName = "Nguyễn Văn Quản", Username = "admin", Password = "123456", Role = "Admin", Status = "Active" },
            new AppUser { UserId = "U002", FullName = "Trần Thị Mai", Username = "staff01", Password = "123456", Role = "Staff", Status = "Active" }
        ];

        public AppUser? Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(user =>
                string.Equals(user.Username, username.Trim(), StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }

        public IReadOnlyList<MovieRow> GetMovies() => [];
        public IReadOnlyList<RoomRow> GetRooms() => [];
        public IReadOnlyList<ShowtimeRow> GetShowtimes() => [];
        public IReadOnlyList<TicketRow> GetTickets() => [];
        public IReadOnlyList<EmployeeRow> GetEmployees() => [];
        public IReadOnlyList<RevenueRow> GetRevenueRows() => [];
        public IReadOnlyList<SeatInfo> GetSeats(string roomId) => [];
        public void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats) { }
        public ShowtimeRow? FindShowtime(string showtimeId) => null;
        public TicketRow? FindTicket(string ticketCode) => null;

        public TicketRow CreateTicket(PaymentSummary summary, string staffName)
        {
            return new TicketRow
            {
                TicketCode = "TK-TEMP",
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

        public bool MarkTicketUsed(string ticketCode) => false;
    }
}
