using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Admin;

public sealed partial class SeatManagementForm : Form
{
    private string? _selectedSeat;

    public SeatManagementForm()
    {
        InitializeComponent();
        BindRooms();
        WireEvents();
        RenderSeats();
    }

    private void BindRooms()
    {
        roomCombo.Items.Clear();
        roomCombo.Items.AddRange(AppServices.CinemaStore.GetRooms()
            .Select(room => $"{room.Name} ({room.RoomType})")
            .Cast<object>()
            .ToArray());

        if (roomCombo.Items.Count > 0)
        {
            roomCombo.SelectedIndex = 0;
        }
    }

    private void WireEvents()
    {
        roomCombo.SelectedIndexChanged += (_, _) => RenderSeats();
        refreshButton.Click += (_, _) => RenderSeats();
        changeStatusButton.Click += (_, _) => MessageBox.Show("Đây là thao tác giả lập. Trạng thái ghế sẽ được lưu ở backend trong giai đoạn sau.", "Quản lý ghế", MessageBoxButtons.OK, MessageBoxIcon.Information);
        maintenanceButton.Click += (_, _) => MessageBox.Show("Đã đặt ghế đang chọn sang bảo trì demo.", "Quản lý ghế", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void RenderSeats()
    {
        seatPanel.Controls.Clear();
        var seats = FakeDataProvider.GetSeatMap();
        var rows = seats
            .GroupBy(seat => seat.SeatCode[0])
            .OrderBy(group => group.Key)
            .ToList();

        for (var rowIndex = 0; rowIndex < rows.Count; rowIndex++)
        {
            var row = rows[rowIndex];
            seatPanel.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = row.Key.ToString(),
                Font = UiStyleHelper.SectionFont(10F),
                ForeColor = UiStyleHelper.TextDark,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 4, 10, 4)
            }, 0, rowIndex);

            foreach (var seat in row)
            {
                var column = int.Parse(seat.SeatCode[1..]);
                var button = new Button
                {
                    Dock = DockStyle.Fill,
                    Text = seat.SeatCode[1..],
                    Tag = seat,
                    FlatStyle = FlatStyle.Flat,
                    UseVisualStyleBackColor = false,
                    Font = UiStyleHelper.SectionFont(8.75F),
                    ForeColor = UiStyleHelper.TextDark,
                    Margin = new Padding(6, 4, 6, 4),
                    Cursor = Cursors.Hand
                };

                button.FlatAppearance.BorderSize = 1;
                ApplySeatStyle(button, seat);
                button.Click += (_, _) =>
                {
                    var selectedSeat = (SeatInfo)button.Tag;
                    _selectedSeat = selectedSeat.SeatCode;
                    RenderSeats();
                    summaryLabel.Text = $"Ghế đang chọn: {_selectedSeat}     |     Phòng: {roomCombo.SelectedItem}     |     Trạng thái: {DisplaySeatStatus(selectedSeat.Status)}.";
                };
                seatPanel.Controls.Add(button, column, rowIndex);
            }
        }

        if (string.IsNullOrWhiteSpace(_selectedSeat))
        {
            summaryLabel.Text = $"Phòng: {roomCombo.SelectedItem}     |     Tổng ghế demo: {seats.Count}     |     Chọn một ghế để xem trạng thái.";
        }
    }

    private void ApplySeatStyle(Button button, SeatInfo seat)
    {
        if (seat.SeatCode == _selectedSeat)
        {
            button.BackColor = UiStyleHelper.SeatSelected;
            button.FlatAppearance.BorderColor = UiStyleHelper.Success;
            return;
        }

        button.BackColor = seat.Status switch
        {
            SeatStatus.Sold => UiStyleHelper.SeatSold,
            SeatStatus.Maintenance => UiStyleHelper.SeatMaintenance,
            _ => UiStyleHelper.SeatAvailable
        };

        button.FlatAppearance.BorderColor = seat.Status switch
        {
            SeatStatus.Sold => UiStyleHelper.Danger,
            SeatStatus.Maintenance => UiStyleHelper.TextMuted,
            _ => UiStyleHelper.FieldBorder
        };

        if (seat.Status == SeatStatus.Sold)
        {
            button.Text = "x";
        }
        else if (seat.Status == SeatStatus.Maintenance)
        {
            button.Text = "-";
        }
    }

    private static string DisplaySeatStatus(SeatStatus status) => status switch
    {
        SeatStatus.Sold => "Đã bán",
        SeatStatus.Maintenance => "Bảo trì",
        SeatStatus.Selected => "Đang chọn",
        _ => "Trống"
    };
}
