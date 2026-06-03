namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RoomManagementForm : Form
{
    private readonly RoomService _roomService = new();
    private string _selectedRoomId = "";
    private string _selectedRoomStatus = "Active";

    public RoomManagementForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(roomGrid);
        roomGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        roomGrid.MultiSelect = false;
        roomGrid.SelectionChanged += (_, _) => FillDetailFromSelectedRow();
    }

    private void RoomManagementForm_Load(object? sender, EventArgs e)
    {
        roomTypeComboBox.SelectedIndex = 0;
        LoadRooms();
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        try
        {
            if (sender == addRoomButton)
            {
                ShowResult(_roomService.AddRoom(roomNameTextBox.Text, roomTypeComboBox.Text, (int)rowCountInput.Value, (int)seatPerRowInput.Value, out var message), message);
                return;
            }

            if (sender == editRoomButton)
            {
                ShowResult(_roomService.UpdateRoom(_selectedRoomId, roomNameTextBox.Text, roomTypeComboBox.Text, (int)rowCountInput.Value, (int)seatPerRowInput.Value, _selectedRoomStatus, out var message), message);
                return;
            }

            if (sender == maintenanceButton)
            {
                ShowResult(_roomService.SetMaintenance(_selectedRoomId, out var message), message);
                return;
            }

            if (sender == createSeatButton)
            {
                MessageBox.Show("Mở màn Quản lý ghế để tạo sơ đồ ghế chi tiết cho phòng.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể xử lý phòng chiếu.\n\n" + ex.Message, "Lỗi database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadRooms()
    {
        roomGrid.Rows.Clear();
        foreach (var room in AppServices.CinemaStore.GetRooms())
        {
            var rowIndex = roomGrid.Rows.Add(room.RoomId, room.RoomName, room.RoomType, room.Rows, room.SeatsPerRow, room.Status);
            roomGrid.Rows[rowIndex].Tag = room;
        }

        if (roomGrid.Rows.Count > 0)
        {
            roomGrid.ClearSelection();
            roomGrid.Rows[0].Selected = true;
            FillDetailFromSelectedRow();
        }
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

    private void ShowResult(bool success, string message)
    {
        MessageBox.Show(message, success ? "Thành công" : "Không thể xử lý", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (success)
        {
            LoadRooms();
        }
    }
}
