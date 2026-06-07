namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class StaffDashboardForm : Form
{
    private readonly ShowtimeService _showtimeService = new();
    private readonly TicketService _ticketService = new();

    public StaffDashboardForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(todayShowtimeGrid);
    }

    private void StaffDashboardForm_Load(object? sender, EventArgs e)
    {
        var todayShowtimes = _showtimeService.GetShowtimes().Where(item => item.Date.Date == DateTime.Today).ToList();
        var todayTickets = _ticketService.GetTickets().Where(item => item.SoldAt.Date == DateTime.Today).ToList();

        todayShowtimeValueLabel.Text = todayShowtimes.Count.ToString();
        shiftTicketValueLabel.Text = todayTickets.Count.ToString();
        shiftRevenueValueLabel.Text = FormatHelper.Vnd(todayTickets.Sum(item => item.TotalAmount));
        pendingCheckValueLabel.Text = todayTickets.Count(item => item.Status == "Unused").ToString();

        todayShowtimeGrid.Rows.Clear();
        foreach (var showtime in todayShowtimes)
        {
            todayShowtimeGrid.Rows.Add(
                showtime.MovieTitle,
                showtime.RoomName,
                showtime.TimeText,
                FormatHelper.Vnd(showtime.Price),
                FormatHelper.ShowtimeStatusText(showtime.Status));
        }
    }

    private void SaleButton_Click(object? sender, EventArgs e)
    {
        if (FindForm() is MainForm mainForm)
        {
            mainForm.OpenChildForm(new TicketSaleForm(), "Bán vé");
        }
    }

    private void CheckButton_Click(object? sender, EventArgs e)
    {
        if (FindForm() is MainForm mainForm)
        {
            mainForm.OpenChildForm(new TicketCheckForm(), "Kiểm tra vé");
        }
    }
}
