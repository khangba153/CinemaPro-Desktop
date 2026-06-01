using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Admin;

public partial class SeatManagementForm : Form
{
    public SeatManagementForm()
    {
        InitializeComponent();
        seatPanel.AutoScroll = true;
    }

    private void SeatManagementForm_Load(object? sender, EventArgs e)
    {
        roomComboBox.DisplayMember = nameof(RoomRow.RoomName);
        roomComboBox.ValueMember = nameof(RoomRow.RoomId);
        roomComboBox.DataSource = AppServices.CinemaStore.GetRooms().ToList();

        FillRoomSizeInputs();
        RenderSeatMap();
    }

    private void RoomComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
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

        var existingSeats = AppServices.CinemaStore.GetSeats(room.RoomId).ToList();
        using var builderForm = new SeatLayoutBuilderForm(room.RoomId, room.RoomName, rowCount, columnCount, existingSeats);

        if (builderForm.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        AppServices.CinemaStore.UpdateRoomSeatLayout(room.RoomId, rowCount, columnCount, builderForm.CreatedSeats);
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

        var seats = AppServices.CinemaStore
            .GetSeats(room.RoomId)
            .OrderBy(seat => seat.RowIndex)
            .ThenBy(seat => seat.ColumnIndex)
            .ToList();

        if (seats.Count == 0)
        {
            return;
        }

        const int gap = 8;
        const int buttonWidth = 48;
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
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            button.FlatAppearance.BorderSize = 1;
            ApplySeatStyle(button, seat.Status);
            seatPanel.Controls.Add(button);
        }
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
        MessageBox.Show("Thao tác ghế chỉ mô phỏng trên giao diện demo.", "CinemaPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
