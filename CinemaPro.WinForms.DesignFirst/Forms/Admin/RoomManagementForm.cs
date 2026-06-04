using CinemaPro.WinForms.DesignFirst.Models;
using CinemaPro.WinForms.DesignFirst.Services;
using System.Windows.Forms;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class RoomManagementForm : Form
{
    private readonly RoomService _roomService = new();
    public const string Active = "Active";
    public const string Maintenance = "Maintenance";

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
        if (!ValidateInput()) return;

        var success = _roomService.AddRoom(
            roomNameTextBox.Text,
            roomTypeComboBox.Text,
            (int)rowCountInput.Value,
            (int)seatPerRowInput.Value,
            out string message);

        MessageBox.Show(message);

        if (success)
        {
            LoadRooms();
        }
    }

    private void EditRoomButton_Click(object sender, EventArgs e)
    {
        var room = GetSelectedRoom();
        if (room == null) return;

        var success = _roomService.EditRoom(
            room.RoomId,
            roomNameTextBox.Text,
            roomTypeComboBox.Text,
            (int)rowCountInput.Value,
            (int)seatPerRowInput.Value,
            room.Status,
            out string message);

        MessageBox.Show(message);

        if (success)
        {
            LoadRooms();
        }
    }

    private void SetMaintenanceButton_Click(object sender, EventArgs e)
    {
        var room = GetSelectedRoom();
        if (room == null) return;

        bool success;
        string message;

        if (room.Status == Active)
        {
            success = _roomService.SetMaintenance(room.RoomId, out message);
        }
        else
        {
            success = _roomService.SetActive(room.RoomId, out message);
        }

        MessageBox.Show(message);

        if (success)
        {
            LoadRooms();
        }
    }

    private void LoadRooms()
    {
        string? selectedRoomId = GetSelectedRoom()?.RoomId;
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

        RestoreSelection(selectedRoomId);
    }

    private void RoomGrid_SelectionChanged(object? sender, EventArgs e)
    {
        FillDetailFromSelectedRow();
    }

    private void FillDetailFromSelectedRow()
    {
        var room = GetSelectedRoom();
        if (room == null) return;

        roomNameTextBox.Text = room.RoomName;
        roomTypeComboBox.Text = room.RoomType;

        rowCountInput.Value = Clamp(room.Rows, rowCountInput);
        seatPerRowInput.Value = Clamp(room.SeatsPerRow, seatPerRowInput);
    }

    private RoomRow? GetSelectedRoom()
    {
        if (roomGrid.SelectedRows.Count == 0)
            return null;

        return roomGrid.SelectedRows[0].Tag as RoomRow;
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(roomNameTextBox.Text))
        {
            MessageBox.Show("Tên phòng không được để trống");
            return false;
        }

        return true;
    }

    private decimal Clamp(int value, NumericUpDown control)
    {
        return Math.Max(control.Minimum, Math.Min(control.Maximum, value));
    }
    private void RestoreSelection(string? roomId)
    {
        roomGrid.ClearSelection();

        DataGridViewRow? targetRow = null;

        if (!string.IsNullOrWhiteSpace(roomId))
        {
            foreach (DataGridViewRow row in roomGrid.Rows)
            {
                if (row.Tag is RoomRow room && room.RoomId == roomId)
                {
                    targetRow = row;
                    break;
                }
            }
        }

        if (targetRow == null && roomGrid.Rows.Count > 0)
        {
            targetRow = roomGrid.Rows[0];
        }

        if (targetRow != null)
        {
            targetRow.Selected = true;
            roomGrid.CurrentCell = targetRow.Cells[0];
        }
    }
}