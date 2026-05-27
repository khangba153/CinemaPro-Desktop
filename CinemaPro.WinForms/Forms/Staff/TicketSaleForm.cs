using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class TicketSaleForm : Form
{
    private readonly List<ShowtimeRow> _showtimes;
    private readonly Dictionary<string, SeatStatus> _seatStatuses = [];
    private readonly List<string> _selectedSeats = [];
    private decimal _ticketPrice;
    private string _currentShowtimeId = string.Empty;

    public TicketSaleForm()
    {
        _showtimes = AppServices.CinemaStore.GetShowtimes()
            .Where(showtime => showtime.StartTime.Date == DateTime.Today)
            .OrderBy(showtime => showtime.StartTime)
            .ToList();

        InitializeComponent();
        BindFilterData();
        LoadRecentTickets();
        UpdateShowtimeInfo();
    }

    private void BindFilterData()
    {
        _roomCombo.Items.Clear();
        _showtimeCombo.Items.Clear();
        _paymentCombo.Items.Clear();
        _roomCombo.Items.AddRange(AppServices.CinemaStore.GetRooms().Select(room => room.Name).Cast<object>().ToArray());
        if (_roomCombo.Items.Count > 1)
        {
            _roomCombo.SelectedIndex = 1;
        }

        _showtimeCombo.Items.AddRange(_showtimes.Select(showtime => $"{showtime.StartTime:HH:mm} - {showtime.Movie}").Cast<object>().ToArray());
        _showtimeCombo.SelectedIndexChanged += ShowtimeCombo_SelectedIndexChanged;
        if (_showtimeCombo.Items.Count > 0)
        {
            _showtimeCombo.SelectedIndex = 0;
        }

        _paymentCombo.Items.AddRange(new object[] { "Tiền mặt", "VNPAY Sandbox" });
        _paymentCombo.SelectedIndex = 0;
    }

    private void ShowtimeCombo_SelectedIndexChanged(object? sender, EventArgs e) => UpdateShowtimeInfo();

    private void RefreshButton_Click(object? sender, EventArgs e) => UpdateShowtimeInfo();

    private void PayButton_Click(object? sender, EventArgs e) => OpenPayment();

    private void CancelButton_Click(object? sender, EventArgs e) => ClearSelection();

    private void UpdateShowtimeInfo()
    {
        if (_showtimeCombo.SelectedIndex < 0 || _showtimeCombo.SelectedIndex >= _showtimes.Count)
        {
            return;
        }

        var showtime = _showtimes[_showtimeCombo.SelectedIndex];
        var movie = AppServices.CinemaStore.GetMovies().FirstOrDefault(item => item.Title == showtime.Movie);
        _currentShowtimeId = showtime.ShowtimeId;
        _ticketPrice = showtime.TicketPrice;
        _movieTitleLabel.Text = showtime.Movie;
        _movieMetaLabel.Text = $"Thời lượng: {movie?.Duration ?? 120} phút     Định dạng: {showtime.Format}     Ngôn ngữ: Phụ đề";
        _showtimeInfoLabel.Text = $"Suất chiếu: {showtime.StartTime:HH:mm}     Ngày chiếu: {showtime.StartTime:dddd, dd/MM/yyyy}";
        _roomInfoLabel.Text = $"Phòng chiếu: {showtime.Room}";
        _unitPriceLabel.Text = UiStyleHelper.FormatCurrency(_ticketPrice);
        _roomCombo.SelectedItem = showtime.Room;

        _seatStatuses.Clear();
        foreach (var seat in AppServices.CinemaStore.GetSeats(_currentShowtimeId))
        {
            _seatStatuses[seat.SeatCode] = seat.Status;
        }

        _selectedSeats.Clear();
        RenderSeats();
        UpdateTotals();
    }

    private void RenderSeats()
    {
        _seatGridPanel.SuspendLayout();
        foreach (var button in _seatGridPanel.Controls.OfType<Button>())
        {
            if (button.Tag is not string seatCode)
            {
                continue;
            }

            var status = _selectedSeats.Contains(seatCode) ? SeatStatus.Selected : _seatStatuses.GetValueOrDefault(seatCode, SeatStatus.Available);
            button.Cursor = status is SeatStatus.Sold or SeatStatus.Maintenance ? Cursors.No : Cursors.Hand;
            ApplySeatStyle(button, status);
        }

        _seatGridPanel.ResumeLayout();
    }

    private void SeatButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button { Tag: string seatCode })
        {
            ToggleSeat(seatCode);
        }
    }

    private static void ApplySeatStyle(Button button, SeatStatus status)
    {
        switch (status)
        {
            case SeatStatus.Selected:
                button.BackColor = UiStyleHelper.SeatSelected;
                button.FlatAppearance.BorderColor = UiStyleHelper.Success;
                break;
            case SeatStatus.Sold:
                button.BackColor = UiStyleHelper.SeatSold;
                button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#FFA3A3");
                button.Text = "x";
                break;
            case SeatStatus.Maintenance:
                button.BackColor = UiStyleHelper.SeatMaintenance;
                button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
                button.Text = "-";
                break;
            default:
                button.BackColor = UiStyleHelper.SeatAvailable;
                button.FlatAppearance.BorderColor = UiStyleHelper.FieldBorder;
                break;
        }
    }

    private void ToggleSeat(string seatCode)
    {
        if (!_seatStatuses.TryGetValue(seatCode, out var status) || status is SeatStatus.Sold or SeatStatus.Maintenance)
        {
            return;
        }

        if (_selectedSeats.Contains(seatCode))
        {
            _selectedSeats.Remove(seatCode);
        }
        else
        {
            _selectedSeats.Add(seatCode);
        }

        RenderSeats();
        UpdateTotals();
    }

    private void UpdateTotals()
    {
        selectedSeatB5BadgeLabel.Text = _selectedSeats.Count == 0 ? "Chưa chọn" : string.Join(", ", _selectedSeats.OrderBy(code => code));
        selectedSeatB5BadgeLabel.Visible = true;
        selectedSeatB6BadgeLabel.Visible = false;

        _selectedCountLabel.Text = _selectedSeats.Count == 0
            ? "Chưa chọn ghế"
            : $"{_selectedSeats.Count} ghế đã chọn";
        _totalLabel.Text = UiStyleHelper.FormatCurrency(_selectedSeats.Count * _ticketPrice);
    }

    private void ClearSelection()
    {
        _selectedSeats.Clear();
        RenderSeats();
        UpdateTotals();
    }

    private void OpenPayment()
    {
        if (_selectedSeats.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một ghế trống trước khi thanh toán.", "Bán vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var showtime = _showtimes[_showtimeCombo.SelectedIndex];
        var summary = new PaymentSummary(
            FakeDataProvider.NewTicketId(),
            showtime.Movie,
            $"{showtime.StartTime:HH:mm} - {showtime.EndTime:HH:mm}",
            showtime.Room,
            _selectedSeats.OrderBy(code => code).ToList(),
            _selectedSeats.Count * _ticketPrice,
            _paymentCombo.SelectedItem?.ToString() ?? "Tiền mặt");

        using var payment = new PaymentForm(summary);
        if (payment.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            AppServices.CinemaStore.CreateTicket(_currentShowtimeId, summary);
            MessageBox.Show($"Đã tạo vé {summary.TicketId}.", "Bán vé thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _selectedSeats.Clear();
            LoadRecentTickets();
            UpdateShowtimeInfo();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Không thể bán vé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UpdateShowtimeInfo();
        }
    }

    private void LoadRecentTickets()
    {
        _recentGrid.DataSource = AppServices.CinemaStore.GetTickets()
            .Take(5)
            .Select(ticket => new
            {
                Time = DateTime.Now.ToString("dd/MM HH:mm"),
                ticket.Movie,
                ticket.Showtime,
                ticket.Room,
                ticket.Seats,
                Quantity = ticket.Seats.Split(',', StringSplitOptions.RemoveEmptyEntries).Length,
                Total = UiStyleHelper.FormatCurrency(ticket.Total),
                Payment = ticket.PaymentMethod,
                Status = ticket.Status
            })
            .ToList();
    }
}
