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

    private sealed class WatermarkPanel : Panel
    {
        public WatermarkPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var pen = new Pen(ColorTranslator.FromHtml("#DCEBFF"), 3);
            using var brush = new SolidBrush(ColorTranslator.FromHtml("#F0F7FF"));
            e.Graphics.FillEllipse(brush, -70, Height / 2 - 80, 180, 180);
            e.Graphics.DrawEllipse(pen, -70, Height / 2 - 80, 180, 180);
            e.Graphics.DrawLine(pen, 0, Height - 120, 210, Height - 54);
            e.Graphics.DrawRectangle(pen, 120, Height - 126, 90, 54);
            e.Graphics.FillEllipse(brush, Width - 145, 94, 86, 86);
            e.Graphics.DrawEllipse(pen, Width - 145, 94, 86, 86);
        }
    }
}
