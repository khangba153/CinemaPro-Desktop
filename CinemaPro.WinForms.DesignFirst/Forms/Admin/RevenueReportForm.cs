namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RevenueReportForm : Form
{
    private readonly TicketService _ticketService = new();
    private readonly ReportService _reportService = new();

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
        var selectedDate = reportDatePicker.Value.Date;
        var tickets = _ticketService.GetTickets()
            .Where(ticket => ticket.SoldAt.Date == selectedDate && !IsCancelled(ticket.Status))
            .ToList();
        var revenueRows = _reportService.GetRevenueRows()
            .Where(row => row.Date.Date == selectedDate)
            .ToList();
        var movieSummaries = revenueRows
            .GroupBy(row => row.MovieTitle)
            .Select(group => new MovieRevenueSummary(
                group.Key,
                group.Sum(row => row.TicketCount),
                group.Sum(row => row.Revenue)))
            .ToList();

        todayRevenueValueLabel.Text = FormatHelper.Vnd(revenueRows.Sum(row => row.Revenue));
        totalTicketValueLabel.Text = revenueRows.Sum(row => row.TicketCount).ToString();
        topMovieValueLabel.Text = movieSummaries
            .OrderByDescending(row => row.TicketCount)
            .ThenByDescending(row => row.Revenue)
            .FirstOrDefault()?.MovieTitle ?? "-";
        bestShowtimeValueLabel.Text = GetBestShowtimeText(tickets);

        revenueGrid.Rows.Clear();
        foreach (var row in revenueRows)
        {
            revenueGrid.Rows.Add(row.Date.ToString("dd/MM/yyyy"), row.MovieTitle, row.TicketCount, FormatHelper.Vnd(row.Revenue), row.PaymentMethod);
        }

        UpdateRevenueChart(movieSummaries);
    }

    private void UpdateRevenueChart(IEnumerable<MovieRevenueSummary> movieSummaries)
    {
        var bars = new[] { barMaiLabel, barDuneLabel, barAvengersLabel };
        var colors = new[]
        {
            Color.FromArgb(37, 99, 235),
            Color.FromArgb(22, 163, 74),
            Color.FromArgb(245, 158, 11)
        };
        var rows = movieSummaries
            .OrderByDescending(row => row.Revenue)
            .ThenByDescending(row => row.TicketCount)
            .Take(bars.Length)
            .ToList();

        if (rows.Count == 0)
        {
            bars[0].Visible = true;
            bars[0].Location = new Point(28, 76);
            bars[0].Size = new Size(282, 38);
            bars[0].BackColor = Color.FromArgb(148, 163, 184);
            bars[0].Text = "Chua co doanh thu trong ngay nay";

            for (var index = 1; index < bars.Length; index++)
            {
                bars[index].Visible = false;
            }

            return;
        }

        var maxRevenue = rows.Max(row => row.Revenue);

        for (var index = 0; index < bars.Length; index++)
        {
            if (index >= rows.Count)
            {
                bars[index].Visible = false;
                continue;
            }

            var row = rows[index];
            var revenue = row.Revenue;
            var width = maxRevenue <= 0
                ? 90
                : Math.Max(90, (int)Math.Round(282m * revenue / maxRevenue));

            bars[index].Visible = true;
            bars[index].Location = new Point(28, 76 + index * 60);
            bars[index].Size = new Size(width, 38);
            bars[index].BackColor = colors[index];
            bars[index].Text = $"{row.MovieTitle} - {FormatHelper.Vnd(revenue)}";
        }
    }

    private static string GetBestShowtimeText(IReadOnlyList<TicketRow> tickets)
    {
        var bestShowtime = tickets
            .Where(ticket => !string.IsNullOrWhiteSpace(ticket.ShowtimeText))
            .GroupBy(ticket => ticket.ShowtimeText)
            .Select(group => new
            {
                ShowtimeText = group.Key,
                TicketCount = group.Count()
            })
            .OrderByDescending(row => row.TicketCount)
            .FirstOrDefault();

        return bestShowtime is null
            ? "-"
            : $"{bestShowtime.ShowtimeText} ({bestShowtime.TicketCount} ve)";
    }

    private static bool IsCancelled(string status)
    {
        return status is "Canceled" or "Cancelled";
    }

    private sealed record MovieRevenueSummary(string MovieTitle, int TicketCount, decimal Revenue);
}
