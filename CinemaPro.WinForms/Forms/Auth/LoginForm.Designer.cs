using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Auth;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private Panel brandPanel;
    private TableLayoutPanel brandLayout;
    private Label logoLabel;
    private Label brandTitleLabel;
    private Label brandCopyLabel;
    private Panel loginHost;
    private Panel loginCard;
    private TableLayoutPanel formLayout;
    private Label formTitleLabel;
    private Label formSubtitleLabel;
    private Label usernameInputLabel;
    private TextBox _usernameTextBox;
    private Label passwordInputLabel;
    private TextBox _passwordTextBox;
    private CheckBox rememberCheckBox;
    private Button loginButton;
    private Button exitButton;
    private Label demoAccountLabel;
    private Label demoStatusLabel;
    private Label footerLabel;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        rootLayout = new TableLayoutPanel();
        brandPanel = new Panel();
        brandLayout = new TableLayoutPanel();
        logoLabel = new Label();
        brandTitleLabel = new Label();
        brandCopyLabel = new Label();
        loginHost = new Panel();
        loginCard = new Panel();
        formLayout = new TableLayoutPanel();
        formTitleLabel = new Label();
        formSubtitleLabel = new Label();
        usernameInputLabel = new Label();
        _usernameTextBox = new TextBox();
        passwordInputLabel = new Label();
        _passwordTextBox = new TextBox();
        rememberCheckBox = new CheckBox();
        loginButton = new Button();
        exitButton = new Button();
        demoAccountLabel = new Label();
        demoStatusLabel = new Label();
        footerLabel = new Label();
        rootLayout.SuspendLayout();
        brandPanel.SuspendLayout();
        brandLayout.SuspendLayout();
        loginHost.SuspendLayout();
        loginCard.SuspendLayout();
        formLayout.SuspendLayout();
        SuspendLayout();
        // 
        // rootLayout
        // 
        rootLayout.BackColor = Color.FromArgb(245, 248, 252);
        rootLayout.ColumnCount = 2;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
        rootLayout.Controls.Add(brandPanel, 0, 0);
        rootLayout.Controls.Add(loginHost, 1, 0);
        rootLayout.Controls.Add(footerLabel, 0, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(3, 4, 3, 4);
        rootLayout.Name = "rootLayout";
        rootLayout.Padding = new Padding(37, 37, 37, 19);
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
        rootLayout.Size = new Size(1168, 791);
        rootLayout.TabIndex = 0;
        // 
        // brandPanel
        // 
        brandPanel.BackColor = Color.FromArgb(245, 248, 252);
        brandPanel.Controls.Add(brandLayout);
        brandPanel.Dock = DockStyle.Fill;
        brandPanel.Location = new Point(40, 41);
        brandPanel.Margin = new Padding(3, 4, 3, 4);
        brandPanel.Name = "brandPanel";
        brandPanel.Padding = new Padding(55, 72, 55, 72);
        brandPanel.Size = new Size(562, 684);
        brandPanel.TabIndex = 0;
        // 
        // brandLayout
        // 
        brandLayout.BackColor = Color.Transparent;
        brandLayout.ColumnCount = 1;
        brandLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        brandLayout.Controls.Add(logoLabel, 0, 1);
        brandLayout.Controls.Add(brandTitleLabel, 0, 2);
        brandLayout.Controls.Add(brandCopyLabel, 0, 3);
        brandLayout.Dock = DockStyle.Fill;
        brandLayout.Location = new Point(55, 72);
        brandLayout.Margin = new Padding(3, 4, 3, 4);
        brandLayout.Name = "brandLayout";
        brandLayout.RowCount = 5;
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
        brandLayout.Size = new Size(452, 540);
        brandLayout.TabIndex = 0;
        // 
        // logoLabel
        // 
        logoLabel.Dock = DockStyle.Fill;
        logoLabel.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold);
        logoLabel.ForeColor = Color.FromArgb(13, 110, 253);
        logoLabel.Location = new Point(3, 89);
        logoLabel.Name = "logoLabel";
        logoLabel.Size = new Size(446, 109);
        logoLabel.TabIndex = 0;
        logoLabel.Text = "CP";
        logoLabel.TextAlign = ContentAlignment.BottomCenter;
        // 
        // brandTitleLabel
        // 
        brandTitleLabel.Dock = DockStyle.Fill;
        brandTitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
        brandTitleLabel.ForeColor = Color.FromArgb(13, 110, 253);
        brandTitleLabel.Location = new Point(3, 198);
        brandTitleLabel.Name = "brandTitleLabel";
        brandTitleLabel.Size = new Size(446, 67);
        brandTitleLabel.TabIndex = 1;
        brandTitleLabel.Text = "CINEMAPRO";
        brandTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // brandCopyLabel
        // 
        brandCopyLabel.Dock = DockStyle.Fill;
        brandCopyLabel.Font = new Font("Segoe UI", 11F);
        brandCopyLabel.ForeColor = Color.FromArgb(100, 116, 139);
        brandCopyLabel.Location = new Point(3, 265);
        brandCopyLabel.Name = "brandCopyLabel";
        brandCopyLabel.Size = new Size(446, 101);
        brandCopyLabel.TabIndex = 2;
        brandCopyLabel.Text = "Hệ thống quản lý rạp chiếu phim\r\nBán vé, thanh toán và kiểm tra vé trong một phiên vận hành";
        brandCopyLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // loginHost
        // 
        loginHost.BackColor = Color.FromArgb(245, 248, 252);
        loginHost.Controls.Add(loginCard);
        loginHost.Dock = DockStyle.Fill;
        loginHost.Location = new Point(608, 41);
        loginHost.Margin = new Padding(3, 4, 3, 4);
        loginHost.Name = "loginHost";
        loginHost.Padding = new Padding(48);
        loginHost.Size = new Size(520, 684);
        loginHost.TabIndex = 1;
        // 
        // loginCard
        // 
        loginCard.BackColor = Color.White;
        loginCard.BorderStyle = BorderStyle.FixedSingle;
        loginCard.Controls.Add(formLayout);
        loginCard.Dock = DockStyle.Fill;
        loginCard.Location = new Point(48, 48);
        loginCard.Margin = new Padding(3, 4, 3, 4);
        loginCard.Name = "loginCard";
        loginCard.Padding = new Padding(41, 45, 41, 37);
        loginCard.Size = new Size(424, 588);
        loginCard.TabIndex = 0;
        // 
        // formLayout
        // 
        formLayout.BackColor = Color.Transparent;
        formLayout.ColumnCount = 1;
        formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        formLayout.Controls.Add(formTitleLabel, 0, 0);
        formLayout.Controls.Add(formSubtitleLabel, 0, 1);
        formLayout.Controls.Add(usernameInputLabel, 0, 2);
        formLayout.Controls.Add(_usernameTextBox, 0, 3);
        formLayout.Controls.Add(passwordInputLabel, 0, 4);
        formLayout.Controls.Add(_passwordTextBox, 0, 5);
        formLayout.Controls.Add(rememberCheckBox, 0, 6);
        formLayout.Controls.Add(loginButton, 0, 7);
        formLayout.Controls.Add(exitButton, 0, 8);
        formLayout.Controls.Add(demoAccountLabel, 0, 9);
        formLayout.Controls.Add(demoStatusLabel, 0, 10);
        formLayout.Dock = DockStyle.Fill;
        formLayout.Location = new Point(41, 45);
        formLayout.Margin = new Padding(3, 4, 3, 4);
        formLayout.Name = "formLayout";
        formLayout.RowCount = 12;
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        formLayout.Size = new Size(340, 504);
        formLayout.TabIndex = 0;
        // 
        // formTitleLabel
        // 
        formTitleLabel.Dock = DockStyle.Fill;
        formTitleLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
        formTitleLabel.ForeColor = Color.FromArgb(17, 27, 63);
        formTitleLabel.Location = new Point(3, 0);
        formTitleLabel.Name = "formTitleLabel";
        formTitleLabel.Size = new Size(334, 83);
        formTitleLabel.TabIndex = 0;
        formTitleLabel.Text = "Đăng nhập hệ thống";
        formTitleLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // formSubtitleLabel
        // 
        formSubtitleLabel.Dock = DockStyle.Fill;
        formSubtitleLabel.Font = new Font("Segoe UI", 9.75F);
        formSubtitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
        formSubtitleLabel.Location = new Point(3, 83);
        formSubtitleLabel.Name = "formSubtitleLabel";
        formSubtitleLabel.Size = new Size(334, 56);
        formSubtitleLabel.TabIndex = 1;
        formSubtitleLabel.Text = "Sử dụng tài khoản được cấp cho ca làm việc tại rạp.";
        // 
        // usernameInputLabel
        // 
        usernameInputLabel.Location = new Point(3, 139);
        usernameInputLabel.Name = "usernameInputLabel";
        usernameInputLabel.Size = new Size(41, 29);
        usernameInputLabel.TabIndex = 2;
        // 
        // _usernameTextBox
        // 
        _usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
        _usernameTextBox.Dock = DockStyle.Fill;
        _usernameTextBox.Font = new Font("Segoe UI", 10F);
        _usernameTextBox.Location = new Point(0, 168);
        _usernameTextBox.Margin = new Padding(0, 0, 0, 13);
        _usernameTextBox.Name = "_usernameTextBox";
        _usernameTextBox.PlaceholderText = "Nhập tên đăng nhập";
        _usernameTextBox.Size = new Size(340, 30);
        _usernameTextBox.TabIndex = 3;
        // 
        // passwordInputLabel
        // 
        passwordInputLabel.Location = new Point(3, 227);
        passwordInputLabel.Name = "passwordInputLabel";
        passwordInputLabel.Size = new Size(41, 29);
        passwordInputLabel.TabIndex = 4;
        // 
        // _passwordTextBox
        // 
        _passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        _passwordTextBox.Dock = DockStyle.Fill;
        _passwordTextBox.Font = new Font("Segoe UI", 10F);
        _passwordTextBox.Location = new Point(0, 256);
        _passwordTextBox.Margin = new Padding(0, 0, 0, 13);
        _passwordTextBox.Name = "_passwordTextBox";
        _passwordTextBox.PlaceholderText = "Nhập mật khẩu";
        _passwordTextBox.Size = new Size(340, 30);
        _passwordTextBox.TabIndex = 5;
        _passwordTextBox.UseSystemPasswordChar = true;
        // 
        // rememberCheckBox
        // 
        rememberCheckBox.Dock = DockStyle.Fill;
        rememberCheckBox.Font = new Font("Segoe UI", 9.25F);
        rememberCheckBox.ForeColor = Color.FromArgb(100, 116, 139);
        rememberCheckBox.Location = new Point(3, 319);
        rememberCheckBox.Margin = new Padding(3, 4, 3, 4);
        rememberCheckBox.Name = "rememberCheckBox";
        rememberCheckBox.Size = new Size(334, 43);
        rememberCheckBox.TabIndex = 6;
        rememberCheckBox.Text = "Ghi nhớ đăng nhập";
        // 
        // loginButton
        // 
        loginButton.BackColor = Color.FromArgb(13, 110, 253);
        loginButton.Cursor = Cursors.Hand;
        loginButton.Dock = DockStyle.Fill;
        loginButton.FlatAppearance.BorderSize = 0;
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        loginButton.ForeColor = Color.White;
        loginButton.Location = new Point(0, 366);
        loginButton.Margin = new Padding(0, 0, 0, 11);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(340, 53);
        loginButton.TabIndex = 7;
        loginButton.Text = "Đăng nhập";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += LoginButton_Click;
        // 
        // exitButton
        // 
        exitButton.BackColor = Color.White;
        exitButton.Cursor = Cursors.Hand;
        exitButton.Dock = DockStyle.Fill;
        exitButton.FlatAppearance.BorderColor = Color.FromArgb(155, 194, 255);
        exitButton.FlatStyle = FlatStyle.Flat;
        exitButton.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        exitButton.ForeColor = Color.FromArgb(13, 110, 253);
        exitButton.Location = new Point(0, 430);
        exitButton.Margin = new Padding(0, 0, 0, 11);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(340, 53);
        exitButton.TabIndex = 8;
        exitButton.Text = "Thoát";
        exitButton.UseVisualStyleBackColor = false;
        exitButton.Click += ExitButton_Click;
        // 
        // demoAccountLabel
        // 
        demoAccountLabel.Dock = DockStyle.Fill;
        demoAccountLabel.Font = new Font("Segoe UI", 9F);
        demoAccountLabel.ForeColor = Color.FromArgb(100, 116, 139);
        demoAccountLabel.Location = new Point(3, 494);
        demoAccountLabel.Name = "demoAccountLabel";
        demoAccountLabel.Size = new Size(334, 69);
        demoAccountLabel.TabIndex = 9;
        demoAccountLabel.Text = "Tài khoản demo: admin / 123456 hoặc staff01 / 123456";
        demoAccountLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // demoStatusLabel
        // 
        demoStatusLabel.Dock = DockStyle.Fill;
        demoStatusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        demoStatusLabel.ForeColor = Color.FromArgb(22, 163, 74);
        demoStatusLabel.Location = new Point(3, 563);
        demoStatusLabel.Name = "demoStatusLabel";
        demoStatusLabel.Size = new Size(334, 37);
        demoStatusLabel.TabIndex = 10;
        demoStatusLabel.Text = "Trạng thái demo: dữ liệu giả, không kết nối database";
        demoStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // footerLabel
        // 
        rootLayout.SetColumnSpan(footerLabel, 2);
        footerLabel.Dock = DockStyle.Fill;
        footerLabel.Font = new Font("Segoe UI", 9F);
        footerLabel.ForeColor = Color.FromArgb(100, 116, 139);
        footerLabel.Location = new Point(40, 729);
        footerLabel.Name = "footerLabel";
        footerLabel.Size = new Size(1088, 43);
        footerLabel.TabIndex = 2;
        footerLabel.Text = "Phiên bản: 1.0.0   |   © 2026 CinemaPro";
        footerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 252);
        ClientSize = new Size(1168, 791);
        Controls.Add(rootLayout);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1186, 838);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CinemaPro - Đăng nhập";
        rootLayout.ResumeLayout(false);
        brandPanel.ResumeLayout(false);
        brandLayout.ResumeLayout(false);
        loginHost.ResumeLayout(false);
        loginCard.ResumeLayout(false);
        formLayout.ResumeLayout(false);
        formLayout.PerformLayout();
        ResumeLayout(false);
    }

    private static void StyleFieldLabel(Label label, string text)
    {
        label.Dock = DockStyle.Fill;
        label.Font = UiStyleHelper.SmallFont(9.25F);
        label.ForeColor = UiStyleHelper.TextMuted;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleLeft;
    }
}
