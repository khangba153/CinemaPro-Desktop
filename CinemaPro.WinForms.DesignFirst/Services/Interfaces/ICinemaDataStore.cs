using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Services.Interfaces;

public interface ICinemaDataStore
{
    AppUser? Authenticate(string username, string password);
    IReadOnlyList<MovieRow> GetMovies();
    IReadOnlyList<RoomRow> GetRooms();
    IReadOnlyList<ShowtimeRow> GetShowtimes();
    IReadOnlyList<TicketRow> GetTickets();
    IReadOnlyList<EmployeeRow> GetEmployees();
    IReadOnlyList<RevenueRow> GetRevenueRows();
    IReadOnlyList<SeatInfo> GetSeats(string roomId);
    IReadOnlyList<SeatInfo> GetSeatsForShowtime(string showtimeId);
    void UpdateRoomSeatLayout(string roomId, int rowCount, int columnCount, IReadOnlyList<SeatInfo> seats);
    ShowtimeRow? FindShowtime(string showtimeId);
    TicketRow? FindTicket(string ticketCode);
    TicketRow CreateTicket(PaymentSummary summary, string staffName);
    bool MarkTicketUsed(string ticketCode);
}
