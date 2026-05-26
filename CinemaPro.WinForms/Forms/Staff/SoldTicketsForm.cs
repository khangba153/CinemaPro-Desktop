using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.Services;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class SoldTicketsForm : Form
{
    private List<TicketRow> _tickets = [];

    public SoldTicketsForm()
    {
        InitializeComponent();
        ApplyRuntimeStyles();
        BindFilters();
        WireEvents();
        LoadTickets();
    }

    private void ApplyRuntimeStyles()
    {
        UiStyleHelper.ApplyStatusCellFormatting(_grid, "Status");
        StyleButton(searchButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(refreshButton, UiStyleHelper.Primary);
        StyleButton(printButton, UiStyleHelper.Primary, Color.White);
        StyleOutlineButton(cancelTicketButton, UiStyleHelper.Danger);
        StyleOutlineButton(viewLogButton, UiStyleHelper.Primary);
    }

    private void BindFilters()
    {
        movieCombo.Items.Clear();
        movieCombo.Items.Add("Tất cả phim");
        movieCombo.Items.AddRange(AppServices.CinemaStore.GetMovies().Select(item => item.Title).Cast<object>().ToArray());
        movieCombo.SelectedIndex = 0;

        statusCombo.Items.Clear();
        statusCombo.Items.AddRange(new object[] { "Tất cả trạng thái", "Chưa sử dụng", "Đã sử dụng", "Đã hủy" });
        statusCombo.SelectedIndex = 0;
    }

    private void WireEvents()
    {
        searchButton.Click += (_, _) => LoadTickets();
        refreshButton.Click += (_, _) => LoadTickets();
        _grid.SelectionChanged += (_, _) => UpdateDetailFromGrid();
        printButton.Click += (_, _) => MessageBox.Show("Demo UI: vé sẽ được in ở giai đoạn tích hợp máy in.", "Vé đã bán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        cancelTicketButton.Click += (_, _) => MessageBox.Show("Demo UI: thao tác hủy vé chưa ghi vào dữ liệu thật.", "Vé đã bán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        viewLogButton.Click += (_, _) => MessageBox.Show("Nhật ký giao dịch đang hiển thị ở bảng bên dưới.", "Vé đã bán", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadTickets()
    {
        _tickets = AppServices.CinemaStore.GetTickets().ToList();
        _grid.DataSource = _tickets
            .Select(ticket => new
            {
                ticket.TicketId,
                ticket.Movie,
                ticket.Showtime,
                ticket.Room,
                ticket.Seats,
                Quantity = ticket.Seats.Split(',', StringSplitOptions.RemoveEmptyEntries).Length,
                Total = UiStyleHelper.FormatCurrency(ticket.Total),
                ticket.PaymentMethod,
                ticket.Status
            })
            .ToList();

        if (_grid.Rows.Count > 0)
        {
            _grid.Rows[0].Selected = true;
            UpdateDetail(_tickets[0]);
        }
    }

    private void UpdateDetailFromGrid()
    {
        if (_grid.SelectedRows.Count == 0)
        {
            return;
        }

        var ticketId = _grid.SelectedRows[0].Cells["TicketId"].Value?.ToString();
        var ticket = _tickets.FirstOrDefault(item => item.TicketId == ticketId);
        if (ticket is not null)
        {
            UpdateDetail(ticket);
        }
    }

    private void UpdateDetail(TicketRow ticket)
    {
        qrCodeLabel.Text = $"QR\n{ticket.TicketId}";
        _detailLabel.Text =
            $"Mã vé: {ticket.TicketId}\n" +
            $"Phim: {ticket.Movie}\n" +
            $"Suất chiếu: {ticket.Showtime}\n" +
            $"Phòng: {ticket.Room}\n" +
            $"Ghế: {ticket.Seats}\n" +
            $"Phương thức thanh toán: {ticket.PaymentMethod}\n" +
            $"Tổng tiền: {UiStyleHelper.FormatCurrency(ticket.Total)}";
        _statusLabel.Text = UiStyleHelper.ToDisplayStatus(ticket.Status);
        _statusLabel.ForeColor = UiStyleHelper.StatusColor(ticket.Status);
        _logGrid.DataSource = new[]
        {
            new { Time = DateTime.Now.AddMinutes(-30).ToString("dd/MM HH:mm"), Action = "Tạo vé", Content = $"Tạo vé {ticket.TicketId}" },
            new { Time = DateTime.Now.AddMinutes(-28).ToString("dd/MM HH:mm"), Action = "Bán vé", Content = $"{ticket.Seats} - {UiStyleHelper.FormatCurrency(ticket.Total)}" },
            new { Time = DateTime.Now.AddMinutes(-12).ToString("dd/MM HH:mm"), Action = UiStyleHelper.ToDisplayStatus(ticket.Status), Content = ticket.Movie }
        };
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
        button.FlatAppearance.BorderColor = accent == UiStyleHelper.Danger ? ColorTranslator.FromHtml("#FFB4B4") : ColorTranslator.FromHtml("#9BC2FF");
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Color.White;
        button.ForeColor = accent;
        button.Font = UiStyleHelper.SectionFont(9.5f);
        button.Cursor = Cursors.Hand;
    }
}
