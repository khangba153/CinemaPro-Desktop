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
        roomStatusComboBox.SelectedIndex = 0;
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
                ShowResult(_roomService.UpdateRoom(_selectedRoomId, roomNameTextBox.Text, roomTypeComboBox.Text, (int)rowCountInput.Value, (int)seatPerRowInput.Value, roomStatusComboBox.Text, out var message), message);
                return;
            }

            if (sender == maintenanceButton)
            {
                var nextStatus = _selectedRoomStatus == "Maintenance" ? "Active" : "Maintenance";
                ShowResult(_roomService.SetRoomStatus(_selectedRoomId, nextStatus, out var message), message);
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
        foreach (var room in _roomService.GetRooms())
        {
            var rowIndex = roomGrid.Rows.Add(room.RoomId, room.RoomName, room.RoomType, room.Rows, room.SeatsPerRow, room.Status);
            roomGrid.Rows[rowIndex].Tag = room;
        }

        if (roomGrid.Rows.Count > 0)
        {
            roomGrid.ClearSelection();
            roomGrid.Rows[0].Selected = true;
            FillDetailFromSelectedRow();
            return;
        }

        ClearDetail();
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
        roomStatusComboBox.Text = room.Status;
        rowCountInput.Value = Math.Max(rowCountInput.Minimum, Math.Min(rowCountInput.Maximum, room.Rows));
        seatPerRowInput.Value = Math.Max(seatPerRowInput.Minimum, Math.Min(seatPerRowInput.Maximum, room.SeatsPerRow));
        maintenanceButton.Text = room.Status == "Maintenance" ? "Đưa vào hoạt động" : "Bảo trì phòng";
        maintenanceButton.ForeColor = room.Status == "Maintenance" ? Color.FromArgb(22, 163, 74) : Color.FromArgb(220, 38, 38);
    }

    private void ClearDetail()
    {
        _selectedRoomId = "";
        _selectedRoomStatus = "Active";
        roomNameTextBox.Clear();
        if (roomTypeComboBox.Items.Count > 0)
        {
            roomTypeComboBox.SelectedIndex = 0;
        }

        if (roomStatusComboBox.Items.Count > 0)
        {
            roomStatusComboBox.SelectedIndex = 0;
        }

        rowCountInput.Value = rowCountInput.Minimum;
        seatPerRowInput.Value = seatPerRowInput.Minimum;
        maintenanceButton.Text = "Bảo trì phòng";
        maintenanceButton.ForeColor = Color.FromArgb(220, 38, 38);
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
