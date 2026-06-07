using CinemaPro.WinForms.DesignFirst.Repositories;

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
                row.PaymentMethod = PaymentMethodHelper.ToDisplayText(row.PaymentMethod);
                return row;
            })
            .ToList();
    }

    public DataTable GetDashboardSummary()
    {
        return _reportRepository.GetDashboardSummary();
    }
}
