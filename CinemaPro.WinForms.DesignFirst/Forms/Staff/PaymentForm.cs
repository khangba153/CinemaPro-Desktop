using CinemaPro.WinForms.DesignFirst.ViewModels;

namespace CinemaPro.WinForms.DesignFirst.Forms.Staff;

public partial class PaymentForm : Form
{
    public PaymentForm()
    {
        InitializeComponent();
    }

    public PaymentForm(PaymentSummary summary)
    {
        InitializeComponent();
    }

    private void ConfirmButton_Click(object? sender, EventArgs e)
    {
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
    }
}
