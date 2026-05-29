using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Services;
using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class SoldTicketsForm : Form
{
    public SoldTicketsForm()
    {
        InitializeComponent();
        UiStyleHelper.StyleGrid(ticketGrid);
    }

    private void SoldTicketsForm_Load(object? sender, EventArgs e)
    {
        movieFilterComboBox.Items.Clear();
        movieFilterComboBox.Items.Add("Tất cả phim");
        movieFilterComboBox.Items.AddRange(AppServices.CinemaStore.GetMovies().Select(item => item.Title).Cast<object>().ToArray());
        movieFilterComboBox.SelectedIndex = 0;

        statusFilterComboBox.Items.Clear();
        statusFilterComboBox.Items.AddRange(["Tất cả", "Unused", "Used", "Canceled"]);
        statusFilterComboBox.SelectedIndex = 0;

        paymentFilterComboBox.Items.Clear();
        paymentFilterComboBox.Items.AddRange(["Tất cả", "Tiền mặt", "VNPAY Sandbox"]);
        paymentFilterComboBox.SelectedIndex = 0;
        soldDatePicker.Value = DateTime.Today;

        LoadTickets();
    }

    private void FilterButton_Click(object? sender, EventArgs e)
    {
        LoadTickets();
    }

    private void LoadTickets()
    {
        var tickets = AppServices.CinemaStore.GetTickets().Where(ticket => ticket.SoldAt.Date == soldDatePicker.Value.Date);
        if (movieFilterComboBox.Text != "Tất cả phim")
        {
            tickets = tickets.Where(ticket => ticket.MovieTitle == movieFilterComboBox.Text);
        }

        if (statusFilterComboBox.Text != "Tất cả")
        {
            tickets = tickets.Where(ticket => ticket.Status == statusFilterComboBox.Text);
        }

        if (paymentFilterComboBox.Text != "Tất cả")
        {
            tickets = tickets.Where(ticket => ticket.PaymentMethod == paymentFilterComboBox.Text);
        }

        ticketGrid.Rows.Clear();
        foreach (var ticket in tickets)
        {
            ticketGrid.Rows.Add(ticket.TicketCode, ticket.MovieTitle, ticket.ShowtimeText, ticket.RoomName, ticket.Seats, FormatHelper.Vnd(ticket.TotalAmount), ticket.PaymentMethod, FormatHelper.TicketStatusText(ticket.Status));
        }

        ticketCountLabel.Text = $"{ticketGrid.Rows.Count} vé";
        if (ticketGrid.Rows.Count > 0)
        {
            ticketGrid.Rows[0].Selected = true;
            ShowSelectedTicket();
        }
        else
        {
            detailValueLabel.Text = "Không có vé phù hợp bộ lọc.";
        }
    }

    private void TicketGrid_SelectionChanged(object? sender, EventArgs e)
    {
        ShowSelectedTicket();
    }

    private void ShowSelectedTicket()
    {
        if (ticketGrid.SelectedRows.Count == 0)
        {
            return;
        }

        var row = ticketGrid.SelectedRows[0];
        detailValueLabel.Text =
            $"Mã vé: {row.Cells[0].Value}\r\n" +
            $"Phim: {row.Cells[1].Value}\r\n" +
            $"Suất chiếu: {row.Cells[2].Value}\r\n" +
            $"Phòng: {row.Cells[3].Value}\r\n" +
            $"Ghế: {row.Cells[4].Value}\r\n" +
            $"Tổng tiền: {row.Cells[5].Value}\r\n" +
            $"Thanh toán: {row.Cells[6].Value}\r\n" +
            $"Trạng thái: {row.Cells[7].Value}";
    }
}
