namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class ReportService
{
    private readonly ReportRepository _reportRepository = new();

    public IReadOnlyList<RevenueRow> GetRevenueRows()
    {
        return _reportRepository
            .GetRevenueRows()
            .Select(row =>
            {
                row.PaymentMethod = ToDisplayPaymentMethod(row.PaymentMethod);
                return row;
            })
            .ToList();
    }

    public DataTable GetDashboardSummary()
    {
        return _reportRepository.GetDashboardSummary();
    }

    private static string ToDisplayPaymentMethod(string paymentMethod)
    {
        return paymentMethod switch
        {
            "Cash" => "Tiá»n máº·t",
            "VNPAY_SANDBOX" => "VNPAY Sandbox",
            _ => paymentMethod
        };
    }
}
