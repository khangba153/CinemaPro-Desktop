namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
        BindDefaults();
        WireEvents();
    }

    private void BindDefaults()
    {
        cinemaNameTextBox.Text = "CinemaPro Center";
        addressTextBox.Text = "123 Nguyễn Văn Linh, Đà Nẵng";
        hotlineTextBox.Text = "0236 123 4567";
        emailTextBox.Text = "contact@cinemapro.vn";

        defaultPriceTextBox.Text = "90.000";
        saleWindowTextBox.Text = "30 ngày trước suất chiếu";
        ticketFormatCombo.Items.Clear();
        ticketFormatCombo.Items.AddRange(["A4 (210 x 297 mm)", "A5", "80mm thermal"]);
        ticketFormatCombo.SelectedIndex = 0;
        autoPrintCheckBox.Checked = true;

        cashCheckBox.Checked = true;
        vnpayCheckBox.Checked = true;
        momoCheckBox.Checked = false;
        transferCheckBox.Checked = false;

        themeCombo.Items.Clear();
        languageCombo.Items.Clear();
        fontSizeCombo.Items.Clear();
        themeCombo.Items.AddRange(["Sáng", "Tối"]);
        languageCombo.Items.AddRange(["Tiếng Việt", "English"]);
        fontSizeCombo.Items.AddRange(["Trung bình (M)", "Nhỏ (S)", "Lớn (L)"]);
        themeCombo.SelectedIndex = 0;
        languageCombo.SelectedIndex = 0;
        fontSizeCombo.SelectedIndex = 0;

        versionValueLabel.Text = "1.0.0";
        dataStatusValueLabel.Text = "Demo in-memory";
        databaseValueLabel.Text = "Chưa cấu hình database";
        syncValueLabel.Text = DateTime.Now.AddMinutes(-12).ToString("dd/MM/yyyy HH:mm:ss");
        workstationValueLabel.Text = Environment.MachineName;
        serverValueLabel.Text = "Chưa kết nối máy chủ";
        osValueLabel.Text = Environment.OSVersion.VersionString;
        lastBackupValueLabel.Text = DateTime.Today.AddHours(2).AddMinutes(15).ToString("dd/MM/yyyy HH:mm");
        backupSizeValueLabel.Text = "256.45 MB";
    }

    private void WireEvents()
    {
        saveSettingsButton.Click += (_, _) => MessageBox.Show("Đã lưu cấu hình demo.", "Cài đặt hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        backupButton.Click += (_, _) => MessageBox.Show("Đã tạo bản sao lưu giả lập.", "Cài đặt hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        restoreButton.Click += (_, _) => MessageBox.Show("Đây là thao tác khôi phục giả lập, không tác động dữ liệu thật.", "Cài đặt hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        testConnectionButton.Click += (_, _) => MessageBox.Show("Kết nối demo đang hoạt động.", "Cài đặt hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
