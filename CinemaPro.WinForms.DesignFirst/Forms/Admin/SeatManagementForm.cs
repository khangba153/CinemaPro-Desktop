namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatManagementForm : Form
{
    private readonly RoomService _roomService = new();
    private readonly SeatService _seatService = new();
    private SeatInfo? _selectedSeat;

    public SeatManagementForm()
    {
        InitializeComponent();
        seatPanel.AutoScroll = true;
    }

    private void SeatManagementForm_Load(object? sender, EventArgs e)
    {
        roomComboBox.DisplayMember = nameof(RoomRow.RoomName);
        roomComboBox.ValueMember = nameof(RoomRow.RoomId);
        roomComboBox.DataSource = _roomService.GetRooms().ToList();

        FixRuntimeText();
        FillRoomSizeInputs();
        RenderSeatMap();
    }

    private void RoomComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        _selectedSeat = null;
        FillRoomSizeInputs();
        RenderSeatMap();
    }

    private void FillRoomSizeInputs()
    {
        if (roomComboBox.SelectedItem is not RoomRow room)
        {
            rowCountTextBox.Text = "";
            columnCountTextBox.Text = "";
            return;
        }

        rowCountTextBox.Text = room.Rows.ToString();
        columnCountTextBox.Text = room.SeatsPerRow.ToString();
    }

    private void CreateLayoutButton_Click(object? sender, EventArgs e)
    {
        if (roomComboBox.SelectedItem is not RoomRow room)
        {
            MessageBox.Show("Vui lòng chọn phòng chiếu.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryReadLayoutSize(out var rowCount, out var columnCount))
        {
            return;
        }

        var existingSeats = _seatService.GetSeats(room.RoomId).ToList();
        using var builderForm = new SeatLayoutBuilderForm(room.RoomId, room.RoomName, rowCount, columnCount, existingSeats);

        if (builderForm.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        _seatService.UpdateRoomSeatLayout(room.RoomId, rowCount, columnCount, builderForm.CreatedSeats);
        room.Rows = rowCount;
        room.SeatsPerRow = columnCount;
        FillRoomSizeInputs();
        RenderSeatMap();

        MessageBox.Show("Đã cập nhật sơ đồ ghế cho phòng chiếu.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private bool TryReadLayoutSize(out int rowCount, out int columnCount)
    {
        rowCount = 0;
        columnCount = 0;

        if (!int.TryParse(rowCountTextBox.Text.Trim(), out rowCount)
            || !int.TryParse(columnCountTextBox.Text.Trim(), out columnCount))
        {
            MessageBox.Show("Số hàng và số cột phải là số nguyên.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (rowCount < 1 || rowCount > 20 || columnCount < 1 || columnCount > 24)
        {
            MessageBox.Show("Số hàng phải từ 1-20 và số cột phải từ 1-24.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        return true;
    }

    private void RefreshButton_Click(object? sender, EventArgs e)
    {
        _selectedSeat = null;
        FillRoomSizeInputs();
        RenderSeatMap();
    }

    private void RenderSeatMap()
    {
        foreach (var button in seatPanel.Controls.OfType<Button>().ToList())
        {
            seatPanel.Controls.Remove(button);
            button.Dispose();
        }

        if (roomComboBox.SelectedItem is not RoomRow room)
        {
            return;
        }

        var seats = _seatService
            .GetSeats(room.RoomId)
            .OrderBy(seat => seat.RowIndex)
            .ThenBy(seat => seat.ColumnIndex)
            .ToList();

        const int gap = 8;
        const int buttonWidth = 54;
        const int buttonHeight = 32;
        const int startX = 90;
        const int startY = 120;

        foreach (var seat in seats)
        {
            var button = new Button
            {
                Text = seat.SeatCode,
                Tag = seat,
                Size = new Size(buttonWidth, buttonHeight),
                Location = new Point(
                    startX + seat.ColumnIndex * (buttonWidth + gap),
                    startY + seat.RowIndex * (buttonHeight + gap)),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };

            button.FlatAppearance.BorderSize = 1;
            ApplySeatStyle(button, seat.Status);
            button.Click += SeatButton_Click;
            seatPanel.Controls.Add(button);
        }
    }

    private void SeatButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button button || button.Tag is not SeatInfo seat)
        {
            return;
        }

        _selectedSeat = seat;
        foreach (var seatButton in seatPanel.Controls.OfType<Button>())
        {
            if (seatButton.Tag is SeatInfo item)
            {
                ApplySeatStyle(seatButton, item.Status);
            }
        }

        button.BackColor = Color.FromArgb(37, 99, 235);
        button.ForeColor = Color.White;
        button.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
    }

    private static void ApplySeatStyle(Button button, SeatStatus status)
    {
        switch (status)
        {
            case SeatStatus.Available:
                button.BackColor = Color.White;
                button.ForeColor = Color.FromArgb(17, 24, 39);
                button.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                break;
            case SeatStatus.Selected:
                button.BackColor = Color.FromArgb(37, 99, 235);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
                break;
            case SeatStatus.Sold:
                button.BackColor = Color.FromArgb(220, 38, 38);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
                break;
            case SeatStatus.Maintenance:
                button.BackColor = Color.FromArgb(148, 163, 184);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                break;
        }
    }

    private void ActionButton_Click(object? sender, EventArgs e)
    {
        if (_selectedSeat is null)
        {
            MessageBox.Show("Vui lòng chọn ghế trên sơ đồ.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var nextStatus = sender == maintenanceButton ? SeatStatus.Maintenance : SeatStatus.Available;
        if (_seatService.SetSeatStatus(_selectedSeat.RoomId, _selectedSeat.SeatCode, nextStatus, out var message))
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _selectedSeat = null;
            RenderSeatMap();
            return;
        }

        MessageBox.Show(message, "Không thể xử lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void FixRuntimeText()
    {
        Text = "Quản lý ghế";
        createLayoutButton.Text = "Tạo sơ đồ";
        changeStatusButton.Text = "Cho sử dụng";
        maintenanceButton.Text = "Đặt bảo trì";
        refreshButton.Text = "Làm mới";
    }
}