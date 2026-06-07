namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SettingsForm : Form
{
    private readonly SettingService _settingService = new();

    public SettingsForm()
    {
        InitializeComponent();
        ConfigureRuntimeText();
        Load += SettingsForm_Load;
    }

    private void SettingsForm_Load(object? sender, EventArgs e)
    {
        LoadSettings();
    }

    private void FakeActionButton_Click(object? sender, EventArgs e)
    {
        try
        {
            if (sender == saveButton)
            {
                SaveSettings();
                return;
            }

            if (sender == backupButton)
            {
                MessageBox.Show("Chức năng sao lưu sẽ được nhóm phát triển sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (sender == restoreButton)
            {
                MessageBox.Show("Chức năng khôi phục sẽ được nhóm phát triển sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Không thể xử lý cài đặt hệ thống.\n\n" + ex.Message,
                "Lỗi database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void LoadSettings()
    {
        var settings = _settingService.GetSettings();

        cinemaNameTextBox.Text = GetValue(settings, "CinemaName", "CinemaPro Demo Cinema");
        addressTextBox.Text = GetValue(settings, "CinemaAddress", "Quận 1, TP. Hồ Chí Minh");
        hotlineTextBox.Text = GetValue(settings, "CinemaHotline", "1900 0000");
        cashCheckBox.Checked = GetBool(settings, "AllowCashPayment", true);
        vnpayCheckBox.Checked = GetBool(settings, "AllowVnPaySandbox", true);
        momoCheckBox.Checked = GetBool(settings, "AllowMomoSandbox", true);
    }

    private void SaveSettings()
    {
        if (string.IsNullOrWhiteSpace(cinemaNameTextBox.Text))
        {
            MessageBox.Show("Vui lòng nhập tên rạp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cinemaNameTextBox.Focus();
            return;
        }

        _settingService.SaveBasicSettings(
            cinemaNameTextBox.Text,
            addressTextBox.Text,
            hotlineTextBox.Text,
            cashCheckBox.Checked,
            vnpayCheckBox.Checked,
            momoCheckBox.Checked);

        MessageBox.Show("Đã lưu cài đặt hệ thống.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static string GetValue(Dictionary<string, string> settings, string key, string fallback)
    {
        return settings.TryGetValue(key, out var value) && !string.IsNullOrWhiteSpace(value)
            ? value
            : fallback;
    }

    private static bool GetBool(Dictionary<string, string> settings, string key, bool fallback)
    {
        if (!settings.TryGetValue(key, out var value))
        {
            return fallback;
        }

        return value.Equals("true", StringComparison.OrdinalIgnoreCase)
            || value.Equals("1", StringComparison.OrdinalIgnoreCase)
            || value.Equals("yes", StringComparison.OrdinalIgnoreCase);
    }

    private void ConfigureRuntimeText()
    {
        Text = "Cài đặt hệ thống";
        cashCheckBox.Text = "Tiền mặt";
        vnpayCheckBox.Text = "VNPAY Sandbox";
        momoCheckBox.Text = "MoMo Sandbox";
        saveButton.Text = "Lưu cài đặt";
        backupButton.Text = "Sao lưu";
        restoreButton.Text = "Khôi phục";
    }
}
