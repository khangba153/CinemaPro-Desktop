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
        BuildSidebarMenu();
        StartClock();
        OpenDefaultDashboard();
    }

    private static string CurrentRole => string.IsNullOrWhiteSpace(UserSession.Role) ? "Admin" : UserSession.Role;

    public void OpenChildForm(Form childForm, string title) => OpenChildForm(childForm, title, "\uE80F", title);

    public void OpenChildForm(Form childForm, string title, string icon, string? activeKey = null)
    {
        _currentChildForm?.Close();
        _currentChildForm?.Dispose();
        _currentChildForm = childForm;
        UiStyleHelper.PrepareChildForm(childForm);
        _contentPanel.Controls.Clear();
        _contentPanel.Controls.Add(childForm);
        _titleLabel.Text = title;
        _pageIconLabel.Text = icon;

        if (activeKey is not null && _menuButtons.TryGetValue(activeKey, out var button))
        {
            SetActiveButton(button);
        }

        childForm.Show();
    }

    private void BuildSidebarMenu()
    {
        _menuPanel.Controls.Clear();
        _menuButtons.Clear();
        AddGroupLabel("Vận hành");

        if (CurrentRole == "Admin")
        {
            AddMenuButton("Dashboard", () => OpenChildForm(new AdminDashboardForm(), "Dashboard", "\uE80F", "Dashboard"));
            AddGroupLabel("Quản lý");
            AddMenuButton("Phim", () => OpenChildForm(new MovieManagementForm(), "Quản lý phim & lịch chiếu", "\uE7F4", "Phim"));
            AddMenuButton("Lịch chiếu", () => OpenChildForm(new ShowtimeManagementForm(), "Quản lý lịch chiếu", "\uE787", "Lịch chiếu"));
            AddMenuButton("Phòng chiếu", () => OpenChildForm(new RoomManagementForm(), "Quản lý phòng chiếu", "\uE8B7", "Phòng chiếu"));
            AddMenuButton("Ghế", () => OpenChildForm(new SeatManagementForm(), "Quản lý ghế", "\uE7F1", "Ghế"));
            AddMenuButton("Nhân viên", () => OpenChildForm(new UserManagementForm(), "Quản lý nhân viên", "\uE716", "Nhân viên"));
            AddGroupLabel("Báo cáo");
            AddMenuButton("Thống kê doanh thu", () => OpenChildForm(new RevenueReportForm(), "Thống kê doanh thu", "\uE9D2", "Thống kê doanh thu"));
            AddMenuButton("Cài đặt", () => OpenChildForm(new SettingsForm(), "Cài đặt hệ thống", "\uE713", "Cài đặt"));
        }
        else
        {
            AddMenuButton("Dashboard", () => OpenChildForm(new StaffDashboardForm(OpenStaffTicketSale, OpenStaffTicketCheck), "Dashboard", "\uE80F", "Dashboard"));
            AddMenuButton("Bán vé", OpenStaffTicketSale);
            AddMenuButton("Kiểm tra vé", OpenStaffTicketCheck);
            AddMenuButton("Vé đã bán", () => OpenChildForm(new SoldTicketsForm(), "Quản lý vé đã bán", "\uE8A1", "Vé đã bán"));
            AddMenuButton("Lịch chiếu hôm nay", () => OpenChildForm(new TodayShowtimeForm(), "Lịch chiếu hôm nay", "\uE787", "Lịch chiếu hôm nay"));
        }
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

    private void AddGroupLabel(string text)
    {
        _menuPanel.Controls.Add(new Label
        {
            Width = 196,
            Height = 26,
            Text = text,
            Font = UiStyleHelper.SmallFont(8.75f),
            ForeColor = UiStyleHelper.TextMuted,
            TextAlign = ContentAlignment.BottomLeft,
            Margin = new Padding(0, 8, 0, 2)
        });
    }

    private void AddMenuButton(string text, Action action)
    {
        var button = CreateMenuButton(text);
        button.Tag = text;
        button.Click += (_, _) =>
        {
            SetActiveButton(button);
            action();
        };
        _menuButtons[text] = button;
        _menuPanel.Controls.Add(button);
    }

    private static Button CreateMenuButton(string text, bool isLogout = false)
    {
        var button = new Button
        {
            Width = 196,
            Height = 38,
            Text = text,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(18, 0, 0, 0),
            Font = UiStyleHelper.SectionFont(9.5f),
            ForeColor = isLogout ? UiStyleHelper.Danger : UiStyleHelper.SidebarText,
            BackColor = UiStyleHelper.Sidebar,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
            Margin = new Padding(0, 0, 0, 6)
        };
        button.FlatAppearance.BorderSize = 0;
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
        return button;
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
