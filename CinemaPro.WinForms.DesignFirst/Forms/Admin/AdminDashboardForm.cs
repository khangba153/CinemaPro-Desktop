using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class AdminDashboardForm : Form
{
    public AdminDashboardForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(recentShowtimeGrid);
        UiStyleHelper.StyleGrid(revenueGrid);
    }

    private void AdminDashboardForm_Load(object? sender, EventArgs e)
    {
        var store = AppServices.CinemaStore;
        totalMovieValueLabel.Text = store.GetMovies().Count.ToString();
        totalRoomValueLabel.Text = store.GetRooms().Count.ToString();
        todayShowtimeValueLabel.Text = store.GetShowtimes().Count(item => item.Date.Date == DateTime.Today).ToString();
        todayTicketValueLabel.Text = store.GetTickets().Count(item => item.SoldAt.Date == DateTime.Today).ToString();
        todayRevenueValueLabel.Text = FormatHelper.Vnd(store.GetTickets().Where(item => item.SoldAt.Date == DateTime.Today).Sum(item => item.TotalAmount));

        recentShowtimeGrid.Rows.Clear();
        foreach (var showtime in store.GetShowtimes().Take(6))
        {
            recentShowtimeGrid.Rows.Add(showtime.MovieTitle, showtime.RoomName, showtime.TimeText, FormatHelper.Vnd(showtime.Price), showtime.Status);
        }

        revenueGrid.Rows.Clear();
        foreach (var row in store.GetRevenueRows())
        {
            revenueGrid.Rows.Add(row.MovieTitle, row.TicketCount, FormatHelper.Vnd(row.Revenue), row.PaymentMethod);
        }
    }
}
