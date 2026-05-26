using CinemaPro.WinForms.Helpers;

namespace CinemaPro.WinForms.Forms.Auth;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private TableLayoutPanel rootLayout;
    private WatermarkPanel brandPanel;
    private TableLayoutPanel brandLayout;
    private Label logoLabel;
    private Label brandTitleLabel;
    private Label brandCopyLabel;
    private Panel loginHost;
    private RoundedPanel loginCard;
    private TableLayoutPanel formLayout;
    private TextBox _usernameTextBox;
    private TextBox _passwordTextBox;
    private CheckBox rememberCheckBox;
    private RoundedButton loginButton;
    private RoundedButton exitButton;
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
        brandPanel = new WatermarkPanel();
        brandLayout = new TableLayoutPanel();
        logoLabel = new Label();
        brandTitleLabel = new Label();
        brandCopyLabel = new Label();
        loginHost = new Panel();
        loginCard = UiStyleHelper.CreateCard();
        formLayout = new TableLayoutPanel();
        _usernameTextBox = UiStyleHelper.CreateTextBox("Nhập tên đăng nhập");
        _passwordTextBox = UiStyleHelper.CreateTextBox("Nhập mật khẩu");
        rememberCheckBox = new CheckBox();
        loginButton = UiStyleHelper.CreateButton("Đăng nhập", UiStyleHelper.Primary);
        exitButton = UiStyleHelper.CreateOutlineButton("Thoát", UiStyleHelper.Primary);
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
        loginCard.Controls.Add(formLayout);
        loginCard.Dock = DockStyle.Fill;
        loginCard.Padding = new Padding(36, 34, 36, 28);
        //
        // formLayout
        //
        formLayout.BackColor = Color.Transparent;
        formLayout.ColumnCount = 1;
        formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        formLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "Đăng nhập hệ thống",
            Font = UiStyleHelper.TitleFont(20),
            ForeColor = UiStyleHelper.TextDark,
            TextAlign = ContentAlignment.BottomLeft
        }, 0, 0);
        formLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "Sử dụng tài khoản được cấp cho ca làm việc tại rạp.",
            Font = UiStyleHelper.SmallFont(9.75F),
            ForeColor = UiStyleHelper.TextMuted,
            TextAlign = ContentAlignment.TopLeft
        }, 0, 1);
        formLayout.Controls.Add(UiStyleHelper.FieldBlock("Tên đăng nhập", _usernameTextBox), 0, 2);
        formLayout.Controls.Add(UiStyleHelper.FieldBlock("Mật khẩu", _passwordTextBox), 0, 3);
        formLayout.Controls.Add(rememberCheckBox, 0, 4);
        formLayout.Controls.Add(loginButton, 0, 5);
        formLayout.Controls.Add(exitButton, 0, 6);
        formLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "Tài khoản demo: admin / 123456 hoặc staff01 / 123456",
            Font = UiStyleHelper.SmallFont(9F),
            ForeColor = UiStyleHelper.TextMuted,
            TextAlign = ContentAlignment.MiddleLeft
        }, 0, 7);
        formLayout.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = "Trạng thái demo: dữ liệu giả, không kết nối database",
            Font = UiStyleHelper.SectionFont(9F),
            ForeColor = UiStyleHelper.Success,
            TextAlign = ContentAlignment.MiddleCenter
        }, 0, 8);
        formLayout.Dock = DockStyle.Fill;
        formLayout.RowCount = 10;
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //
        // login controls
        //
        _passwordTextBox.UseSystemPasswordChar = true;
        rememberCheckBox.Dock = DockStyle.Fill;
        rememberCheckBox.Font = UiStyleHelper.SmallFont(9.25F);
        rememberCheckBox.ForeColor = UiStyleHelper.TextMuted;
        rememberCheckBox.Text = "Ghi nhớ đăng nhập";
        rememberCheckBox.TextAlign = ContentAlignment.MiddleLeft;
        loginButton.Dock = DockStyle.Fill;
        loginButton.Margin = new Padding(0, 0, 0, 8);
        loginButton.Click += LoginButton_Click;
        exitButton.Dock = DockStyle.Fill;
        exitButton.Margin = new Padding(0, 0, 0, 8);
        exitButton.Click += ExitButton_Click;
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
}
