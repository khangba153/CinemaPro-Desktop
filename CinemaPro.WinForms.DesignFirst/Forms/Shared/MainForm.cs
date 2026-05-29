using CinemaPro.WinForms.DesignFirst.Forms.Admin;
using CinemaPro.WinForms.DesignFirst.Forms.Staff;
using CinemaPro.WinForms.DesignFirst.Session;

namespace CinemaPro.WinForms.DesignFirst.Forms.Shared;

public partial class MainForm : Form
{
    private Button? _activeMenuButton;
    private Form? _activeChildForm;
    private readonly System.Windows.Forms.Timer _clockTimer = new();

    public MainForm()
    {
        InitializeComponent();
        _clockTimer.Interval = 1000;
        _clockTimer.Tick += (_, _) => currentTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        userNameLabel.Text = UserSession.FullName;
        userRoleLabel.Text = UserSession.Role;
        currentTimeLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        _clockTimer.Start();
        ApplyRoleMenu();

        if (UserSession.IsAdmin)
        {
            OpenAdminDashboardButton_Click(adminDashboardButton, EventArgs.Empty);
        }
        else
        {
            OpenStaffDashboardButton_Click(staffDashboardButton, EventArgs.Empty);
        }
    }

    public void OpenChildForm(Form childForm, string pageTitle, Button? menuButton = null)
    {
        _activeChildForm?.Close();
        _activeChildForm?.Dispose();
        _activeChildForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        contentPanel.Controls.Clear();
        contentPanel.Controls.Add(childForm);
        childForm.Show();

        pageTitleLabel.Text = pageTitle;
        statusLabel.Text = $"Đang mở: {pageTitle}";
        HighlightMenu(menuButton);
    }

    private void ApplyRoleMenu()
    {
        adminGroupLabel.Visible = UserSession.IsAdmin;
        adminDashboardButton.Visible = UserSession.IsAdmin;
        movieButton.Visible = UserSession.IsAdmin;
        roomButton.Visible = UserSession.IsAdmin;
        seatButton.Visible = UserSession.IsAdmin;
        showtimeButton.Visible = UserSession.IsAdmin;
        userButton.Visible = UserSession.IsAdmin;
        revenueButton.Visible = UserSession.IsAdmin;
        settingsButton.Visible = UserSession.IsAdmin;

        staffGroupLabel.Visible = UserSession.IsStaff;
        staffDashboardButton.Visible = UserSession.IsStaff;
        ticketSaleButton.Visible = UserSession.IsStaff;
        ticketCheckButton.Visible = UserSession.IsStaff;
        soldTicketsButton.Visible = UserSession.IsStaff;
        todayShowtimeButton.Visible = UserSession.IsStaff;
    }

    private void HighlightMenu(Button? button)
    {
        if (_activeMenuButton is not null)
        {
            _activeMenuButton.BackColor = Color.White;
            _activeMenuButton.ForeColor = Color.FromArgb(45, 55, 72);
        }

        _activeMenuButton = button;
        if (_activeMenuButton is not null)
        {
            _activeMenuButton.BackColor = Color.FromArgb(219, 234, 254);
            _activeMenuButton.ForeColor = Color.FromArgb(37, 99, 235);
        }
    }

    private void OpenAdminDashboardButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new AdminDashboardForm(), "Dashboard quản trị", sender as Button);
    }

    private void OpenMovieButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new MovieManagementForm(), "Quản lý phim", sender as Button);
    }

    private void OpenRoomButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new RoomManagementForm(), "Quản lý phòng chiếu", sender as Button);
    }

    private void OpenSeatButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new SeatManagementForm(), "Quản lý ghế", sender as Button);
    }

    private void OpenShowtimeButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new ShowtimeManagementForm(), "Quản lý lịch chiếu", sender as Button);
    }

    private void OpenUserButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new UserManagementForm(), "Quản lý nhân viên", sender as Button);
    }

    private void OpenRevenueButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new RevenueReportForm(), "Thống kê doanh thu", sender as Button);
    }

    private void OpenSettingsButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new SettingsForm(), "Cài đặt hệ thống", sender as Button);
    }

    private void OpenStaffDashboardButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new StaffDashboardForm(), "Dashboard nhân viên", sender as Button);
    }

    private void OpenTicketSaleButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new TicketSaleForm(), "Bán vé", sender as Button);
    }

    private void OpenTicketCheckButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new TicketCheckForm(), "Kiểm tra vé", sender as Button);
    }

    private void OpenSoldTicketsButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new SoldTicketsForm(), "Vé đã bán", sender as Button);
    }

    private void OpenTodayShowtimeButton_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new TodayShowtimeForm(), "Lịch chiếu hôm nay", sender as Button);
    }

    private void LogoutButton_Click(object? sender, EventArgs e)
    {
        _clockTimer.Stop();
        Close();
    }
}
