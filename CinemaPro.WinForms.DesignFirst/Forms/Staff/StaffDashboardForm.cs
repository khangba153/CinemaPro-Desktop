using CinemaPro.WinForms.DesignFirst.Forms.Shared;
using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class StaffDashboardForm : Form
{
    public StaffDashboardForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(todayShowtimeGrid);
    }

    private void StaffDashboardForm_Load(object? sender, EventArgs e)
    {
        var store = AppServices.CinemaStore;
        var todayShowtimes = store.GetShowtimes().Where(item => item.Date.Date == DateTime.Today).ToList();
        var todayTickets = store.GetTickets().Where(item => item.SoldAt.Date == DateTime.Today).ToList();

        todayShowtimeValueLabel.Text = todayShowtimes.Count.ToString();
        shiftTicketValueLabel.Text = todayTickets.Count.ToString();
        shiftRevenueValueLabel.Text = FormatHelper.Vnd(todayTickets.Sum(item => item.TotalAmount));
        pendingCheckValueLabel.Text = todayTickets.Count(item => item.Status == "Unused").ToString();

        todayShowtimeGrid.Rows.Clear();
        foreach (var showtime in todayShowtimes)
        {
            todayShowtimeGrid.Rows.Add(showtime.MovieTitle, showtime.RoomName, showtime.TimeText, FormatHelper.Vnd(showtime.Price), showtime.Status);
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
