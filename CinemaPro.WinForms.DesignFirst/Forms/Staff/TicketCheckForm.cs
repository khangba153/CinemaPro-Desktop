using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class TicketCheckForm : Form
{
    private TicketRow? _currentTicket;

    public TicketCheckForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(historyGrid);
    }

    private void TicketCheckForm_Load(object? sender, EventArgs e)
    {
        unusedValueLabel.Text = AppServices.CinemaStore.GetTickets().Count(item => item.Status == "Unused").ToString();
        usedValueLabel.Text = AppServices.CinemaStore.GetTickets().Count(item => item.Status == "Used").ToString();
    }

    private void CheckButton_Click(object? sender, EventArgs e)
    {
        var code = ticketCodeTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(code))
        {
            MessageBox.Show("Vui lòng nhập mã vé hoặc quét QR.", "Thiếu mã vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _currentTicket = AppServices.CinemaStore.FindTicket(code);
        if (_currentTicket is null)
        {
            resultTitleLabel.Text = "Không tìm thấy vé";
            resultTitleLabel.ForeColor = Color.FromArgb(220, 38, 38);
            resultDetailLabel.Text = $"Mã vé {code} không tồn tại trong dữ liệu demo.";
            confirmEntryButton.Enabled = false;
            AddHistory(code, "Không tìm thấy");
            return;
        }

        var statusText = FormatHelper.TicketStatusText(_currentTicket.Status);
        resultTitleLabel.Text = _currentTicket.Status == "Unused" ? "Vé hợp lệ" : statusText;
        resultTitleLabel.ForeColor = _currentTicket.Status == "Unused" ? Color.FromArgb(22, 163, 74) : Color.FromArgb(245, 158, 11);
        resultDetailLabel.Text =
            $"Mã vé: {_currentTicket.TicketCode}\r\n" +
            $"Phim: {_currentTicket.MovieTitle}\r\n" +
            $"Suất chiếu: {_currentTicket.ShowtimeText}\r\n" +
            $"Phòng: {_currentTicket.RoomName}\r\n" +
            $"Ghế: {_currentTicket.Seats}\r\n" +
            $"Trạng thái: {statusText}";
        confirmEntryButton.Enabled = _currentTicket.Status == "Unused";
        AddHistory(_currentTicket.TicketCode, statusText);
    }

    private void ConfirmEntryButton_Click(object? sender, EventArgs e)
    {
        if (_currentTicket is null)
        {
            return;
        }

        if (AppServices.CinemaStore.MarkTicketUsed(_currentTicket.TicketCode))
        {
            resultTitleLabel.Text = "Đã xác nhận vào rạp";
            resultTitleLabel.ForeColor = Color.FromArgb(37, 99, 235);
            resultDetailLabel.Text += "\r\n\r\nKhách đã được xác nhận vào rạp.";
            confirmEntryButton.Enabled = false;
            AddHistory(_currentTicket.TicketCode, "Đã sử dụng");
            TicketCheckForm_Load(sender, e);
        }
    }

    private void ResetButton_Click(object? sender, EventArgs e)
    {
        ticketCodeTextBox.Clear();
        ticketCodeTextBox.Focus();
        _currentTicket = null;
        resultTitleLabel.Text = "Sẵn sàng kiểm tra";
        resultTitleLabel.ForeColor = Color.FromArgb(17, 24, 39);
        resultDetailLabel.Text = "Nhập mã vé demo TK000001, TK000002 hoặc mã vé mới tạo từ màn Bán vé.";
        confirmEntryButton.Enabled = false;
    }

    private void AddHistory(string code, string result)
    {
        historyGrid.Rows.Insert(0, DateTime.Now.ToString("HH:mm:ss"), code, result);
    }
}
