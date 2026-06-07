namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RevenueReportForm : Form
{
    private readonly TicketService _ticketService = new();
    private readonly ReportService _reportService = new();
    private readonly ShowtimeService _showtimeService = new();

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
        MessageBox.Show("Đã chuẩn bị dữ liệu báo cáo từ database. Chức năng xuất file sẽ được nhóm phát triển ở bước sau.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadReport()
    {
        var tickets = _ticketService.GetTickets()
            .Where(ticket => ticket.SoldAt.Date == reportDatePicker.Value.Date)
            .ToList();
        var revenueRows = _reportService.GetRevenueRows();

        todayRevenueValueLabel.Text = FormatHelper.Vnd(tickets.Sum(ticket => ticket.TotalAmount));
        totalTicketValueLabel.Text = tickets.Count.ToString();
        topMovieValueLabel.Text = revenueRows.OrderByDescending(row => row.TicketCount).FirstOrDefault()?.MovieTitle ?? "-";
        bestShowtimeValueLabel.Text = _showtimeService.GetShowtimes().OrderByDescending(item => item.Price).FirstOrDefault()?.DisplayText ?? "-";

        revenueGrid.Rows.Clear();
        foreach (var row in revenueRows)
        {
            revenueGrid.Rows.Add(row.Date.ToString("dd/MM/yyyy"), row.MovieTitle, row.TicketCount, FormatHelper.Vnd(row.Revenue), row.PaymentMethod);
        }
    }
}
