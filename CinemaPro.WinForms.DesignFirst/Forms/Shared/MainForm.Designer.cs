namespace CinemaPro.WinForms.DesignFirst.Forms.Shared;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel sidebarPanel = null!;
    private Label logoBoxLabel = null!;
    private Label appNameLabel = null!;
    private Label appSubtitleLabel = null!;
    private Label adminGroupLabel = null!;
    private Button adminDashboardButton = null!;
    private Button movieButton = null!;
    private Button roomButton = null!;
    private Button seatButton = null!;
    private Button showtimeButton = null!;
    private Button userButton = null!;
    private Button revenueButton = null!;
    private Button settingsButton = null!;
    private Label staffGroupLabel = null!;
    private Button staffDashboardButton = null!;
    private Button ticketSaleButton = null!;
    private Button ticketCheckButton = null!;
    private Button soldTicketsButton = null!;
    private Button todayShowtimeButton = null!;
    private Button logoutButton = null!;
    private Panel topbarPanel = null!;
    private Label pageTitleLabel = null!;
    private Label userNameLabel = null!;
    private Label userRoleLabel = null!;
    private Label currentTimeLabel = null!;
    private Panel contentPanel = null!;
    private Label contentPlaceholderLabel = null!;
    private StatusStrip statusStrip = null!;
    private ToolStripStatusLabel statusLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        sidebarPanel = new Panel();
        logoutButton = new Button();
        todayShowtimeButton = new Button();
        soldTicketsButton = new Button();
        ticketCheckButton = new Button();
        ticketSaleButton = new Button();
        staffDashboardButton = new Button();
        staffGroupLabel = new Label();
        settingsButton = new Button();
        revenueButton = new Button();
        userButton = new Button();
        showtimeButton = new Button();
        seatButton = new Button();
        roomButton = new Button();
        movieButton = new Button();
        adminDashboardButton = new Button();
        adminGroupLabel = new Label();
        appSubtitleLabel = new Label();
        appNameLabel = new Label();
        logoBoxLabel = new Label();
        topbarPanel = new Panel();
        currentTimeLabel = new Label();
        userRoleLabel = new Label();
        userNameLabel = new Label();
        pageTitleLabel = new Label();
        contentPanel = new Panel();
        contentPlaceholderLabel = new Label();
        statusStrip = new StatusStrip();
        statusLabel = new ToolStripStatusLabel();
        sidebarPanel.SuspendLayout();
        topbarPanel.SuspendLayout();
        contentPanel.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // sidebarPanel
        // 
        sidebarPanel.BackColor = Color.White;
        sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
        sidebarPanel.Controls.Add(logoutButton);
        sidebarPanel.Controls.Add(todayShowtimeButton);
        sidebarPanel.Controls.Add(soldTicketsButton);
        sidebarPanel.Controls.Add(ticketCheckButton);
        sidebarPanel.Controls.Add(ticketSaleButton);
        sidebarPanel.Controls.Add(staffDashboardButton);
        sidebarPanel.Controls.Add(staffGroupLabel);
        sidebarPanel.Controls.Add(settingsButton);
        sidebarPanel.Controls.Add(revenueButton);
        sidebarPanel.Controls.Add(userButton);
        sidebarPanel.Controls.Add(showtimeButton);
        sidebarPanel.Controls.Add(seatButton);
        sidebarPanel.Controls.Add(roomButton);
        sidebarPanel.Controls.Add(movieButton);
        sidebarPanel.Controls.Add(adminDashboardButton);
        sidebarPanel.Controls.Add(adminGroupLabel);
        sidebarPanel.Controls.Add(appSubtitleLabel);
        sidebarPanel.Controls.Add(appNameLabel);
        sidebarPanel.Controls.Add(logoBoxLabel);
        sidebarPanel.Dock = DockStyle.Left;
        sidebarPanel.Location = new Point(0, 0);
        sidebarPanel.Name = "sidebarPanel";
        sidebarPanel.Size = new Size(236, 720);
        sidebarPanel.TabIndex = 0;
        // 
        // logoutButton
        // 
        logoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        logoutButton.BackColor = Color.White;
        logoutButton.FlatStyle = FlatStyle.Flat;
        logoutButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        logoutButton.ForeColor = Color.FromArgb(220, 38, 38);
        logoutButton.Location = new Point(18, 662);
        logoutButton.Name = "logoutButton";
        logoutButton.Size = new Size(198, 38);
        logoutButton.TabIndex = 18;
        logoutButton.Text = "Đăng xuất";
        logoutButton.UseVisualStyleBackColor = false;
        logoutButton.Click += LogoutButton_Click;
        // 
        // todayShowtimeButton
        // 
        todayShowtimeButton.BackColor = Color.White;
        todayShowtimeButton.FlatStyle = FlatStyle.Flat;
        todayShowtimeButton.Font = new Font("Segoe UI", 9.5F);
        todayShowtimeButton.ForeColor = Color.FromArgb(45, 55, 72);
        todayShowtimeButton.Location = new Point(18, 555);
        todayShowtimeButton.Name = "todayShowtimeButton";
        todayShowtimeButton.Size = new Size(198, 34);
        todayShowtimeButton.TabIndex = 17;
        todayShowtimeButton.Text = "Lịch chiếu hôm nay";
        todayShowtimeButton.UseVisualStyleBackColor = false;
        todayShowtimeButton.Click += OpenTodayShowtimeButton_Click;
        // 
        // soldTicketsButton
        // 
        soldTicketsButton.BackColor = Color.White;
        soldTicketsButton.FlatStyle = FlatStyle.Flat;
        soldTicketsButton.Font = new Font("Segoe UI", 9.5F);
        soldTicketsButton.ForeColor = Color.FromArgb(45, 55, 72);
        soldTicketsButton.Location = new Point(18, 517);
        soldTicketsButton.Name = "soldTicketsButton";
        soldTicketsButton.Size = new Size(198, 34);
        soldTicketsButton.TabIndex = 16;
        soldTicketsButton.Text = "Vé đã bán";
        soldTicketsButton.UseVisualStyleBackColor = false;
        soldTicketsButton.Click += OpenSoldTicketsButton_Click;
        // 
        // ticketCheckButton
        // 
        ticketCheckButton.BackColor = Color.White;
        ticketCheckButton.FlatStyle = FlatStyle.Flat;
        ticketCheckButton.Font = new Font("Segoe UI", 9.5F);
        ticketCheckButton.ForeColor = Color.FromArgb(45, 55, 72);
        ticketCheckButton.Location = new Point(18, 479);
        ticketCheckButton.Name = "ticketCheckButton";
        ticketCheckButton.Size = new Size(198, 34);
        ticketCheckButton.TabIndex = 15;
        ticketCheckButton.Text = "Kiểm tra vé";
        ticketCheckButton.UseVisualStyleBackColor = false;
        ticketCheckButton.Click += OpenTicketCheckButton_Click;
        // 
        // ticketSaleButton
        // 
        ticketSaleButton.BackColor = Color.White;
        ticketSaleButton.FlatStyle = FlatStyle.Flat;
        ticketSaleButton.Font = new Font("Segoe UI", 9.5F);
        ticketSaleButton.ForeColor = Color.FromArgb(45, 55, 72);
        ticketSaleButton.Location = new Point(18, 441);
        ticketSaleButton.Name = "ticketSaleButton";
        ticketSaleButton.Size = new Size(198, 34);
        ticketSaleButton.TabIndex = 14;
        ticketSaleButton.Text = "Bán vé";
        ticketSaleButton.UseVisualStyleBackColor = false;
        ticketSaleButton.Click += OpenTicketSaleButton_Click;
        // 
        // staffDashboardButton
        // 
        staffDashboardButton.BackColor = Color.White;
        staffDashboardButton.FlatStyle = FlatStyle.Flat;
        staffDashboardButton.Font = new Font("Segoe UI", 9.5F);
        staffDashboardButton.ForeColor = Color.FromArgb(45, 55, 72);
        staffDashboardButton.Location = new Point(18, 403);
        staffDashboardButton.Name = "staffDashboardButton";
        staffDashboardButton.Size = new Size(198, 34);
        staffDashboardButton.TabIndex = 13;
        staffDashboardButton.Text = "Dashboard";
        staffDashboardButton.UseVisualStyleBackColor = false;
        staffDashboardButton.Click += OpenStaffDashboardButton_Click;
        // 
        // staffGroupLabel
        // 
        staffGroupLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        staffGroupLabel.ForeColor = Color.FromArgb(100, 116, 139);
        staffGroupLabel.Location = new Point(18, 371);
        staffGroupLabel.Name = "staffGroupLabel";
        staffGroupLabel.Size = new Size(198, 24);
        staffGroupLabel.TabIndex = 12;
        staffGroupLabel.Text = "NHÂN VIÊN";
        staffGroupLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // settingsButton
        // 
        settingsButton.BackColor = Color.White;
        settingsButton.FlatStyle = FlatStyle.Flat;
        settingsButton.Font = new Font("Segoe UI", 9.5F);
        settingsButton.ForeColor = Color.FromArgb(45, 55, 72);
        settingsButton.Location = new Point(18, 326);
        settingsButton.Name = "settingsButton";
        settingsButton.Size = new Size(198, 34);
        settingsButton.TabIndex = 11;
        settingsButton.Text = "Cài đặt";
        settingsButton.UseVisualStyleBackColor = false;
        settingsButton.Click += OpenSettingsButton_Click;
        // 
        // revenueButton
        // 
        revenueButton.BackColor = Color.White;
        revenueButton.FlatStyle = FlatStyle.Flat;
        revenueButton.Font = new Font("Segoe UI", 9.5F);
        revenueButton.ForeColor = Color.FromArgb(45, 55, 72);
        revenueButton.Location = new Point(18, 288);
        revenueButton.Name = "revenueButton";
        revenueButton.Size = new Size(198, 34);
        revenueButton.TabIndex = 10;
        revenueButton.Text = "Thống kê doanh thu";
        revenueButton.UseVisualStyleBackColor = false;
        revenueButton.Click += OpenRevenueButton_Click;
        // 
        // userButton
        // 
        userButton.BackColor = Color.White;
        userButton.FlatStyle = FlatStyle.Flat;
        userButton.Font = new Font("Segoe UI", 9.5F);
        userButton.ForeColor = Color.FromArgb(45, 55, 72);
        userButton.Location = new Point(18, 250);
        userButton.Name = "userButton";
        userButton.Size = new Size(198, 34);
        userButton.TabIndex = 9;
        userButton.Text = "Quản lý nhân viên";
        userButton.UseVisualStyleBackColor = false;
        userButton.Click += OpenUserButton_Click;
        // 
        // showtimeButton
        // 
        showtimeButton.BackColor = Color.White;
        showtimeButton.FlatStyle = FlatStyle.Flat;
        showtimeButton.Font = new Font("Segoe UI", 9.5F);
        showtimeButton.ForeColor = Color.FromArgb(45, 55, 72);
        showtimeButton.Location = new Point(18, 212);
        showtimeButton.Name = "showtimeButton";
        showtimeButton.Size = new Size(198, 34);
        showtimeButton.TabIndex = 8;
        showtimeButton.Text = "Quản lý lịch chiếu";
        showtimeButton.UseVisualStyleBackColor = false;
        showtimeButton.Click += OpenShowtimeButton_Click;
        // 
        // seatButton
        // 
        seatButton.BackColor = Color.White;
        seatButton.FlatStyle = FlatStyle.Flat;
        seatButton.Font = new Font("Segoe UI", 9.5F);
        seatButton.ForeColor = Color.FromArgb(45, 55, 72);
        seatButton.Location = new Point(18, 174);
        seatButton.Name = "seatButton";
        seatButton.Size = new Size(198, 34);
        seatButton.TabIndex = 7;
        seatButton.Text = "Quản lý ghế";
        seatButton.UseVisualStyleBackColor = false;
        seatButton.Click += OpenSeatButton_Click;
        // 
        // roomButton
        // 
        roomButton.BackColor = Color.White;
        roomButton.FlatStyle = FlatStyle.Flat;
        roomButton.Font = new Font("Segoe UI", 9.5F);
        roomButton.ForeColor = Color.FromArgb(45, 55, 72);
        roomButton.Location = new Point(18, 136);
        roomButton.Name = "roomButton";
        roomButton.Size = new Size(198, 34);
        roomButton.TabIndex = 6;
        roomButton.Text = "Quản lý phòng chiếu";
        roomButton.UseVisualStyleBackColor = false;
        roomButton.Click += OpenRoomButton_Click;
        // 
        // movieButton
        // 
        movieButton.BackColor = Color.White;
        movieButton.FlatStyle = FlatStyle.Flat;
        movieButton.Font = new Font("Segoe UI", 9.5F);
        movieButton.ForeColor = Color.FromArgb(45, 55, 72);
        movieButton.Location = new Point(18, 98);
        movieButton.Name = "movieButton";
        movieButton.Size = new Size(198, 34);
        movieButton.TabIndex = 5;
        movieButton.Text = "Quản lý phim";
        movieButton.UseVisualStyleBackColor = false;
        movieButton.Click += OpenMovieButton_Click;
        // 
        // adminDashboardButton
        // 
        adminDashboardButton.BackColor = Color.White;
        adminDashboardButton.FlatStyle = FlatStyle.Flat;
        adminDashboardButton.Font = new Font("Segoe UI", 9.5F);
        adminDashboardButton.ForeColor = Color.FromArgb(45, 55, 72);
        adminDashboardButton.Location = new Point(18, 60);
        adminDashboardButton.Name = "adminDashboardButton";
        adminDashboardButton.Size = new Size(198, 34);
        adminDashboardButton.TabIndex = 4;
        adminDashboardButton.Text = "Dashboard";
        adminDashboardButton.UseVisualStyleBackColor = false;
        adminDashboardButton.Click += OpenAdminDashboardButton_Click;
        // 
        // adminGroupLabel
        // 
        adminGroupLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        adminGroupLabel.ForeColor = Color.FromArgb(100, 116, 139);
        adminGroupLabel.Location = new Point(18, 26);
        adminGroupLabel.Name = "adminGroupLabel";
        adminGroupLabel.Size = new Size(198, 24);
        adminGroupLabel.TabIndex = 3;
        adminGroupLabel.Text = "QUẢN TRỊ";
        adminGroupLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // appSubtitleLabel
        // 
        appSubtitleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        appSubtitleLabel.Font = new Font("Segoe UI", 8.5F);
        appSubtitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        appSubtitleLabel.Location = new Point(18, 623);
        appSubtitleLabel.Name = "appSubtitleLabel";
        appSubtitleLabel.Size = new Size(198, 28);
        appSubtitleLabel.TabIndex = 2;
        appSubtitleLabel.Text = "POS & Cinema Operations";
        // 
        // appNameLabel
        // 
        appNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        appNameLabel.AutoSize = true;
        appNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        appNameLabel.ForeColor = Color.FromArgb(17, 24, 39);
        appNameLabel.Location = new Point(75, 586);
        appNameLabel.Name = "appNameLabel";
        appNameLabel.Size = new Size(130, 30);
        appNameLabel.TabIndex = 1;
        appNameLabel.Text = "CinemaPro";
        // 
        // logoBoxLabel
        // 
        logoBoxLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        logoBoxLabel.BackColor = Color.FromArgb(37, 99, 235);
        logoBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        logoBoxLabel.ForeColor = Color.White;
        logoBoxLabel.Location = new Point(18, 582);
        logoBoxLabel.Name = "logoBoxLabel";
        logoBoxLabel.Size = new Size(44, 44);
        logoBoxLabel.TabIndex = 0;
        logoBoxLabel.Text = "CP";
        logoBoxLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // topbarPanel
        // 
        topbarPanel.BackColor = Color.White;
        topbarPanel.BorderStyle = BorderStyle.FixedSingle;
        topbarPanel.Controls.Add(currentTimeLabel);
        topbarPanel.Controls.Add(userRoleLabel);
        topbarPanel.Controls.Add(userNameLabel);
        topbarPanel.Controls.Add(pageTitleLabel);
        topbarPanel.Dock = DockStyle.Top;
        topbarPanel.Location = new Point(236, 0);
        topbarPanel.Name = "topbarPanel";
        topbarPanel.Size = new Size(1044, 64);
        topbarPanel.TabIndex = 1;
        // 
        // currentTimeLabel
        // 
        currentTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        currentTimeLabel.Font = new Font("Segoe UI", 9F);
        currentTimeLabel.ForeColor = Color.FromArgb(100, 116, 139);
        currentTimeLabel.Location = new Point(836, 36);
        currentTimeLabel.Name = "currentTimeLabel";
        currentTimeLabel.Size = new Size(184, 18);
        currentTimeLabel.TabIndex = 3;
        currentTimeLabel.Text = "29/05/2026 16:30";
        currentTimeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userRoleLabel
        // 
        userRoleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        userRoleLabel.Font = new Font("Segoe UI", 9F);
        userRoleLabel.ForeColor = Color.FromArgb(37, 99, 235);
        userRoleLabel.Location = new Point(836, 18);
        userRoleLabel.Name = "userRoleLabel";
        userRoleLabel.Size = new Size(184, 18);
        userRoleLabel.TabIndex = 2;
        userRoleLabel.Text = "Staff";
        userRoleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userNameLabel
        // 
        userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        userNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        userNameLabel.ForeColor = Color.FromArgb(17, 24, 39);
        userNameLabel.Location = new Point(584, 18);
        userNameLabel.Name = "userNameLabel";
        userNameLabel.Size = new Size(246, 24);
        userNameLabel.TabIndex = 1;
        userNameLabel.Text = "Trần Thị Mai";
        userNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pageTitleLabel
        // 
        pageTitleLabel.AutoSize = true;
        pageTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        pageTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        pageTitleLabel.Location = new Point(24, 16);
        pageTitleLabel.Name = "pageTitleLabel";
        pageTitleLabel.Size = new Size(141, 32);
        pageTitleLabel.TabIndex = 0;
        pageTitleLabel.Text = "Dashboard";
        // 
        // contentPanel
        // 
        contentPanel.BackColor = Color.FromArgb(245, 247, 251);
        contentPanel.Controls.Add(contentPlaceholderLabel);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(236, 64);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(12);
        contentPanel.Size = new Size(1044, 634);
        contentPanel.TabIndex = 2;
        // 
        // contentPlaceholderLabel
        // 
        contentPlaceholderLabel.Dock = DockStyle.Fill;
        contentPlaceholderLabel.Font = new Font("Segoe UI", 13F);
        contentPlaceholderLabel.ForeColor = Color.FromArgb(100, 116, 139);
        contentPlaceholderLabel.Location = new Point(12, 12);
        contentPlaceholderLabel.Name = "contentPlaceholderLabel";
        contentPlaceholderLabel.Size = new Size(1020, 610);
        contentPlaceholderLabel.TabIndex = 0;
        contentPlaceholderLabel.Text = "Chọn chức năng từ sidebar để mở màn hình vận hành.";
        contentPlaceholderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
        statusStrip.Location = new Point(236, 698);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1044, 22);
        statusStrip.TabIndex = 3;
        statusStrip.Text = "statusStrip";
        // 
        // statusLabel
        // 
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(177, 17);
        statusLabel.Text = "CinemaPro DesignFirst sẵn sàng";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(1280, 720);
        Controls.Add(contentPanel);
        Controls.Add(statusStrip);
        Controls.Add(topbarPanel);
        Controls.Add(sidebarPanel);
        MinimumSize = new Size(1180, 700);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CinemaPro - DesignFirst";
        WindowState = FormWindowState.Maximized;
        Load += MainForm_Load;
        sidebarPanel.ResumeLayout(false);
        sidebarPanel.PerformLayout();
        topbarPanel.ResumeLayout(false);
        topbarPanel.PerformLayout();
        contentPanel.ResumeLayout(false);
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
