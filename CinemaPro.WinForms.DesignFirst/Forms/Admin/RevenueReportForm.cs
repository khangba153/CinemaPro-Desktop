using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RevenueReportForm : Form
{
    public RevenueReportForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(revenueGrid);
    }

    private void RevenueReportForm_Load(object? sender, EventArgs e)
    {
        LoadReport();
    }

    private void ViewReportButton_Click(object? sender, EventArgs e)
    {
        LoadReport();
    }

    private void ExportButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Xuất báo cáo demo thành công.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadReport()
    {
        var tickets = AppServices.CinemaStore.GetTickets().Where(ticket => ticket.SoldAt.Date == reportDatePicker.Value.Date).ToList();
        var revenueRows = AppServices.CinemaStore.GetRevenueRows();

        todayRevenueValueLabel.Text = FormatHelper.Vnd(tickets.Sum(ticket => ticket.TotalAmount));
        totalTicketValueLabel.Text = tickets.Count.ToString();
        topMovieValueLabel.Text = revenueRows.OrderByDescending(row => row.TicketCount).FirstOrDefault()?.MovieTitle ?? "-";
        bestShowtimeValueLabel.Text = "19:30 - Phòng 2";

        revenueGrid.Rows.Clear();
        foreach (var row in revenueRows)
        {
            revenueGrid.Rows.Add(row.Date.ToString("dd/MM/yyyy"), row.MovieTitle, row.TicketCount, FormatHelper.Vnd(row.Revenue), row.PaymentMethod);
        }
    }
}
