using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RoomManagementForm : Form
{
    private readonly RoomService _roomService = new();
    private string _selectedRoomId = "";
    private string _selectedRoomStatus = "Active";

    public RoomManagementForm()
    {
        InitializeComponent();

        roomGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        roomGrid.MultiSelect = false;
        roomGrid.SelectionChanged += RoomGrid_SelectionChanged;
    }

    private void RoomManagementForm_Load(object? sender, EventArgs e)
    {
        LoadRooms();
    }

    private void AddRoomButton_Click(object sender, EventArgs e)
    {

    }

    private void LoadRooms()
    {
        roomGrid.Rows.Clear();
        foreach (var room in _roomService.GetRooms())
        {
            int rowIndex = roomGrid.Rows.Add(
                room.RoomId,
                room.RoomName,
                room.RoomType,
                room.Rows,
                room.SeatsPerRow,
                room.Status);
            roomGrid.Rows[rowIndex].Tag = room;
        }
       
        if (roomGrid.Rows.Count > 0)
        {
            roomGrid.ClearSelection();
            roomGrid.Rows[0].Selected = true;
            FillDetailFromSelectedRow();
        }
    }
    private void RoomGrid_SelectionChanged(object? sender, EventArgs e)
    {
        FillDetailFromSelectedRow();
    }

    private void FillDetailFromSelectedRow()
    {
        if (roomGrid.SelectedRows.Count == 0 || roomGrid.SelectedRows[0].Tag is not RoomRow room)
        {
            return;
        }

        _selectedRoomId = room.RoomId;
        _selectedRoomStatus = room.Status;
        roomNameTextBox.Text = room.RoomName;
        roomTypeComboBox.Text = room.RoomType;
        rowCountInput.Value = Math.Max(rowCountInput.Minimum, Math.Min(rowCountInput.Maximum, room.Rows));
        seatPerRowInput.Value = Math.Max(seatPerRowInput.Minimum, Math.Min(seatPerRowInput.Maximum, room.SeatsPerRow));
    }

}
