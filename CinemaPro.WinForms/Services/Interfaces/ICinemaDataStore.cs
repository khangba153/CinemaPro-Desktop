using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Services.Interfaces;

public interface ICinemaDataStore
{
    IReadOnlyList<MovieRow> GetMovies();

    IReadOnlyList<RoomRow> GetRooms();

    IReadOnlyList<ShowtimeRow> GetShowtimes();

    IReadOnlyList<TicketRow> GetTickets();

    IReadOnlyList<EmployeeRow> GetEmployees();

    IReadOnlyList<RevenueRow> GetRevenueRows();

    IReadOnlyList<SeatInfo> GetSeats(string showtimeId);

    TicketRow CreateTicket(string showtimeId, PaymentSummary summary);

    TicketRow? FindTicket(string ticketId);

    bool MarkTicketUsed(string ticketId);
}
