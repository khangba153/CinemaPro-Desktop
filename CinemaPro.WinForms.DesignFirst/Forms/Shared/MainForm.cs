namespace CinemaPro.WinForms.DesignFirst.Forms.Shared;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
    }

    public void OpenChildForm(Form childForm, string pageTitle, Button? menuButton = null)
    {
    }

    private void OpenAdminDashboardButton_Click(object? sender, EventArgs e) { }
    private void OpenMovieButton_Click(object? sender, EventArgs e) { }
    private void OpenRoomButton_Click(object? sender, EventArgs e) { }
    private void OpenSeatButton_Click(object? sender, EventArgs e) { }
    private void OpenShowtimeButton_Click(object? sender, EventArgs e) { }
    private void OpenUserButton_Click(object? sender, EventArgs e) { }
    private void OpenRevenueButton_Click(object? sender, EventArgs e) { }
    private void OpenSettingsButton_Click(object? sender, EventArgs e) { }
    private void OpenStaffDashboardButton_Click(object? sender, EventArgs e) { }
    private void OpenTicketSaleButton_Click(object? sender, EventArgs e) { }
    private void OpenTicketCheckButton_Click(object? sender, EventArgs e) { }
    private void OpenSoldTicketsButton_Click(object? sender, EventArgs e) { }
    private void OpenTodayShowtimeButton_Click(object? sender, EventArgs e) { }
    private void LogoutButton_Click(object? sender, EventArgs e) { }
}
