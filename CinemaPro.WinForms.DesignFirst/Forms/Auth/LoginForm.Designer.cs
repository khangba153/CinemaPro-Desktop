namespace CinemaPro.WinForms.DesignFirst.Forms.Auth;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null!;
    private Panel brandPanel = null!;
    private Panel loginCardPanel = null!;
    private Label logoLabel = null!;
    private Label brandTitleLabel = null!;
    private Label brandSubtitleLabel = null!;
    private Label brandDescriptionLabel = null!;
    private Label loginTitleLabel = null!;
    private Label loginSubtitleLabel = null!;
    private Label usernameLabel = null!;
    private TextBox usernameTextBox = null!;
    private Label passwordLabel = null!;
    private TextBox passwordTextBox = null!;
    private Button loginButton = null!;
    private Button exitButton = null!;
    private Label accountHintLabel = null!;

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
        brandPanel = new Panel();
        logoLabel = new Label();
        brandTitleLabel = new Label();
        brandSubtitleLabel = new Label();
        brandDescriptionLabel = new Label();
        loginCardPanel = new Panel();
        accountHintLabel = new Label();
        exitButton = new Button();
        loginButton = new Button();
        passwordTextBox = new TextBox();
        passwordLabel = new Label();
        usernameTextBox = new TextBox();
        usernameLabel = new Label();
        loginSubtitleLabel = new Label();
        loginTitleLabel = new Label();
        brandPanel.SuspendLayout();
        loginCardPanel.SuspendLayout();
        SuspendLayout();
        // 
        // brandPanel
        // 
        brandPanel.BackColor = Color.FromArgb(232, 240, 255);
        brandPanel.BorderStyle = BorderStyle.FixedSingle;
        brandPanel.Controls.Add(logoLabel);
        brandPanel.Controls.Add(brandTitleLabel);
        brandPanel.Controls.Add(brandSubtitleLabel);
        brandPanel.Controls.Add(brandDescriptionLabel);
        brandPanel.Location = new Point(42, 42);
        brandPanel.Name = "brandPanel";
        brandPanel.Size = new Size(408, 520);
        brandPanel.TabIndex = 0;
        // 
        // logoLabel
        // 
        logoLabel.BackColor = Color.FromArgb(37, 99, 235);
        logoLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        logoLabel.ForeColor = Color.White;
        logoLabel.Location = new Point(40, 54);
        logoLabel.Name = "logoLabel";
        logoLabel.Size = new Size(76, 76);
        logoLabel.TabIndex = 0;
        logoLabel.Text = "CP";
        logoLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // brandTitleLabel
        // 
        brandTitleLabel.AutoSize = true;
        brandTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        brandTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        brandTitleLabel.Location = new Point(38, 158);
        brandTitleLabel.Name = "brandTitleLabel";
        brandTitleLabel.Size = new Size(187, 45);
        brandTitleLabel.TabIndex = 1;
        brandTitleLabel.Text = "CinemaPro";
        // 
        // brandSubtitleLabel
        // 
        brandSubtitleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        brandSubtitleLabel.ForeColor = Color.FromArgb(37, 99, 235);
        brandSubtitleLabel.Location = new Point(42, 218);
        brandSubtitleLabel.Name = "brandSubtitleLabel";
        brandSubtitleLabel.Size = new Size(300, 32);
        brandSubtitleLabel.TabIndex = 2;
        brandSubtitleLabel.Text = "Hệ thống quản lý rạp chiếu phim";
        // 
        // brandDescriptionLabel
        // 
        brandDescriptionLabel.Font = new Font("Segoe UI", 11F);
        brandDescriptionLabel.ForeColor = Color.FromArgb(89, 100, 117);
        brandDescriptionLabel.Location = new Point(42, 278);
        brandDescriptionLabel.Name = "brandDescriptionLabel";
        brandDescriptionLabel.Size = new Size(300, 112);
        brandDescriptionLabel.TabIndex = 3;
        brandDescriptionLabel.Text = "Quản lý bán vé, lịch chiếu, phòng chiếu, thanh toán và kiểm tra vé trong một giao diện vận hành gọn gàng.";
        // 
        // loginCardPanel
        // 
        loginCardPanel.BackColor = Color.White;
        loginCardPanel.BorderStyle = BorderStyle.FixedSingle;
        loginCardPanel.Controls.Add(accountHintLabel);
        loginCardPanel.Controls.Add(exitButton);
        loginCardPanel.Controls.Add(loginButton);
        loginCardPanel.Controls.Add(passwordTextBox);
        loginCardPanel.Controls.Add(passwordLabel);
        loginCardPanel.Controls.Add(usernameTextBox);
        loginCardPanel.Controls.Add(usernameLabel);
        loginCardPanel.Controls.Add(loginSubtitleLabel);
        loginCardPanel.Controls.Add(loginTitleLabel);
        loginCardPanel.Location = new Point(518, 72);
        loginCardPanel.Name = "loginCardPanel";
        loginCardPanel.Size = new Size(390, 462);
        loginCardPanel.TabIndex = 1;
        // 
        // accountHintLabel
        // 
        accountHintLabel.Font = new Font("Segoe UI", 9F);
        accountHintLabel.ForeColor = Color.FromArgb(89, 100, 117);
        accountHintLabel.Location = new Point(44, 355);
        accountHintLabel.Name = "accountHintLabel";
        accountHintLabel.Size = new Size(300, 54);
        accountHintLabel.TabIndex = 8;
        accountHintLabel.Text = "Demo: admin / 123456 hoặc staff01 / 123456";
        // 
        // exitButton
        // 
        exitButton.BackColor = Color.White;
        exitButton.FlatStyle = FlatStyle.Flat;
        exitButton.Font = new Font("Segoe UI", 10F);
        exitButton.ForeColor = Color.FromArgb(17, 24, 39);
        exitButton.Location = new Point(202, 295);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(142, 42);
        exitButton.TabIndex = 7;
        exitButton.Text = "Thoát";
        exitButton.UseVisualStyleBackColor = false;
        exitButton.Click += ExitButton_Click;
        // 
        // loginButton
        // 
        loginButton.BackColor = Color.FromArgb(37, 99, 235);
        loginButton.FlatAppearance.BorderSize = 0;
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        loginButton.ForeColor = Color.White;
        loginButton.Location = new Point(44, 295);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(142, 42);
        loginButton.TabIndex = 6;
        loginButton.Text = "Đăng nhập";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += LoginButton_Click;
        // 
        // passwordTextBox
        // 
        passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        passwordTextBox.Font = new Font("Segoe UI", 11F);
        passwordTextBox.Location = new Point(44, 232);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(300, 27);
        passwordTextBox.TabIndex = 5;
        passwordTextBox.UseSystemPasswordChar = true;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        passwordLabel.ForeColor = Color.FromArgb(17, 24, 39);
        passwordLabel.Location = new Point(44, 208);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(63, 17);
        passwordLabel.TabIndex = 4;
        passwordLabel.Text = "Password";
        // 
        // usernameTextBox
        // 
        usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
        usernameTextBox.Font = new Font("Segoe UI", 11F);
        usernameTextBox.Location = new Point(44, 160);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(300, 27);
        usernameTextBox.TabIndex = 3;
        usernameTextBox.Text = "staff01";
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        usernameLabel.ForeColor = Color.FromArgb(17, 24, 39);
        usernameLabel.Location = new Point(44, 136);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(68, 17);
        usernameLabel.TabIndex = 2;
        usernameLabel.Text = "Username";
        // 
        // loginSubtitleLabel
        // 
        loginSubtitleLabel.Font = new Font("Segoe UI", 9.5F);
        loginSubtitleLabel.ForeColor = Color.FromArgb(89, 100, 117);
        loginSubtitleLabel.Location = new Point(44, 82);
        loginSubtitleLabel.Name = "loginSubtitleLabel";
        loginSubtitleLabel.Size = new Size(284, 38);
        loginSubtitleLabel.TabIndex = 1;
        loginSubtitleLabel.Text = "Đăng nhập bằng tài khoản demo để bắt đầu phiên vận hành.";
        // 
        // loginTitleLabel
        // 
        loginTitleLabel.AutoSize = true;
        loginTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        loginTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        loginTitleLabel.Location = new Point(42, 38);
        loginTitleLabel.Name = "loginTitleLabel";
        loginTitleLabel.Size = new Size(138, 32);
        loginTitleLabel.TabIndex = 0;
        loginTitleLabel.Text = "Đăng nhập";
        // 
        // LoginForm
        // 
        AcceptButton = loginButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 251);
        ClientSize = new Size(950, 610);
        Controls.Add(loginCardPanel);
        Controls.Add(brandPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CinemaPro - Đăng nhập";
        brandPanel.ResumeLayout(false);
        brandPanel.PerformLayout();
        loginCardPanel.ResumeLayout(false);
        loginCardPanel.PerformLayout();
        ResumeLayout(false);
    }
}
