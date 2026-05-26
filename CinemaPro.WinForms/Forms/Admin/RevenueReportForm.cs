using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class RevenueReportForm : Form
{
    public RevenueReportForm()
    {
        InitializeComponent();
        ApplyRuntimeStyles();
        BindFilters();
        WireEvents();
        BindReport();
    }

    private void ApplyRuntimeStyles()
    {
        StyleButton(viewButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(exportButton, UiStyleHelper.Primary);
    }

    private void BindFilters()
    {
        movieCombo.Items.Clear();
        movieCombo.Items.Add("Tất cả phim");
        movieCombo.Items.AddRange(AppServices.CinemaStore.GetMovies().Select(item => item.Title).Cast<object>().ToArray());
        movieCombo.SelectedIndex = 0;

        paymentCombo.Items.Clear();
        paymentCombo.Items.AddRange(new object[] { "Tất cả phương thức", "Tiền mặt", "VNPAY Sandbox" });
        paymentCombo.SelectedIndex = 0;
    }

    private void WireEvents()
    {
        viewButton.Click += (_, _) => BindReport();
        exportButton.Click += (_, _) => MessageBox.Show("Demo UI: báo cáo sẽ được xuất file ở giai đoạn sau.", "Thống kê doanh thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BindReport()
    {
        var rows = AppServices.CinemaStore.GetRevenueRows();
        var todayRows = rows.Where(row => row.Date.Date == DateTime.Today).ToList();
        var bestRow = rows.OrderByDescending(row => row.TicketsSold).First();

        revenueTodayValueLabel.Text = UiStyleHelper.FormatCurrency(todayRows.Sum(row => row.Revenue));
        totalTicketValueLabel.Text = rows.Sum(row => row.TicketsSold).ToString("N0");
        bestMovieValueLabel.Text = bestRow.Movie;
        bestShowtimeValueLabel.Text = bestRow.BestShowtime;

        dailyRevenueGrid.DataSource = rows
            .GroupBy(row => row.Date.Date)
            .OrderByDescending(group => group.Key)
            .Select(group => new
            {
                Date = group.Key.ToString("dd/MM/yyyy"),
                TicketsSold = group.Sum(row => row.TicketsSold),
                Revenue = UiStyleHelper.FormatCurrency(group.Sum(row => row.Revenue))
            })
            .ToList();

        movieRevenueGrid.DataSource = rows
            .GroupBy(row => row.Movie)
            .OrderByDescending(group => group.Sum(row => row.Revenue))
            .Select(group => new
            {
                Movie = group.Key,
                TicketsSold = group.Sum(row => row.TicketsSold),
                Revenue = UiStyleHelper.FormatCurrency(group.Sum(row => row.Revenue))
            })
            .ToList();

        reportGrid.DataSource = rows.Select((row, index) => new
        {
            Date = row.Date.ToString("dd/MM/yyyy"),
            row.Movie,
            row.TicketsSold,
            Revenue = UiStyleHelper.FormatCurrency(row.Revenue),
            row.BestShowtime,
            Occupancy = $"{Math.Max(42, 88 - index * 7)}%"
        }).ToList();
    }

    private static void StyleButton(Button button, Color backColor, Color foreColor)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = backColor;
        button.ForeColor = foreColor;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }

    private static void StyleOutlineButton(Button button, Color accent)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Color.White;
        button.ForeColor = accent;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }
}
