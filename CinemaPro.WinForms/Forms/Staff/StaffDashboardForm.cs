using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class StaffDashboardForm : Form
{
    private readonly Action _openTicketSale;
    private readonly Action _openTicketCheck;

    public StaffDashboardForm()
        : this(static () => { }, static () => { })
    {
    }

    public StaffDashboardForm(Action openTicketSale, Action openTicketCheck)
    {
        _openTicketSale = openTicketSale;
        _openTicketCheck = openTicketCheck;
        InitializeComponent();
        ApplyRuntimeStyles();
        BindDashboard();
    }

    private void ApplyRuntimeStyles()
    {
        StyleButton(saleButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(checkButton, UiStyleHelper.Primary);
        saleButton.Click += (_, _) => _openTicketSale();
        checkButton.Click += (_, _) => _openTicketCheck();
        UiStyleHelper.ApplyStatusCellFormatting(scheduleGrid, "Status");
    }

    private void BindDashboard()
    {
        var tickets = AppServices.CinemaStore.GetTickets();
        var showtimes = AppServices.CinemaStore.GetShowtimes().Where(item => item.StartTime.Date == DateTime.Today).ToList();

        showtimeValueLabel.Text = $"{showtimes.Count} suất";
        soldTicketValueLabel.Text = tickets.Count.ToString();
        revenueValueLabel.Text = $"{tickets.Sum(t => t.Total) / 1_000_000:0.0}M";
        waitingTicketValueLabel.Text = tickets.Count(t => t.Status == "Unused").ToString();

        scheduleGrid.DataSource = showtimes.Select(showtime => new
        {
            showtime.Movie,
            showtime.Room,
            Start = showtime.StartTime.ToString("HH:mm"),
            showtime.Format,
            Price = UiStyleHelper.FormatCurrency(showtime.TicketPrice),
            showtime.Status
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
