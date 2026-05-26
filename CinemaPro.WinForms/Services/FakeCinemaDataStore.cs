using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services.Interfaces;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Services;

public sealed class FakeCinemaDataStore : ICinemaDataStore
{
    private readonly List<MovieRow> _movies = FakeDataProvider.GetMovies();
    private readonly List<RoomRow> _rooms = FakeDataProvider.GetRooms();
    private readonly List<ShowtimeRow> _showtimes = FakeDataProvider.GetShowtimes();
    private readonly List<TicketRow> _tickets = FakeDataProvider.GetTickets();
    private readonly List<EmployeeRow> _employees = FakeDataProvider.GetEmployees();
    private readonly List<RevenueRow> _revenueRows = FakeDataProvider.GetRevenueRows();
    private readonly Dictionary<string, List<SeatInfo>> _seatsByShowtime = [];
    private int _nextTicketNumber = 5;

    public FakeCinemaDataStore()
    {
        foreach (var showtime in _showtimes)
        {
            _seatsByShowtime[showtime.ShowtimeId] = FakeDataProvider.GetSeatMap();
        }
    }

    public IReadOnlyList<MovieRow> GetMovies() => _movies;

    public IReadOnlyList<RoomRow> GetRooms() => _rooms;

    public IReadOnlyList<ShowtimeRow> GetShowtimes() => _showtimes;

    public IReadOnlyList<TicketRow> GetTickets() => _tickets;

    public IReadOnlyList<EmployeeRow> GetEmployees() => _employees;

    public IReadOnlyList<RevenueRow> GetRevenueRows() => _revenueRows;

    public IReadOnlyList<SeatInfo> GetSeats(string showtimeId)
    {
        if (!_seatsByShowtime.TryGetValue(showtimeId, out var seats))
        {
            seats = FakeDataProvider.GetSeatMap();
            _seatsByShowtime[showtimeId] = seats;
        }

        return seats.Select(seat => new SeatInfo(seat.SeatCode, seat.Status)).ToList();
    }

    public TicketRow CreateTicket(string showtimeId, PaymentSummary summary)
    {
        if (!_seatsByShowtime.TryGetValue(showtimeId, out var seats))
        {
            seats = FakeDataProvider.GetSeatMap();
            _seatsByShowtime[showtimeId] = seats;
        }

        var selectedSeats = summary.Seats.ToHashSet(StringComparer.OrdinalIgnoreCase);
        var unavailableSeat = seats.FirstOrDefault(seat =>
            selectedSeats.Contains(seat.SeatCode) &&
            seat.Status is SeatStatus.Sold or SeatStatus.Maintenance);

        if (unavailableSeat is not null)
        {
            throw new InvalidOperationException($"Ghế {unavailableSeat.SeatCode} không còn khả dụng.");
        }

        for (var index = 0; index < seats.Count; index++)
        {
            var seat = seats[index];
            if (selectedSeats.Contains(seat.SeatCode))
            {
                seats[index] = seat with { Status = SeatStatus.Sold };
            }
        }

        var ticketId = _tickets.Any(ticket => ticket.TicketId.Equals(summary.TicketId, StringComparison.OrdinalIgnoreCase))
            ? $"TK{_nextTicketNumber++:000000}"
            : summary.TicketId;

        var ticket = new TicketRow(
            ticketId,
            summary.Movie,
            summary.Showtime,
            summary.Room,
            string.Join(", ", summary.Seats),
            summary.Total,
            summary.PaymentMethod,
            "Unused");
        _tickets.Insert(0, ticket);
        return ticket;
    }

    public TicketRow? FindTicket(string ticketId)
    {
        return _tickets.FirstOrDefault(ticket =>
            ticket.TicketId.Equals(ticketId.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    public bool MarkTicketUsed(string ticketId)
    {
        var index = _tickets.FindIndex(ticket =>
            ticket.TicketId.Equals(ticketId.Trim(), StringComparison.OrdinalIgnoreCase));
        if (index < 0 || _tickets[index].Status != "Unused")
        {
            return false;
        }

        _tickets[index] = _tickets[index] with { Status = "Used" };
        return true;
    }
}
