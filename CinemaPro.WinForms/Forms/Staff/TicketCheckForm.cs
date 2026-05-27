using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class TicketCheckForm : Form
{
    private TicketRow? _currentTicket;

    public TicketCheckForm()
    {
        InitializeComponent();
        ApplyRuntimeStyles();
        WireEvents();
        LoadHistory();
        RefreshOverview();
        ResetResult();
    }

    private void ApplyRuntimeStyles()
    {
        UiStyleHelper.ApplyStatusCellFormatting(_historyGrid, "Result");
        StyleButton(checkButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(refreshButton, UiStyleHelper.Primary);
        StyleButton(_confirmButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(cancelButton, UiStyleHelper.Danger);
    }

    private void WireEvents()
    {
        _ticketCodeTextBox.KeyDown += TicketCodeTextBox_KeyDown;
        checkButton.Click += (_, _) => CheckTicket();
        refreshButton.Click += (_, _) => ResetResult();
        _confirmButton.Click += (_, _) => ConfirmEntry();
        cancelButton.Click += (_, _) => ResetResult();
    }

    private void TicketCodeTextBox_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
        {
            return;
        }

        e.SuppressKeyPress = true;
        CheckTicket();
    }

    private void CheckTicket()
    {
        var code = _ticketCodeTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(code))
        {
            MessageBox.Show("Vui lòng nhập mã vé cần kiểm tra.", "Kiểm tra vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _currentTicket = AppServices.CinemaStore.FindTicket(code);
        if (_currentTicket is null)
        {
            ShowResult("Không tìm thấy vé", "Mã vé không tồn tại trong dữ liệu demo.", UiStyleHelper.Danger);
            _ticketInfoLabel.Text = $"Mã vé: {code}\n\nVui lòng kiểm tra lại mã trên vé hoặc mã QR.";
            _confirmButton.Visible = false;
            LoadHistory();
            return;
        }

        var color = UiStyleHelper.StatusColor(_currentTicket.Status);
        var title = _currentTicket.Status switch
        {
            "Unused" => "Vé hợp lệ",
            "Used" => "Vé đã sử dụng",
            "Canceled" => "Vé đã hủy",
            _ => "Trạng thái vé"
        };
        var note = _currentTicket.Status == "Unused"
            ? "Vé có thể sử dụng để vào rạp."
            : "Vé này không thể xác nhận vào rạp.";

        ShowResult(title, note, color);
        _ticketInfoLabel.Text =
            $"Mã vé: {_currentTicket.TicketId}\n" +
            $"Phim: {_currentTicket.Movie}\n" +
            $"Suất chiếu: {_currentTicket.Showtime}\n" +
            $"Phòng: {_currentTicket.Room}\n" +
            $"Ghế: {_currentTicket.Seats}\n" +
            $"Thanh toán: {_currentTicket.PaymentMethod}\n" +
            $"Trạng thái vé: {UiStyleHelper.ToDisplayStatus(_currentTicket.Status)}\n" +
            $"Thời gian kiểm tra: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        _confirmButton.Visible = _currentTicket.Status == "Unused";
        LoadHistory();
        RefreshOverview();
    }

    private void ConfirmEntry()
    {
        if (_currentTicket is null)
        {
            return;
        }

        if (!AppServices.CinemaStore.MarkTicketUsed(_currentTicket.TicketId))
        {
            MessageBox.Show("Vé không còn ở trạng thái chưa sử dụng.", "Kiểm tra vé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CheckTicket();
            return;
        }

        _currentTicket = AppServices.CinemaStore.FindTicket(_currentTicket.TicketId);
        ShowResult("Đã xác nhận vào rạp", "Trạng thái vé đã chuyển sang Đã sử dụng.", UiStyleHelper.Primary);
        _confirmButton.Visible = false;
        _ticketCodeTextBox.Text = _currentTicket?.TicketId ?? "";
        CheckTicket();
    }

    private void ShowResult(string title, string note, Color color)
    {
        _resultTitleLabel.Text = title;
        _resultTitleLabel.ForeColor = color;
        _resultNoteLabel.Text = note;
    }

    private void ResetResult()
    {
        _currentTicket = null;
        _ticketCodeTextBox.Clear();
        ShowResult("Sẵn sàng kiểm tra", "Nhập mã vé để bắt đầu.", UiStyleHelper.TextDark);
        _ticketInfoLabel.Text = "Ví dụ demo:\nTK000001: vé hợp lệ\nTK000002: vé đã sử dụng\nTK000003: vé đã hủy";
        _confirmButton.Visible = false;
        _ticketCodeTextBox.Focus();
        RefreshOverview();
    }

    private void LoadHistory()
    {
        _historyGrid.DataSource = AppServices.CinemaStore.GetTickets()
            .Take(6)
            .Select(ticket => new
            {
                ticket.TicketId,
                ticket.Movie,
                ticket.Seats,
                ticket.Showtime,
                Result = ticket.Status,
                Staff = "Trần Thị Mai",
                CheckedAt = DateTime.Now.AddMinutes(-Random.Shared.Next(1, 24)).ToString("dd/MM/yyyy HH:mm:ss")
            })
            .ToList();
    }

    private void RefreshOverview()
    {
        var tickets = AppServices.CinemaStore.GetTickets();
        checkedInValueLabel.Text = tickets.Count(ticket => ticket.Status == "Used").ToString();
        unusedValueLabel.Text = tickets.Count(ticket => ticket.Status == "Unused").ToString();
        canceledValueLabel.Text = tickets.Count(ticket => ticket.Status == "Canceled").ToString();
    }

    private static void StyleButton(Button button, Color backColor, Color foreColor)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = backColor;
        button.ForeColor = foreColor;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }

    private static void StyleOutlineButton(Button button, Color accent)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#9BC2FF");
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Color.White;
        button.ForeColor = accent;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {

    }

    private void cancelButton_Click_1(object sender, EventArgs e)
    {

    }
}
