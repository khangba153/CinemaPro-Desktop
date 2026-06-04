namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class TodayShowtimeForm : Form
{
    private readonly ShowtimeService _showtimeService = new();

    public TodayShowtimeForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(showtimeGrid);
    }

    private void TodayShowtimeForm_Load(object? sender, EventArgs e)
    {
        var showtimes = _showtimeService.GetShowtimes()
            .Where(item => item.Date.Date == DateTime.Today)
            .ToList();

        showtimeCountValueLabel.Text = showtimes.Count.ToString();
        sellingValueLabel.Text = showtimes.Count(item => item.Status == "Open").ToString();

        showtimeGrid.Rows.Clear();
        foreach (var showtime in showtimes)
        {
            showtimeGrid.Rows.Add(
                showtime.MovieTitle,
                showtime.RoomName,
                showtime.StartTime.ToString("hh\\:mm"),
                showtime.EndTime.ToString("hh\\:mm"),
                FormatHelper.Vnd(showtime.Price),
                FormatHelper.ShowtimeStatusText(showtime.Status));
        }
    }
}
