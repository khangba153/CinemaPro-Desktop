namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class ReportService
{
    private readonly ReportRepository _reportRepository = new();

    public IReadOnlyList<RevenueRow> GetRevenueRows()
    {
        return _reportRepository.GetRevenueRows();
    }

    public DataTable GetDashboardSummary()
    {
        return _reportRepository.GetDashboardSummary();
    }
}
