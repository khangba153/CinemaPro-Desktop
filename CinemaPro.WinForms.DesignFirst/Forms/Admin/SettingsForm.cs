namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
    }

    private void FakeActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Cài đặt demo đã được ghi nhận trên giao diện.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
