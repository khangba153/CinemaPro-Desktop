using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services.Interfaces;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class FakeCinemaDataStore : ICinemaDataStore
{
    private readonly List<AppUser> _users = FakeDataProvider.Users();
    private readonly List<MovieRow> _movies = FakeDataProvider.Movies();
    private readonly List<RoomRow> _rooms = FakeDataProvider.Rooms();
    private readonly List<ShowtimeRow> _showtimes = FakeDataProvider.Showtimes();
    private readonly List<TicketRow> _tickets = FakeDataProvider.Tickets();
    private readonly List<EmployeeRow> _employees = FakeDataProvider.Employees();
    private readonly List<RevenueRow> _revenueRows = FakeDataProvider.RevenueRows();
    private readonly Dictionary<string, List<SeatInfo>> _seatsByRoom = FakeDataProvider.SeatsByRoom();
    private int _ticketNumber = 5;

    public AppUser? Authenticate(string username, string password)
    {
        return _users.FirstOrDefault(user =>
            string.Equals(user.Username, username.Trim(), StringComparison.OrdinalIgnoreCase)
            && user.Password == password
            && user.Status == "Hoạt động");
    }

    public IReadOnlyList<MovieRow> GetMovies() => _movies;
    public IReadOnlyList<RoomRow> GetRooms() => _rooms;
    public IReadOnlyList<ShowtimeRow> GetShowtimes() => _showtimes;
    public IReadOnlyList<TicketRow> GetTickets() => _tickets.OrderByDescending(ticket => ticket.SoldAt).ToList();
    public IReadOnlyList<EmployeeRow> GetEmployees() => _employees;
    public IReadOnlyList<RevenueRow> GetRevenueRows() => _revenueRows;

    public IReadOnlyList<SeatInfo> GetSeats(string roomId)
    {
        return _seatsByRoom.TryGetValue(roomId, out var seats) ? seats : [];
    }

    public ShowtimeRow? FindShowtime(string showtimeId)
    {
        return _showtimes.FirstOrDefault(showtime => showtime.ShowtimeId == showtimeId);
    }

    public TicketRow? FindTicket(string ticketCode)
    {
        return _tickets.FirstOrDefault(ticket =>
            string.Equals(ticket.TicketCode, ticketCode.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    public TicketRow CreateTicket(PaymentSummary summary, string staffName)
    {
        var ticket = new TicketRow
        {
            TicketCode = $"TK{_ticketNumber++:000000}",
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

        _tickets.Add(ticket);
        if (_seatsByRoom.TryGetValue(summary.RoomId, out var roomSeats))
        {
            foreach (var seatCode in summary.Seats)
            {
                var seat = roomSeats.FirstOrDefault(item => item.SeatCode == seatCode);
                if (seat is not null)
                {
                    seat.Status = SeatStatus.Sold;
                }
            }
        }

        return ticket;
    }

    public bool MarkTicketUsed(string ticketCode)
    {
        var ticket = FindTicket(ticketCode);
        if (ticket is null || ticket.Status != "Unused")
        {
            return false;
        }

        ticket.Status = "Used";
        return true;
    }
}
