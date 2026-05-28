using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Shared;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel shellLayout;
    private TableLayoutPanel sidebarLayout;
    private TableLayoutPanel logoLayout;
    private Label logoMarkLabel;
    private Label logoTitleLabel;
    private Label logoSubtitleLabel;
    private FlowLayoutPanel _menuPanel;
    private Label operationGroupLabel;
    private Button dashboardButton;
    private Button ticketSaleButton;
    private Button ticketCheckButton;
    private Button soldTicketsButton;
    private Button todayShowtimeButton;
    private Label managementGroupLabel;
    private Button movieButton;
    private Button showtimeButton;
    private Button roomButton;
    private Button seatButton;
    private Button userButton;
    private Label reportGroupLabel;
    private Button revenueButton;
    private Button settingsButton;
    private Button logoutButton;
    private Label sidebarStatusLabel;
    private TableLayoutPanel mainLayout;
    private Panel topbarPanel;
    private Label _pageIconLabel;
    private Label _titleLabel;
    private TableLayoutPanel userPanel;
    private Label avatarLabel;
    private Label _userLabel;
    private Label _roleLabel;
    private Panel _contentPanel;
    private Panel designerPreviewPanel;
    private TableLayoutPanel designerPreviewLayout;
    private Label designerPreviewTitleLabel;
    private Label designerPreviewSubtitleLabel;
    private Label designerPreviewStatusLabel;
    private Label _statusLabel;
    private System.Windows.Forms.Timer _clockTimer;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _clockTimer.Stop();
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        shellLayout = new TableLayoutPanel();
        sidebarLayout = new TableLayoutPanel();
        logoLayout = new TableLayoutPanel();
        logoMarkLabel = new Label();
        logoTitleLabel = new Label();
        logoSubtitleLabel = new Label();
        _menuPanel = new FlowLayoutPanel();
        operationGroupLabel = new Label();
        dashboardButton = new Button();
        ticketSaleButton = new Button();
        ticketCheckButton = new Button();
        soldTicketsButton = new Button();
        todayShowtimeButton = new Button();
        managementGroupLabel = new Label();
        movieButton = new Button();
        showtimeButton = new Button();
        roomButton = new Button();
        seatButton = new Button();
        userButton = new Button();
        reportGroupLabel = new Label();
        revenueButton = new Button();
        settingsButton = new Button();
        logoutButton = new Button();
        sidebarStatusLabel = new Label();
        mainLayout = new TableLayoutPanel();
        topbarPanel = new Panel();
        _pageIconLabel = new Label();
        _titleLabel = new Label();
        userPanel = new TableLayoutPanel();
        avatarLabel = new Label();
        _userLabel = new Label();
        _roleLabel = new Label();
        _contentPanel = new Panel();
        designerPreviewPanel = new Panel();
        designerPreviewLayout = new TableLayoutPanel();
        designerPreviewTitleLabel = new Label();
        designerPreviewSubtitleLabel = new Label();
        designerPreviewStatusLabel = new Label();
        _statusLabel = new Label();
        _clockTimer = new System.Windows.Forms.Timer(components);
        shellLayout.SuspendLayout();
        sidebarLayout.SuspendLayout();
        logoLayout.SuspendLayout();
        mainLayout.SuspendLayout();
        topbarPanel.SuspendLayout();
        userPanel.SuspendLayout();
        _contentPanel.SuspendLayout();
        designerPreviewPanel.SuspendLayout();
        designerPreviewLayout.SuspendLayout();
        SuspendLayout();
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1366, 768);
        Controls.Add(shellLayout);
        Font = UiStyleHelper.BodyFont();
        MinimumSize = new Size(1180, 720);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CinemaPro - Phần mềm đặt vé, thanh toán và kiểm tra vé xem phim";
        //
        // shellLayout
        //
        shellLayout.BackColor = UiStyleHelper.ContentBackground;
        shellLayout.ColumnCount = 2;
        shellLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        shellLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        shellLayout.Controls.Add(sidebarLayout, 0, 0);
        shellLayout.Controls.Add(mainLayout, 1, 0);
        shellLayout.Dock = DockStyle.Fill;
        shellLayout.Margin = Padding.Empty;
        shellLayout.RowCount = 1;
        shellLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // sidebarLayout
        //
        sidebarLayout.BackColor = UiStyleHelper.Sidebar;
        sidebarLayout.ColumnCount = 1;
        sidebarLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        sidebarLayout.Controls.Add(logoLayout, 0, 0);
        sidebarLayout.Controls.Add(_menuPanel, 0, 1);
        sidebarLayout.Controls.Add(logoutButton, 0, 2);
        sidebarLayout.Controls.Add(sidebarStatusLabel, 0, 3);
        sidebarLayout.Dock = DockStyle.Fill;
        sidebarLayout.Margin = Padding.Empty;
        sidebarLayout.Padding = new Padding(10, 18, 10, 12);
        sidebarLayout.RowCount = 4;
        sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
        sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
        sidebarLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        //
        // logoLayout
        //
        logoLayout.BackColor = UiStyleHelper.Sidebar;
        logoLayout.ColumnCount = 1;
        logoLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        logoLayout.Controls.Add(logoMarkLabel, 0, 0);
        logoLayout.Controls.Add(logoTitleLabel, 0, 1);
        logoLayout.Controls.Add(logoSubtitleLabel, 0, 2);
        logoLayout.Dock = DockStyle.Fill;
        logoLayout.Padding = new Padding(0, 0, 0, 10);
        logoLayout.RowCount = 3;
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        logoMarkLabel.Dock = DockStyle.Fill;
        logoMarkLabel.Font = UiStyleHelper.TitleFont(24);
        logoMarkLabel.ForeColor = UiStyleHelper.Primary;
        logoMarkLabel.Text = "CP";
        logoMarkLabel.TextAlign = ContentAlignment.BottomCenter;
        logoTitleLabel.Dock = DockStyle.Fill;
        logoTitleLabel.Font = UiStyleHelper.TitleFont(12);
        logoTitleLabel.ForeColor = UiStyleHelper.Primary;
        logoTitleLabel.Text = "CINEMAPRO";
        logoTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        logoSubtitleLabel.Dock = DockStyle.Fill;
        logoSubtitleLabel.Font = UiStyleHelper.SectionFont(9.5F);
        logoSubtitleLabel.ForeColor = UiStyleHelper.Primary;
        logoSubtitleLabel.Text = "Rạp chiếu phim";
        logoSubtitleLabel.TextAlign = ContentAlignment.TopCenter;
        //
        // _menuPanel
        //
        _menuPanel.AutoScroll = false;
        _menuPanel.BackColor = UiStyleHelper.Sidebar;
        _menuPanel.Dock = DockStyle.Fill;
        _menuPanel.FlowDirection = FlowDirection.TopDown;
        _menuPanel.Controls.Add(operationGroupLabel);
        _menuPanel.Controls.Add(dashboardButton);
        _menuPanel.Controls.Add(ticketSaleButton);
        _menuPanel.Controls.Add(ticketCheckButton);
        _menuPanel.Controls.Add(soldTicketsButton);
        _menuPanel.Controls.Add(todayShowtimeButton);
        _menuPanel.Controls.Add(managementGroupLabel);
        _menuPanel.Controls.Add(movieButton);
        _menuPanel.Controls.Add(showtimeButton);
        _menuPanel.Controls.Add(roomButton);
        _menuPanel.Controls.Add(seatButton);
        _menuPanel.Controls.Add(userButton);
        _menuPanel.Controls.Add(reportGroupLabel);
        _menuPanel.Controls.Add(revenueButton);
        _menuPanel.Controls.Add(settingsButton);
        _menuPanel.WrapContents = false;
        StyleGroupLabel(operationGroupLabel, "Vận hành");
        StyleMenuButton(dashboardButton, "Dashboard");
        StyleMenuButton(ticketSaleButton, "Bán vé");
        StyleMenuButton(ticketCheckButton, "Kiểm tra vé");
        StyleMenuButton(soldTicketsButton, "Vé đã bán");
        StyleMenuButton(todayShowtimeButton, "Lịch chiếu hôm nay");
        StyleGroupLabel(managementGroupLabel, "Quản lý");
        StyleMenuButton(movieButton, "Phim");
        StyleMenuButton(showtimeButton, "Lịch chiếu");
        StyleMenuButton(roomButton, "Phòng chiếu");
        StyleMenuButton(seatButton, "Ghế");
        StyleMenuButton(userButton, "Nhân viên");
        StyleGroupLabel(reportGroupLabel, "Báo cáo");
        StyleMenuButton(revenueButton, "Thống kê doanh thu");
        StyleMenuButton(settingsButton, "Cài đặt");
        //
        // logoutButton
        //
        logoutButton.Dock = DockStyle.Fill;
        logoutButton.Margin = new Padding(0, 8, 0, 8);
        StyleMenuButton(logoutButton, "Đăng xuất", true);
        logoutButton.Click += LogoutButton_Click;
        //
        // sidebarStatusLabel
        //
        sidebarStatusLabel.Dock = DockStyle.Fill;
        sidebarStatusLabel.Font = UiStyleHelper.SmallFont(9F);
        sidebarStatusLabel.ForeColor = UiStyleHelper.Success;
        sidebarStatusLabel.Text = "●  Đang kết nối";
        sidebarStatusLabel.TextAlign = ContentAlignment.BottomLeft;
        //
        // mainLayout
        //
        mainLayout.BackColor = UiStyleHelper.ContentBackground;
        mainLayout.ColumnCount = 1;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayout.Controls.Add(topbarPanel, 0, 0);
        mainLayout.Controls.Add(_contentPanel, 0, 1);
        mainLayout.Controls.Add(_statusLabel, 0, 2);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Margin = Padding.Empty;
        mainLayout.RowCount = 3;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        //
        // topbarPanel
        //
        topbarPanel.BackColor = Color.White;
        topbarPanel.Controls.Add(userPanel);
        topbarPanel.Controls.Add(_titleLabel);
        topbarPanel.Controls.Add(_pageIconLabel);
        topbarPanel.Dock = DockStyle.Fill;
        topbarPanel.Margin = Padding.Empty;
        topbarPanel.Padding = new Padding(22, 8, 18, 8);
        //
        // _pageIconLabel
        //
        _pageIconLabel.Dock = DockStyle.Left;
        _pageIconLabel.Font = UiStyleHelper.IconFont(22F);
        _pageIconLabel.ForeColor = UiStyleHelper.Primary;
        _pageIconLabel.Text = "\uE80F";
        _pageIconLabel.TextAlign = ContentAlignment.MiddleLeft;
        _pageIconLabel.Visible = false;
        _pageIconLabel.Width = 0;
        //
        // _titleLabel
        //
        _titleLabel.Dock = DockStyle.Left;
        _titleLabel.Font = UiStyleHelper.TitleFont(19F);
        _titleLabel.ForeColor = UiStyleHelper.TextDark;
        _titleLabel.Text = "Dashboard";
        _titleLabel.TextAlign = ContentAlignment.MiddleLeft;
        _titleLabel.Width = 650;
        //
        // userPanel
        //
        userPanel.BackColor = Color.White;
        userPanel.ColumnCount = 2;
        userPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
        userPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        userPanel.Controls.Add(avatarLabel, 0, 0);
        userPanel.Controls.Add(_userLabel, 1, 0);
        userPanel.Controls.Add(_roleLabel, 1, 1);
        userPanel.Dock = DockStyle.Right;
        userPanel.RowCount = 2;
        userPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        userPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        userPanel.Width = 230;
        userPanel.SetRowSpan(avatarLabel, 2);
        //
        // avatarLabel
        //
        avatarLabel.BackColor = ColorTranslator.FromHtml("#EAF3FF");
        avatarLabel.Dock = DockStyle.Fill;
        avatarLabel.Font = UiStyleHelper.IconFont(20F);
        avatarLabel.ForeColor = UiStyleHelper.Primary;
        avatarLabel.Margin = new Padding(0, 2, 8, 2);
        avatarLabel.Text = "\uE77B";
        avatarLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // _userLabel
        //
        _userLabel.AutoEllipsis = true;
        _userLabel.Dock = DockStyle.Fill;
        _userLabel.Font = UiStyleHelper.SectionFont(9.5F);
        _userLabel.ForeColor = UiStyleHelper.TextDark;
        _userLabel.Text = "Nguyễn Văn Quản";
        _userLabel.TextAlign = ContentAlignment.BottomLeft;
        //
        // _roleLabel
        //
        _roleLabel.AutoEllipsis = true;
        _roleLabel.Dock = DockStyle.Fill;
        _roleLabel.Font = UiStyleHelper.SmallFont(9F);
        _roleLabel.ForeColor = UiStyleHelper.Primary;
        _roleLabel.Text = "Admin";
        _roleLabel.TextAlign = ContentAlignment.TopLeft;
        //
        // _contentPanel
        //
        _contentPanel.BackColor = UiStyleHelper.ContentBackground;
        _contentPanel.Controls.Add(designerPreviewPanel);
        _contentPanel.Dock = DockStyle.Fill;
        _contentPanel.Margin = Padding.Empty;
        _contentPanel.Padding = new Padding(20, 16, 20, 14);
        //
        // designerPreviewPanel
        //
        designerPreviewPanel.BackColor = Color.White;
        designerPreviewPanel.BorderStyle = BorderStyle.FixedSingle;
        designerPreviewPanel.Controls.Add(designerPreviewLayout);
        designerPreviewPanel.Dock = DockStyle.Fill;
        designerPreviewPanel.Padding = new Padding(28);
        //
        // designerPreviewLayout
        //
        designerPreviewLayout.ColumnCount = 1;
        designerPreviewLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        designerPreviewLayout.Controls.Add(designerPreviewTitleLabel, 0, 0);
        designerPreviewLayout.Controls.Add(designerPreviewSubtitleLabel, 0, 1);
        designerPreviewLayout.Controls.Add(designerPreviewStatusLabel, 0, 2);
        designerPreviewLayout.Dock = DockStyle.Fill;
        designerPreviewLayout.RowCount = 4;
        designerPreviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        designerPreviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        designerPreviewLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        designerPreviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // designerPreviewTitleLabel
        //
        designerPreviewTitleLabel.Dock = DockStyle.Fill;
        designerPreviewTitleLabel.Font = UiStyleHelper.TitleFont(18F);
        designerPreviewTitleLabel.ForeColor = UiStyleHelper.TextDark;
        designerPreviewTitleLabel.Text = "Khu vực hiển thị form chức năng";
        designerPreviewTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // designerPreviewSubtitleLabel
        //
        designerPreviewSubtitleLabel.Dock = DockStyle.Fill;
        designerPreviewSubtitleLabel.Font = UiStyleHelper.BodyFont(10F);
        designerPreviewSubtitleLabel.ForeColor = UiStyleHelper.TextMuted;
        designerPreviewSubtitleLabel.Text = "Khi chạy chương trình, Dashboard/Bán vé/Kiểm tra vé sẽ mở trực tiếp trong vùng này.";
        designerPreviewSubtitleLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // designerPreviewStatusLabel
        //
        designerPreviewStatusLabel.BackColor = ColorTranslator.FromHtml("#F0F6FF");
        designerPreviewStatusLabel.Dock = DockStyle.Fill;
        designerPreviewStatusLabel.Font = UiStyleHelper.SectionFont(10F);
        designerPreviewStatusLabel.ForeColor = UiStyleHelper.Primary;
        designerPreviewStatusLabel.Padding = new Padding(16, 0, 16, 0);
        designerPreviewStatusLabel.Text = "Designer preview: sidebar + topbar + content shell đã sẵn sàng";
        designerPreviewStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // _statusLabel
        //
        _statusLabel.BackColor = Color.White;
        _statusLabel.Dock = DockStyle.Fill;
        _statusLabel.Font = UiStyleHelper.SmallFont(9F);
        _statusLabel.ForeColor = UiStyleHelper.TextMuted;
        _statusLabel.Margin = Padding.Empty;
        _statusLabel.Text = "  ●  Demo in-memory      Máy trạm: COUNTER-01      Phiên bản: 1.0.0";
        _statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // _clockTimer
        //
        _clockTimer.Interval = 1000;
        shellLayout.ResumeLayout(false);
        sidebarLayout.ResumeLayout(false);
        logoLayout.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        topbarPanel.ResumeLayout(false);
        userPanel.ResumeLayout(false);
        _contentPanel.ResumeLayout(false);
        designerPreviewPanel.ResumeLayout(false);
        designerPreviewLayout.ResumeLayout(false);
        ResumeLayout(false);
    }

    private static void StyleGroupLabel(Label label, string text)
    {
        label.Font = UiStyleHelper.SmallFont(8.75F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Height = 26;
        label.Margin = new Padding(0, 8, 0, 2);
        label.Text = text;
        label.TextAlign = ContentAlignment.BottomLeft;
        label.Width = 196;
    }

    private static void StyleMenuButton(Button button, string text, bool isLogout = false)
    {
        button.BackColor = UiStyleHelper.Sidebar;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.Font = UiStyleHelper.SectionFont(9.5F);
        button.ForeColor = isLogout ? UiStyleHelper.Danger : UiStyleHelper.SidebarText;
        button.Height = 38;
        button.Margin = new Padding(0, 0, 0, 6);
        button.Padding = new Padding(18, 0, 0, 0);
        button.Text = text;
        button.TextAlign = ContentAlignment.MiddleLeft;
        button.UseVisualStyleBackColor = false;
        button.Width = 196;
    }
}
