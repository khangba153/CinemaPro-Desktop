using CinemaPro.WinForms.DesignFirst.Forms.Shared;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.Session;

namespace CinemaPro.WinForms.DesignFirst.Forms.Auth;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object? sender, EventArgs e)
    {
        var user = AppServices.CinemaStore.Authenticate(usernameTextBox.Text, passwordTextBox.Text);
        if (user is null)
        {
            MessageBox.Show(
                "Tài khoản hoặc mật khẩu không đúng.",
                "Đăng nhập thất bại",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
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

    private void ExitButton_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
