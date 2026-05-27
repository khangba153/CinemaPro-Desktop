using CinemaPro.WinForms.Forms.Shared;
using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Session;

namespace CinemaPro.WinForms.Forms.Auth;

public sealed partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        AcceptButton = loginButton;
        CancelButton = exitButton;
        _usernameTextBox.Focus();
    }

    private void LoginButton_Click(object? sender, EventArgs e) => Login();

    private void ExitButton_Click(object? sender, EventArgs e) => Close();

    private void Login()
    {
        var user = FakeDataProvider.TryAuthenticate(_usernameTextBox.Text.Trim(), _passwordTextBox.Text);
        if (user is null)
        {
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _passwordTextBox.SelectAll();
            _passwordTextBox.Focus();
            return;
        }

        UserSession.SetCurrentUser(user);
        Hide();
        using var mainForm = new MainForm();
        mainForm.ShowDialog(this);
        _passwordTextBox.Clear();
        Show();
        _usernameTextBox.Focus();
    }
}
