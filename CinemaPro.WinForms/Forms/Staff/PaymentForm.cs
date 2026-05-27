using CinemaPro.WinForms.Helpers;
using CinemaPro.WinForms.ViewModels;

namespace CinemaPro.WinForms.Forms.Staff;

public sealed partial class PaymentForm : Form
{
    private readonly PaymentSummary _summary;

    public PaymentForm()
        : this(new PaymentSummary(
            "TK000001",
            "Avengers: Endgame",
            "19:30 - 22:32",
            "Phòng 2",
            ["B5", "B6"],
            180000,
            "Tiền mặt"))
    {
    }

    public PaymentForm(PaymentSummary summary)
    {
        _summary = summary;
        InitializeComponent();
        BindSummary();
    }

    private void BindSummary()
    {
        ticketIdValueLabel.Text = _summary.TicketId;
        movieValueLabel.Text = _summary.Movie;
        showtimeValueLabel.Text = _summary.Showtime;
        roomValueLabel.Text = _summary.Room;
        seatsValueLabel.Text = string.Join(", ", _summary.Seats);
        totalValueLabel.Text = UiStyleHelper.FormatCurrency(_summary.Total);
        paymentMethodValueLabel.Text = _summary.PaymentMethod;

        AcceptButton = confirmButton;
        CancelButton = closeButton;
    }

    private void ConfirmButton_Click(object? sender, EventArgs e) => ConfirmPayment();

    private void CloseButton_Click(object? sender, EventArgs e) => Close();

    private void ConfirmPayment()
    {
        var message = _summary.PaymentMethod == "Tiền mặt"
            ? "Thanh toán tiền mặt thành công."
            : "Đang chuyển đến cổng thanh toán VNPAY Sandbox...";
        MessageBox.Show(message, "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }
}
