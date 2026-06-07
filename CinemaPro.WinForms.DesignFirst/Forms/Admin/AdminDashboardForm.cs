using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class AdminDashboardForm : Form
{
    private readonly MovieService _movieService = new();
    private readonly RoomService _roomService = new();
    private readonly ShowtimeService _showtimeService = new();
    private readonly ReportService _reportService = new();

    public AdminDashboardForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(recentShowtimeGrid);
        UiStyleHelper.StyleGrid(revenueGrid);
    }

    private void AdminDashboardForm_Load(object? sender, EventArgs e)
    {
        var movies = _movieService.GetMovies();
        var rooms = _roomService.GetRooms();
        var showtimes = _showtimeService.GetShowtimes();
        var revenueRows = _reportService.GetRevenueRows();
        var todayRevenueRows = revenueRows
            .Where(row => row.Date.Date == DateTime.Today)
            .ToList();

        totalMovieValueLabel.Text = movies.Count.ToString();
        totalRoomValueLabel.Text = rooms.Count.ToString();
        todayShowtimeValueLabel.Text = showtimes.Count(item => item.Date.Date == DateTime.Today).ToString();
        todayTicketValueLabel.Text = todayRevenueRows.Sum(item => item.TicketCount).ToString();
        todayRevenueValueLabel.Text = FormatHelper.Vnd(todayRevenueRows.Sum(item => item.Revenue));

        recentShowtimeGrid.Rows.Clear();
        foreach (var showtime in showtimes.Take(6))
        {
            recentShowtimeGrid.Rows.Add(showtime.MovieTitle, showtime.RoomName, showtime.TimeText, FormatHelper.Vnd(showtime.Price), showtime.Status);
        }

        revenueGrid.Rows.Clear();
        foreach (var row in revenueRows)
        {
            revenueGrid.Rows.Add(row.MovieTitle, row.TicketCount, FormatHelper.Vnd(row.Revenue), row.PaymentMethod);
        }
    }
}
