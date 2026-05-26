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
        detailsTable.Controls.Clear();
        AddRow("Mã vé", _summary.TicketId);
        AddRow("Tên phim", _summary.Movie);
        AddRow("Suất chiếu", _summary.Showtime);
        AddRow("Phòng", _summary.Room);
        AddRow("Ghế", string.Join(", ", _summary.Seats));
        AddRow("Tổng tiền", UiStyleHelper.FormatCurrency(_summary.Total));
        AddRow("Thanh toán", _summary.PaymentMethod);

        AcceptButton = confirmButton;
        CancelButton = closeButton;
    }

    private void AddRow(string label, string value)
    {
        detailsTable.Controls.Add(new Label
        {
            Text = label,
            Dock = DockStyle.Fill,
            ForeColor = UiStyleHelper.TextMuted,
            Font = UiStyleHelper.SmallFont(9.5f),
            TextAlign = ContentAlignment.MiddleLeft
        });
        detailsTable.Controls.Add(new Label
        {
            Text = value,
            Dock = DockStyle.Fill,
            ForeColor = UiStyleHelper.TextDark,
            Font = UiStyleHelper.SectionFont(9.5f),
            TextAlign = ContentAlignment.MiddleLeft,
            AutoEllipsis = true
        });
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
