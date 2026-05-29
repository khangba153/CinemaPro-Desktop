using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.Session;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class TicketSaleForm : Form
{
    private readonly List<string> _selectedSeats = [];
    private ShowtimeRow? _currentShowtime;

    public TicketSaleForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(recentTicketsGrid);
    }

    private void TicketSaleForm_Load(object? sender, EventArgs e)
    {
        movieComboBox.DisplayMember = nameof(MovieRow.Title);
        movieComboBox.ValueMember = nameof(MovieRow.MovieId);
        movieComboBox.DataSource = AppServices.CinemaStore.GetMovies().ToList();

        paymentMethodComboBox.Items.Clear();
        paymentMethodComboBox.Items.AddRange(["Tiền mặt", "VNPAY Sandbox"]);
        paymentMethodComboBox.SelectedIndex = 0;

        LoadRecentTickets();
    }

    private void MovieComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (movieComboBox.SelectedItem is not MovieRow movie)
        {
            return;
        }

        var showtimes = AppServices.CinemaStore
            .GetShowtimes()
            .Where(item => item.MovieId == movie.MovieId)
            .ToList();

        showtimeComboBox.DisplayMember = nameof(ShowtimeRow.DisplayText);
        showtimeComboBox.ValueMember = nameof(ShowtimeRow.ShowtimeId);
        showtimeComboBox.DataSource = showtimes;
    }

    private void ShowtimeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        _currentShowtime = showtimeComboBox.SelectedItem as ShowtimeRow;
        _selectedSeats.Clear();
        UpdateSummary();
        FillShowtimeInfo();
        RenderSeatMap();
    }

    private void FillShowtimeInfo()
    {
        if (_currentShowtime is null)
        {
            movieTitleValueLabel.Text = "-";
            roomValueLabel.Text = "-";
            formatValueLabel.Text = "-";
            priceValueLabel.Text = "-";
            return;
        }

        movieTitleValueLabel.Text = _currentShowtime.MovieTitle;
        roomValueLabel.Text = _currentShowtime.RoomName;
        formatValueLabel.Text = _currentShowtime.Format;
        priceValueLabel.Text = FormatHelper.Vnd(_currentShowtime.Price);
    }

    private void RenderSeatMap()
    {
        seatMapPanel.Controls.Clear();

        var screenLabel = new Label
        {
            Text = "MÀN HÌNH",
            BackColor = Color.FromArgb(226, 232, 240),
            ForeColor = Color.FromArgb(71, 85, 105),
            Font = new Font("Segoe UI", 9F, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(70, 14),
            Size = new Size(360, 28)
        };
        seatMapPanel.Controls.Add(screenLabel);

        if (_currentShowtime is null)
        {
            return;
        }

        var seats = AppServices.CinemaStore.GetSeats(_currentShowtime.RoomId);
        var startX = 50;
        var startY = 64;
        var width = 42;
        var height = 32;
        var gap = 8;

        foreach (var seat in seats)
        {
            var rowIndex = seat.SeatCode[0] - 'A';
            var colIndex = int.Parse(seat.SeatCode[1..]) - 1;
            var button = new Button
            {
                Text = seat.SeatCode,
                Tag = seat,
                Size = new Size(width, height),
                Location = new Point(startX + colIndex * (width + gap), startY + rowIndex * (height + gap)),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = 1;
            ApplySeatStyle(button, seat.Status);
            button.Click += SeatButton_Click;
            seatMapPanel.Controls.Add(button);
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
                button.Enabled = true;
                break;
            case SeatStatus.Selected:
                button.BackColor = Color.FromArgb(37, 99, 235);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
                button.Enabled = true;
                break;
            case SeatStatus.Sold:
                button.BackColor = Color.FromArgb(220, 38, 38);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
                button.Enabled = false;
                break;
            case SeatStatus.Maintenance:
                button.BackColor = Color.FromArgb(148, 163, 184);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                button.Enabled = false;
                break;
        }
    }

    private void SeatButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button button || button.Tag is not SeatInfo seat)
        {
            return;
        }

        if (seat.Status is SeatStatus.Sold or SeatStatus.Maintenance)
        {
            return;
        }

        if (_selectedSeats.Contains(seat.SeatCode))
        {
            _selectedSeats.Remove(seat.SeatCode);
            seat.Status = SeatStatus.Available;
        }
        else
        {
            _selectedSeats.Add(seat.SeatCode);
            seat.Status = SeatStatus.Selected;
        }

        ApplySeatStyle(button, seat.Status);
        UpdateSummary();
    }

    private void UpdateSummary()
    {
        selectedSeatListBox.Items.Clear();
        foreach (var seat in _selectedSeats.OrderBy(item => item))
        {
            selectedSeatListBox.Items.Add(seat);
        }

        var price = _currentShowtime?.Price ?? 0;
        totalValueLabel.Text = FormatHelper.Vnd(_selectedSeats.Count * price);
        selectedCountLabel.Text = $"{_selectedSeats.Count} ghế";
    }

    private void PaymentButton_Click(object? sender, EventArgs e)
    {
        if (_currentShowtime is null || _selectedSeats.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn suất chiếu và ghế trước khi thanh toán.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var summary = new PaymentSummary
        {
            TicketCode = "TK-TẠM",
            MovieTitle = _currentShowtime.MovieTitle,
            ShowtimeId = _currentShowtime.ShowtimeId,
            ShowtimeText = _currentShowtime.TimeText,
            RoomId = _currentShowtime.RoomId,
            RoomName = _currentShowtime.RoomName,
            Seats = _selectedSeats.OrderBy(item => item).ToList(),
            TotalAmount = _selectedSeats.Count * _currentShowtime.Price,
            PaymentMethod = paymentMethodComboBox.Text
        };

        using var paymentForm = new PaymentForm(summary);
        if (paymentForm.ShowDialog(this) == DialogResult.OK)
        {
            var ticket = AppServices.CinemaStore.CreateTicket(summary, UserSession.FullName);
            MessageBox.Show($"Đã tạo vé {ticket.TicketCode}.", "Bán vé thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _selectedSeats.Clear();
            UpdateSummary();
            RenderSeatMap();
            LoadRecentTickets();
        }
    }

    private void ClearButton_Click(object? sender, EventArgs e)
    {
        if (_currentShowtime is not null)
        {
            foreach (var seat in AppServices.CinemaStore.GetSeats(_currentShowtime.RoomId).Where(item => _selectedSeats.Contains(item.SeatCode)))
            {
                seat.Status = SeatStatus.Available;
            }
        }

        _selectedSeats.Clear();
        UpdateSummary();
        RenderSeatMap();
    }

    private void LoadRecentTickets()
    {
        recentTicketsGrid.Rows.Clear();
        foreach (var ticket in AppServices.CinemaStore.GetTickets().Take(5))
        {
            recentTicketsGrid.Rows.Add(ticket.TicketCode, ticket.MovieTitle, ticket.Seats, FormatHelper.Vnd(ticket.TotalAmount), FormatHelper.TicketStatusText(ticket.Status));
        }
    }
}
