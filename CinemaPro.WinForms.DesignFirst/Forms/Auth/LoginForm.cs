namespace CinemaPro.WinForms.DesignFirst.Forms.Auth;

public partial class LoginForm : Form
{
    private readonly AuthService _authService = new();

    public LoginForm()
    {
        InitializeComponent();
        FixVietnameseText();
    }

    private void LoginButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var user = _authService.Login(usernameTextBox.Text, passwordTextBox.Text, out var message);
            if (user is null)
            {
                MessageBox.Show(message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }

            UserSession.Set(user);

            Hide();
            using (var mainForm = new MainForm())
            {
                mainForm.ShowDialog(this);
            }

            UserSession.Clear();
            passwordTextBox.Clear();
            Show();
            usernameTextBox.Focus();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Không thể đăng nhập. Vui lòng kiểm tra kết nối database.\n\n" + ex.Message,
                "Lỗi hệ thống",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void ExitButton_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void FixVietnameseText()
    {
        Text = "CinemaPro - Đăng nhập";
        brandSubtitleLabel.Text = "Hệ thống quản lý rạp chiếu phim";
        brandDescriptionLabel.Text = "Quản lý bán vé, lịch chiếu, phòng chiếu, thanh toán và kiểm tra vé trong một giao diện vận hành gọn gàng.";
        loginTitleLabel.Text = "Đăng nhập";
        loginSubtitleLabel.Text = "Đăng nhập bằng tài khoản được cấp để bắt đầu phiên vận hành.";
        loginButton.Text = "Đăng nhập";
        exitButton.Text = "Thoát";
        accountHintLabel.Text = "Demo DB: admin / 123456 hoặc staff01 / 123456. Tài khoản staff02 đang bị khóa.";
    }
}
