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
        components = new System.ComponentModel.Container();
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
        _usernameTextBox.PlaceholderText = "Nhập tên đăng nhập";
        _usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
        _usernameTextBox.Font = UiStyleHelper.BodyFont(10F);
        _usernameTextBox.Height = 32;
        passwordInputLabel = new Label();
        _passwordTextBox = new TextBox();
        _passwordTextBox.PlaceholderText = "Nhập mật khẩu";
        _passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
        _passwordTextBox.Font = UiStyleHelper.BodyFont(10F);
        _passwordTextBox.Height = 32;
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
        // LoginForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = UiStyleHelper.ContentBackground;
        ClientSize = new Size(1120, 680);
        Controls.Add(rootLayout);
        Font = UiStyleHelper.BodyFont();
        MinimumSize = new Size(1040, 640);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CinemaPro - Đăng nhập";
        //
        // rootLayout
        //
        rootLayout.BackColor = UiStyleHelper.ContentBackground;
        rootLayout.ColumnCount = 2;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
        rootLayout.Controls.Add(brandPanel, 0, 0);
        rootLayout.Controls.Add(loginHost, 1, 0);
        rootLayout.Controls.Add(footerLabel, 0, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Padding = new Padding(32, 28, 32, 14);
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        rootLayout.SetColumnSpan(footerLabel, 2);
        //
        // brandPanel
        //
        brandPanel.BackColor = UiStyleHelper.ContentBackground;
        brandPanel.Controls.Add(brandLayout);
        brandPanel.Dock = DockStyle.Fill;
        brandPanel.Padding = new Padding(48, 54, 48, 54);
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
        brandLayout.RowCount = 5;
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
        brandLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 66F));
        //
        // logoLabel
        //
        logoLabel.Dock = DockStyle.Fill;
        logoLabel.Font = UiStyleHelper.TitleFont(38);
        logoLabel.ForeColor = UiStyleHelper.Primary;
        logoLabel.Text = "CP";
        logoLabel.TextAlign = ContentAlignment.BottomCenter;
        //
        // brandTitleLabel
        //
        brandTitleLabel.Dock = DockStyle.Fill;
        brandTitleLabel.Font = UiStyleHelper.TitleFont(24);
        brandTitleLabel.ForeColor = UiStyleHelper.Primary;
        brandTitleLabel.Text = "CINEMAPRO";
        brandTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // brandCopyLabel
        //
        brandCopyLabel.Dock = DockStyle.Fill;
        brandCopyLabel.Font = UiStyleHelper.BodyFont(11);
        brandCopyLabel.ForeColor = UiStyleHelper.TextMuted;
        brandCopyLabel.Text = "Hệ thống quản lý rạp chiếu phim\r\nBán vé, thanh toán và kiểm tra vé trong một phiên vận hành";
        brandCopyLabel.TextAlign = ContentAlignment.TopCenter;
        //
        // loginHost
        //
        loginHost.BackColor = UiStyleHelper.ContentBackground;
        loginHost.Controls.Add(loginCard);
        loginHost.Dock = DockStyle.Fill;
        loginHost.Padding = new Padding(42, 36, 42, 36);
        //
        // loginCard
        //
        loginCard.BackColor = Color.White;
        loginCard.BorderStyle = BorderStyle.FixedSingle;
        loginCard.Controls.Add(formLayout);
        loginCard.Dock = DockStyle.Fill;
        loginCard.Padding = new Padding(36, 34, 36, 28);
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
        formLayout.RowCount = 12;
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // login controls
        //
        formTitleLabel.Dock = DockStyle.Fill;
        formTitleLabel.Font = UiStyleHelper.TitleFont(20);
        formTitleLabel.ForeColor = UiStyleHelper.TextDark;
        formTitleLabel.Text = "Đăng nhập hệ thống";
        formTitleLabel.TextAlign = ContentAlignment.BottomLeft;
        formSubtitleLabel.Dock = DockStyle.Fill;
        formSubtitleLabel.Font = UiStyleHelper.SmallFont(9.75F);
        formSubtitleLabel.ForeColor = UiStyleHelper.TextMuted;
        formSubtitleLabel.Text = "Sử dụng tài khoản được cấp cho ca làm việc tại rạp.";
        formSubtitleLabel.TextAlign = ContentAlignment.TopLeft;
        StyleFieldLabel(usernameInputLabel, "Tên đăng nhập");
        StyleFieldLabel(passwordInputLabel, "Mật khẩu");
        _usernameTextBox.Dock = DockStyle.Fill;
        _usernameTextBox.Margin = new Padding(0, 0, 0, 10);
        _passwordTextBox.Dock = DockStyle.Fill;
        _passwordTextBox.Margin = new Padding(0, 0, 0, 10);
        _passwordTextBox.UseSystemPasswordChar = true;
        rememberCheckBox.Dock = DockStyle.Fill;
        rememberCheckBox.Font = UiStyleHelper.SmallFont(9.25F);
        rememberCheckBox.ForeColor = UiStyleHelper.TextMuted;
        rememberCheckBox.Text = "Ghi nhớ đăng nhập";
        rememberCheckBox.TextAlign = ContentAlignment.MiddleLeft;
        loginButton.Dock = DockStyle.Fill;
        loginButton.BackColor = UiStyleHelper.Primary;
        loginButton.Cursor = Cursors.Hand;
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.FlatAppearance.BorderSize = 0;
        loginButton.Font = UiStyleHelper.SectionFont(9.5F);
        loginButton.ForeColor = Color.White;
        loginButton.Margin = new Padding(0, 0, 0, 8);
        loginButton.Text = "Đăng nhập";
        loginButton.UseVisualStyleBackColor = false;
        loginButton.Click += LoginButton_Click;
        exitButton.Dock = DockStyle.Fill;
        exitButton.BackColor = Color.White;
        exitButton.Cursor = Cursors.Hand;
        exitButton.FlatStyle = FlatStyle.Flat;
        exitButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        exitButton.FlatAppearance.BorderSize = 1;
        exitButton.Font = UiStyleHelper.SectionFont(9.5F);
        exitButton.ForeColor = UiStyleHelper.Primary;
        exitButton.Margin = new Padding(0, 0, 0, 8);
        exitButton.Text = "Thoát";
        exitButton.UseVisualStyleBackColor = false;
        exitButton.Click += ExitButton_Click;
        demoAccountLabel.Dock = DockStyle.Fill;
        demoAccountLabel.Font = UiStyleHelper.SmallFont(9F);
        demoAccountLabel.ForeColor = UiStyleHelper.TextMuted;
        demoAccountLabel.Text = "Tài khoản demo: admin / 123456 hoặc staff01 / 123456";
        demoAccountLabel.TextAlign = ContentAlignment.MiddleLeft;
        demoStatusLabel.Dock = DockStyle.Fill;
        demoStatusLabel.Font = UiStyleHelper.SectionFont(9F);
        demoStatusLabel.ForeColor = UiStyleHelper.Success;
        demoStatusLabel.Text = "Trạng thái demo: dữ liệu giả, không kết nối database";
        demoStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // footerLabel
        //
        footerLabel.Dock = DockStyle.Fill;
        footerLabel.Font = UiStyleHelper.SmallFont(9F);
        footerLabel.ForeColor = UiStyleHelper.TextMuted;
        footerLabel.Text = "Phiên bản: 1.0.0   |   © 2026 CinemaPro";
        footerLabel.TextAlign = ContentAlignment.MiddleCenter;
        rootLayout.ResumeLayout(false);
        brandPanel.ResumeLayout(false);
        brandLayout.ResumeLayout(false);
        loginHost.ResumeLayout(false);
        loginCard.ResumeLayout(false);
        formLayout.ResumeLayout(false);
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
