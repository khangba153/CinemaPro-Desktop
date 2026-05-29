using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class TodayShowtimeForm : Form
{
    public TodayShowtimeForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(showtimeGrid);
    }

    private void TodayShowtimeForm_Load(object? sender, EventArgs e)
    {
        var showtimes = AppServices.CinemaStore.GetShowtimes().Where(item => item.Date.Date == DateTime.Today).ToList();
        showtimeCountValueLabel.Text = showtimes.Count.ToString();
        sellingValueLabel.Text = showtimes.Count(item => item.Status == "Đang bán").ToString();

        showtimeGrid.Rows.Clear();
        foreach (var showtime in showtimes)
        {
            showtimeGrid.Rows.Add(showtime.MovieTitle, showtime.RoomName, showtime.StartTime.ToString("hh\\:mm"), showtime.EndTime.ToString("hh\\:mm"), FormatHelper.Vnd(showtime.Price), showtime.Status);
        }
    }
}
