namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class PaymentForm : Form
{
    private readonly PaymentSummary _summary;

    public PaymentForm() : this(new PaymentSummary
    {
        TicketCode = "TK-TẠM",
        MovieTitle = "Avengers: Endgame",
        ShowtimeText = "19:30 - 22:32",
        RoomName = "Phòng 2",
        Seats = ["B6", "B7"],
        TotalAmount = 180000,
        PaymentMethod = PaymentMethodHelper.CashDisplay
    })
    {
    }

    public PaymentForm(PaymentSummary summary)
    {
        _summary = summary;
        InitializeComponent();
        FillSummary();
    }

    private void FillSummary()
    {
        ticketCodeValueLabel.Text = _summary.TicketCode;
        movieValueLabel.Text = _summary.MovieTitle;
        showtimeValueLabel.Text = _summary.ShowtimeText;
        roomValueLabel.Text = _summary.RoomName;
        seatsValueLabel.Text = string.Join(", ", _summary.Seats);
        amountValueLabel.Text = FormatHelper.Vnd(_summary.TotalAmount);
        methodValueLabel.Text = _summary.PaymentMethod;
    }

    private void ConfirmButton_Click(object? sender, EventArgs e)
    {
        var paymentMethod = PaymentMethodHelper.ToDatabaseValue(_summary.PaymentMethod);

        if (paymentMethod == PaymentMethodHelper.VnPaySandbox)
        {
            MessageBox.Show("Đang chuyển đến cổng thanh toán VNPAY Sandbox...", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (paymentMethod == PaymentMethodHelper.MomoSandbox)
        {
            var momoForm = new MoMoQRForm(_summary.TotalAmount, BuildMomoOrderInfo());
            var result = momoForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                return; // Ngừng nếu người dùng huỷ thanh toán MoMo
            }
        }
        else
        {
            MessageBox.Show("Thanh toán tiền mặt thành công.", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private string BuildMomoOrderInfo()
    {
        var seatText = _summary.Seats.Count == 0
            ? _summary.TicketCode
            : string.Join(", ", _summary.Seats);

        var orderInfo = $"CinemaPro - {_summary.MovieTitle} - Ghế {seatText}";
        return orderInfo.Length <= 250 ? orderInfo : orderInfo[..250];
    }
}
