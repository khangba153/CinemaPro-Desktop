using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class AdminDashboardForm : Form
{
    public AdminDashboardForm()
    {
        InitializeComponent();
        ApplyRuntimeStyles();
        BindDashboard();
    }

    private void ApplyRuntimeStyles()
    {
        UiStyleHelper.ApplyStatusCellFormatting(showtimeGrid, "Status");
        UiStyleHelper.ApplyStatusCellFormatting(recentTicketGrid, "Status");
    }

    private void BindDashboard()
    {
        var movies = AppServices.CinemaStore.GetMovies();
        var rooms = AppServices.CinemaStore.GetRooms();
        var showtimes = AppServices.CinemaStore.GetShowtimes().Where(item => item.StartTime.Date == DateTime.Today).ToList();
        var tickets = AppServices.CinemaStore.GetTickets();
        var revenueRows = AppServices.CinemaStore.GetRevenueRows();

        movieValueLabel.Text = movies.Count.ToString();
        roomValueLabel.Text = rooms.Count.ToString();
        showtimeValueLabel.Text = showtimes.Count.ToString();
        ticketValueLabel.Text = tickets.Count.ToString();
        revenueValueLabel.Text = $"{tickets.Sum(t => t.Total) / 1_000_000:0.0}M";

        unusedValueLabel.Text = tickets.Count(t => t.Status == "Unused").ToString();
        usedValueLabel.Text = tickets.Count(t => t.Status == "Used").ToString();
        canceledValueLabel.Text = tickets.Count(t => t.Status == "Canceled").ToString();
        maintenanceValueLabel.Text = rooms.Count(room => room.Status.Contains("Bảo trì", StringComparison.OrdinalIgnoreCase)).ToString();

        showtimeGrid.DataSource = showtimes.Select(showtime => new
        {
            showtime.Movie,
            showtime.Room,
            Start = showtime.StartTime.ToString("HH:mm"),
            End = showtime.EndTime.ToString("HH:mm"),
            Price = UiStyleHelper.FormatCurrency(showtime.TicketPrice),
            showtime.Status
        }).ToList();

        recentTicketGrid.DataSource = tickets.Select(ticket => new
        {
            ticket.TicketId,
            ticket.Movie,
            ticket.Seats,
            Total = UiStyleHelper.FormatCurrency(ticket.Total),
            ticket.Status
        }).ToList();

        revenueGrid.DataSource = revenueRows.Take(5).Select(row => new
        {
            row.Movie,
            row.TicketsSold,
            Revenue = UiStyleHelper.FormatCurrency(row.Revenue)
        }).ToList();
    }
}
