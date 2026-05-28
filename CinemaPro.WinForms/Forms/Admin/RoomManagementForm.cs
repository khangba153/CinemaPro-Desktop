using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class RoomManagementForm : Form
{
    private readonly List<RoomRow> _rooms;

    public RoomManagementForm()
    {
        _rooms = AppServices.CinemaStore.GetRooms().ToList();
        InitializeComponent();
        BindLookupData();
        WireEvents();
        LoadData();
    }

    private void BindLookupData()
    {
        roomTypeCombo.Items.Clear();
        roomStatusCombo.Items.Clear();
        roomTypeCombo.Items.AddRange(["2D", "3D", "IMAX", "VIP"]);
        roomStatusCombo.Items.AddRange(["Đang hoạt động", "Bảo trì"]);
        roomTypeCombo.SelectedIndex = 0;
        roomStatusCombo.SelectedIndex = 0;
    }

    private void WireEvents()
    {
        roomGrid.SelectionChanged += (_, _) => UpdateDetailFromGrid();
        addRoomButton.Click += (_, _) => MessageBox.Show("Đã thêm phòng chiếu demo.", "Quản lý phòng chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        updateRoomButton.Click += (_, _) => MessageBox.Show("Đã cập nhật thông tin phòng demo.", "Quản lý phòng chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        createSeatsButton.Click += (_, _) => MessageBox.Show("Đã tạo sơ đồ ghế demo cho phòng đang chọn.", "Quản lý phòng chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        maintenanceButton.Click += (_, _) => MessageBox.Show("Đã chuyển phòng sang trạng thái bảo trì demo.", "Quản lý phòng chiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        refreshButton.Click += (_, _) => LoadData();
        UiStyleHelper.ApplyStatusCellFormatting(roomGrid, "Status");
    }

    private void LoadData()
    {
        UiStyleHelper.ResetGridForBinding(roomGrid);

        totalRoomsValueLabel.Text = _rooms.Count.ToString();
        activeRoomsValueLabel.Text = _rooms.Count(room => room.Status != "Bảo trì").ToString();
        totalSeatsValueLabel.Text = _rooms.Sum(room => room.SeatRows * room.SeatsPerRow).ToString("N0");
        maintenanceRoomsValueLabel.Text = _rooms.Count(room => room.Status == "Bảo trì").ToString();

        roomGrid.DataSource = _rooms.Select(room => new
        {
            room.RoomId,
            room.Name,
            room.RoomType,
            room.SeatRows,
            room.SeatsPerRow,
            SeatCount = room.SeatRows * room.SeatsPerRow,
            room.Status,
            Note = room.Status == "Bảo trì" ? "Bảo trì định kỳ" : "Sẵn sàng vận hành"
        }).ToList();

        roomGrid.ClearSelection();
        roomGrid.CurrentCell = null;

        if (_rooms.Count > 0)
        {
            UpdateDetail(_rooms[0]);
        }
    }

    private void UpdateDetailFromGrid()
    {
        if (roomGrid.SelectedRows.Count == 0)
        {
            return;
        }

        var id = roomGrid.SelectedRows[0].Cells["RoomId"].Value?.ToString();
        var room = _rooms.FirstOrDefault(item => item.RoomId == id);
        if (room is not null)
        {
            UpdateDetail(room);
        }
    }

    private void UpdateDetail(RoomRow room)
    {
        roomNameTextBox.Text = room.Name;
        roomTypeCombo.SelectedItem = room.RoomType;
        rowCountTextBox.Text = room.SeatRows.ToString();
        seatsPerRowTextBox.Text = room.SeatsPerRow.ToString();
        roomStatusCombo.SelectedItem = room.Status;
        detailLabel.Text = $"Mã phòng: {room.RoomId}\nTổng ghế: {room.SeatRows * room.SeatsPerRow}\nGhi chú: {(room.Status == "Bảo trì" ? "Cần kiểm tra trước khi mở bán." : "Sẵn sàng bán vé.")}";
        RenderSeatPreview(room);
    }

    private void RenderSeatPreview(RoomRow room)
    {
        var previewRows = Math.Min(room.SeatRows, 6);
        var previewSeats = Math.Min(room.SeatsPerRow, 10);

        foreach (var label in seatPreviewPanel.Controls.OfType<Label>())
        {
            var cell = seatPreviewPanel.GetCellPosition(label);
            if (cell.Row < 0 || cell.Column < 0)
            {
                continue;
            }

            if (cell.Column == 0)
            {
                label.Visible = cell.Row < previewRows;
                continue;
            }

            label.Visible = cell.Row < previewRows && cell.Column <= previewSeats;
            label.BackColor = cell.Column % 7 == 0 ? UiStyleHelper.SeatSold : UiStyleHelper.SeatAvailable;
        }
    }
}
