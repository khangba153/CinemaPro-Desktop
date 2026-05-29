namespace CinemaPro.WinForms.DesignFirst.ViewModels;

public enum SeatStatus
{
    Available,
    Selected,
    Sold,
    Maintenance
}

public sealed class AppUser
{
    public string UserId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Role { get; set; } = "";
    public string Status { get; set; } = "";
}

public sealed class MovieRow
{
    public string MovieId { get; set; } = "";
    public string Title { get; set; } = "";
    public string Genre { get; set; } = "";
    public int DurationMinutes { get; set; }
    public string AgeRating { get; set; } = "";
    public string Director { get; set; } = "";
    public string Status { get; set; } = "";
}

public sealed class RoomRow
{
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string RoomType { get; set; } = "";
    public int Rows { get; set; }
    public int SeatsPerRow { get; set; }
    public string Status { get; set; } = "";
}

public sealed class ShowtimeRow
{
    public string ShowtimeId { get; set; } = "";
    public string MovieId { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public decimal Price { get; set; }
    public string Format { get; set; } = "";
    public string Status { get; set; } = "";

    public string DateText => Date.ToString("dd/MM/yyyy");
    public string TimeText => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
    public string DisplayText => $"{TimeText} | {RoomName} | {Format}";
}

public sealed class TicketRow
{
    public string TicketCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string ShowtimeText { get; set; } = "";
    public string RoomName { get; set; } = "";
    public string Seats { get; set; } = "";
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; } = "";
    public string Status { get; set; } = "";
    public DateTime SoldAt { get; set; }
    public string StaffName { get; set; } = "";
}

public sealed class EmployeeRow
{
    public string UserId { get; set; } = "";
    public string FullName { get; set; } = "";
    public string Username { get; set; } = "";
    public string Role { get; set; } = "";
    public string Status { get; set; } = "";
}

public sealed class RevenueRow
{
    public DateTime Date { get; set; }
    public string MovieTitle { get; set; } = "";
    public int TicketCount { get; set; }
    public decimal Revenue { get; set; }
    public string PaymentMethod { get; set; } = "";
}

public sealed class SeatInfo
{
    public string RoomId { get; set; } = "";
    public string SeatCode { get; set; } = "";
    public SeatStatus Status { get; set; }
}

public sealed class PaymentSummary
{
    public string TicketCode { get; set; } = "";
    public string MovieTitle { get; set; } = "";
    public string ShowtimeId { get; set; } = "";
    public string ShowtimeText { get; set; } = "";
    public string RoomId { get; set; } = "";
    public string RoomName { get; set; } = "";
    public List<string> Seats { get; set; } = [];
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; } = "";
}
