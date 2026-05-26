using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Shared;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel shellLayout;
    private TableLayoutPanel sidebarLayout;
    private TableLayoutPanel logoLayout;
    private FlowLayoutPanel _menuPanel;
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
        _menuPanel = new FlowLayoutPanel();
        logoutButton = CreateMenuButton("Đăng xuất", true);
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
        _statusLabel = new Label();
        _clockTimer = new System.Windows.Forms.Timer(components);
        shellLayout.SuspendLayout();
        sidebarLayout.SuspendLayout();
        logoLayout.SuspendLayout();
        mainLayout.SuspendLayout();
        topbarPanel.SuspendLayout();
        userPanel.SuspendLayout();
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
        logoLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "CP",
            Font = UiStyleHelper.TitleFont(24),
            ForeColor = UiStyleHelper.Primary,
            TextAlign = ContentAlignment.BottomCenter
        }, 0, 0);
        logoLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "CINEMAPRO",
            Font = UiStyleHelper.TitleFont(12),
            ForeColor = UiStyleHelper.Primary,
            TextAlign = ContentAlignment.MiddleCenter
        }, 0, 1);
        logoLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "Rạp chiếu phim",
            Font = UiStyleHelper.SectionFont(9.5F),
            ForeColor = UiStyleHelper.Primary,
            TextAlign = ContentAlignment.TopCenter
        }, 0, 2);
        logoLayout.Dock = DockStyle.Fill;
        logoLayout.Padding = new Padding(0, 0, 0, 10);
        logoLayout.RowCount = 3;
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        logoLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
        //
        // _menuPanel
        //
        _menuPanel.AutoScroll = false;
        _menuPanel.BackColor = UiStyleHelper.Sidebar;
        _menuPanel.Dock = DockStyle.Fill;
        _menuPanel.FlowDirection = FlowDirection.TopDown;
        _menuPanel.WrapContents = false;
        //
        // logoutButton
        //
        logoutButton.Dock = DockStyle.Fill;
        logoutButton.Margin = new Padding(0, 8, 0, 8);
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
        _contentPanel.Dock = DockStyle.Fill;
        _contentPanel.Margin = Padding.Empty;
        _contentPanel.Padding = new Padding(20, 16, 20, 14);
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
        ResumeLayout(false);
    }
}
