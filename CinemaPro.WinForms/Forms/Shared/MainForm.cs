using CinemaPro.WinForms.Forms.Admin;
using CinemaPro.WinForms.Forms.Auth;
using CinemaPro.WinForms.Forms.Staff;
using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Session;

namespace CinemaPro.WinForms.Forms.Shared;

public sealed partial class MainForm : Form
{
    private readonly Dictionary<string, Button> _menuButtons = [];
    private Button? _activeButton;
    private Form? _currentChildForm;

    public MainForm()
    {
        InitializeComponent();
        _userLabel.Text = string.IsNullOrWhiteSpace(UserSession.FullName) ? "Nguyễn Văn Quản" : UserSession.FullName;
        _roleLabel.Text = CurrentRole;
        ConfigureSidebarMenu();
        StartClock();
        OpenDefaultDashboard();
    }

    private static string CurrentRole => string.IsNullOrWhiteSpace(UserSession.Role) ? "Admin" : UserSession.Role;

    public void OpenChildForm(Form childForm, string title) => OpenChildForm(childForm, title, "\uE80F", title);

    public void OpenChildForm(Form childForm, string title, string icon, string? activeKey = null)
    {
        if (_currentChildForm is not null)
        {
            _contentPanel.Controls.Remove(_currentChildForm);
            _currentChildForm.Close();
            _currentChildForm.Dispose();
        }

        _currentChildForm = childForm;
        UiStyleHelper.PrepareChildForm(childForm);
        _contentPanel.Controls.Add(childForm);
        _titleLabel.Text = title;
        _pageIconLabel.Text = icon;

        if (activeKey is not null && _menuButtons.TryGetValue(activeKey, out var button))
        {
            SetActiveButton(button);
        }

        childForm.Show();
    }

    private void ConfigureSidebarMenu()
    {
        _menuButtons.Clear();
        RegisterMenuButton(dashboardButton, "Dashboard", OpenDefaultDashboard);
        RegisterMenuButton(ticketSaleButton, "Bán vé", OpenStaffTicketSale);
        RegisterMenuButton(ticketCheckButton, "Kiểm tra vé", OpenStaffTicketCheck);
        RegisterMenuButton(soldTicketsButton, "Vé đã bán", () => OpenChildForm(new SoldTicketsForm(), "Quản lý vé đã bán", "\uE8A1", "Vé đã bán"));
        RegisterMenuButton(todayShowtimeButton, "Lịch chiếu hôm nay", () => OpenChildForm(new TodayShowtimeForm(), "Lịch chiếu hôm nay", "\uE787", "Lịch chiếu hôm nay"));
        RegisterMenuButton(movieButton, "Phim", () => OpenChildForm(new MovieManagementForm(), "Quản lý phim & lịch chiếu", "\uE7F4", "Phim"));
        RegisterMenuButton(showtimeButton, "Lịch chiếu", () => OpenChildForm(new ShowtimeManagementForm(), "Quản lý lịch chiếu", "\uE787", "Lịch chiếu"));
        RegisterMenuButton(roomButton, "Phòng chiếu", () => OpenChildForm(new RoomManagementForm(), "Quản lý phòng chiếu", "\uE8B7", "Phòng chiếu"));
        RegisterMenuButton(seatButton, "Ghế", () => OpenChildForm(new SeatManagementForm(), "Quản lý ghế", "\uE7F1", "Ghế"));
        RegisterMenuButton(userButton, "Nhân viên", () => OpenChildForm(new UserManagementForm(), "Quản lý nhân viên", "\uE716", "Nhân viên"));
        RegisterMenuButton(revenueButton, "Thống kê doanh thu", () => OpenChildForm(new RevenueReportForm(), "Thống kê doanh thu", "\uE9D2", "Thống kê doanh thu"));
        RegisterMenuButton(settingsButton, "Cài đặt", () => OpenChildForm(new SettingsForm(), "Cài đặt hệ thống", "\uE713", "Cài đặt"));
        ApplyRoleMenuVisibility();
        AttachMenuHover(logoutButton);
    }

    private void RegisterMenuButton(Button button, string key, Action action)
    {
        button.Tag = key;
        button.Click += (_, _) =>
        {
            SetActiveButton(button);
            action();
        };
        AttachMenuHover(button);
        _menuButtons[key] = button;
    }

    private void ApplyRoleMenuVisibility()
    {
        var isAdmin = CurrentRole == "Admin";
        ticketSaleButton.Visible = !isAdmin;
        ticketCheckButton.Visible = !isAdmin;
        soldTicketsButton.Visible = !isAdmin;
        todayShowtimeButton.Visible = !isAdmin;

        managementGroupLabel.Visible = isAdmin;
        movieButton.Visible = isAdmin;
        showtimeButton.Visible = isAdmin;
        roomButton.Visible = isAdmin;
        seatButton.Visible = isAdmin;
        userButton.Visible = isAdmin;
        reportGroupLabel.Visible = isAdmin;
        revenueButton.Visible = isAdmin;
        settingsButton.Visible = isAdmin;
    }

    private static void AttachMenuHover(Button button)
    {
        button.MouseEnter += (_, _) =>
        {
            if (button.BackColor != UiStyleHelper.SidebarActive)
            {
                button.BackColor = UiStyleHelper.SidebarHover;
            }
        };
        button.MouseLeave += (_, _) =>
        {
            if (button.BackColor != UiStyleHelper.SidebarActive)
            {
                button.BackColor = UiStyleHelper.Sidebar;
            }
        };
    }

    private void OpenDefaultDashboard()
    {
        if (CurrentRole == "Admin")
        {
            OpenChildForm(new AdminDashboardForm(), "Dashboard", "\uE80F", "Dashboard");
            return;
        }

        OpenChildForm(new StaffDashboardForm(OpenStaffTicketSale, OpenStaffTicketCheck), "Dashboard", "\uE80F", "Dashboard");
    }

    private void StartClock()
    {
        UpdateStatusTime();
        _clockTimer.Tick += ClockTimer_Tick;
        _clockTimer.Start();
    }

    private void ClockTimer_Tick(object? sender, EventArgs e) => UpdateStatusTime();

    private void UpdateStatusTime()
    {
        _statusLabel.Text = $"  ●  Đang kết nối      Máy trạm: COUNTER-01      Phiên bản: 1.0.0      {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
    }

    private void SetActiveButton(Button button)
    {
        if (_activeButton is not null)
        {
            _activeButton.BackColor = UiStyleHelper.Sidebar;
            _activeButton.ForeColor = UiStyleHelper.SidebarText;
        }

        _activeButton = button;
        _activeButton.BackColor = UiStyleHelper.SidebarActive;
        _activeButton.ForeColor = Color.White;
    }

    private void OpenStaffTicketSale() => OpenChildForm(new TicketSaleForm(), "Bán vé xem phim", "\uE8A1", "Bán vé");

    private void OpenStaffTicketCheck() => OpenChildForm(new TicketCheckForm(), "Kiểm tra vé vào rạp", "\uE8FB", "Kiểm tra vé");

    private void LogoutButton_Click(object? sender, EventArgs e) => Logout();

    private void Logout()
    {
        _clockTimer.Stop();
        UserSession.Clear();
        Close();
    }
}
