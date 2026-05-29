using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RoomManagementForm : Form
{
    public RoomManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(roomGrid);
    }

    private void RoomManagementForm_Load(object? sender, EventArgs e)
    {
        roomTypeComboBox.SelectedIndex = 0;
        LoadRooms();
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Thao tác phòng chiếu chỉ mô phỏng trên UI demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadRooms()
    {
        roomGrid.Rows.Clear();
        foreach (var room in AppServices.CinemaStore.GetRooms())
        {
            roomGrid.Rows.Add(room.RoomId, room.RoomName, room.RoomType, room.Rows, room.SeatsPerRow, room.Status);
        }
    }
}
