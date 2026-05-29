using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatManagementForm : Form
{
    public SeatManagementForm()
    {
        InitializeComponent();
    }

    private void SeatManagementForm_Load(object? sender, EventArgs e)
    {
        roomComboBox.DisplayMember = "RoomName";
        roomComboBox.ValueMember = "RoomId";
        roomComboBox.DataSource = AppServices.CinemaStore.GetRooms().ToList();
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Thao tác ghế chỉ mô phỏng trên giao diện demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
