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
        var seats = FakeDataProvider.GetSeatMap().ToDictionary(seat => seat.SeatCode);
        foreach (var button in seatPanel.Controls.OfType<Button>())
        {
            if (button.Tag is not string seatCode || !seats.TryGetValue(seatCode, out var seat))
            {
                continue;
            }

            ApplySeatStyle(button, seat);
        }

        if (string.IsNullOrWhiteSpace(_selectedSeat))
        {
            summaryLabel.Text = $"Phòng: {roomCombo.SelectedItem}     |     Tổng ghế demo: {seats.Count}     |     Chọn một ghế để xem trạng thái.";
        }
    }

    private void SeatButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button { Tag: string seatCode })
        {
            return;
        }

        var seat = FakeDataProvider.GetSeatMap().FirstOrDefault(item => item.SeatCode == seatCode);
        _selectedSeat = seatCode;
        RenderSeats();
        summaryLabel.Text = $"Ghế đang chọn: {_selectedSeat}     |     Phòng: {roomCombo.SelectedItem}     |     Trạng thái: {DisplaySeatStatus(seat?.Status ?? SeatStatus.Available)}.";
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
