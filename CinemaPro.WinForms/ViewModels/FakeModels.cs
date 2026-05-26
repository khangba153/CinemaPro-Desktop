namespace CinemaPro.WinForms.ViewModels;

public enum SeatStatus
{
    Available,
    Selected,
    Sold,
    Maintenance
}

public sealed record AppUser(string UserId, string FullName, string Username, string Role);

public sealed record MovieRow(
    string MovieId,
    string Title,
    string Genre,
    int Duration,
    string AgeRating,
    string Director,
    string Status);

public sealed record RoomRow(
    string RoomId,
    string Name,
    string RoomType,
    int SeatRows,
    int SeatsPerRow,
    string Status);

public sealed record ShowtimeRow(
    string ShowtimeId,
    string Movie,
    string Room,
    DateTime StartTime,
    DateTime EndTime,
    decimal TicketPrice,
    string Format,
    string Status);

public sealed record TicketRow(
    string TicketId,
    string Movie,
    string Showtime,
    string Room,
    string Seats,
    decimal Total,
    string PaymentMethod,
    string Status);

public sealed record EmployeeRow(
    string UserId,
    string FullName,
    string Username,
    string Role,
    string Status);

public sealed record RevenueRow(
    DateTime Date,
    string Movie,
    int TicketsSold,
    decimal Revenue,
    string BestShowtime);

public sealed record SeatInfo(string SeatCode, SeatStatus Status);

public sealed record PaymentSummary(
    string TicketId,
    string Movie,
    string Showtime,
    string Room,
    IReadOnlyList<string> Seats,
    decimal Total,
    string PaymentMethod);
