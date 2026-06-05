namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class MoMoQRForm : Form
{
    private readonly Services.MoMoPaymentService _momoService = new();
    private System.Windows.Forms.Timer _pollingTimer;
    private int _pollingCount = 0;
    private const int MaxPollingCount = 60; // Poll for 3 minutes (every 3s)
    private string _currentOrderId = "";
    private string _currentRequestId = "";
    private decimal _amount;
    private string _orderInfo;
    private string _payUrl = "";

    public MoMoQRForm(decimal amount, string orderInfo)
    {
        InitializeComponent();
        _amount = amount;
        _orderInfo = orderInfo;
        _currentOrderId = Guid.NewGuid().ToString();
        _currentRequestId = Guid.NewGuid().ToString();
        
        _pollingTimer = new System.Windows.Forms.Timer();
        _pollingTimer.Interval = 3000; // 3 seconds
        _pollingTimer.Tick += PollingTimer_Tick;
    }

    private async void MoMoQRForm_Load(object? sender, EventArgs e)
    {
        await LoadQRCode();
    }

    private async Task LoadQRCode()
    {
        try
        {
            var (qrUrl, payUrl, error) = await _momoService.CreatePaymentRequestAsync(_amount, _orderInfo, _currentOrderId, _currentRequestId);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            if (!string.IsNullOrEmpty(qrUrl))
            {
                qrPictureBox.ImageLocation = qrUrl;
            }
            
            _payUrl = payUrl ?? "";
            
            if (!string.IsNullOrEmpty(_payUrl))
            {
                webPaymentLink.Visible = true;
            }
            bypassButton.Visible = true;

            _pollingTimer.Start();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi hiển thị mã QR: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void PollingTimer_Tick(object? sender, EventArgs e)
    {
        _pollingCount++;
        
        bool isPaid = await _momoService.CheckTransactionStatusAsync(_currentOrderId, _currentRequestId);
        if (isPaid)
        {
            _pollingTimer.Stop();
            MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        if (_pollingCount >= MaxPollingCount)
        {
            _pollingTimer.Stop();
            MessageBox.Show("Đã hết thời gian thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        _pollingTimer.Stop();
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void WebPaymentLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        if (!string.IsNullOrEmpty(_payUrl))
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = _payUrl,
                    UseShellExecute = true
                });
            }
            catch { }
        }
    }

    private void BypassButton_Click(object? sender, EventArgs e)
    {
        _pollingTimer.Stop();
        MessageBox.Show("Giả lập giao dịch MoMo thành công!", "Bypass", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }
}
