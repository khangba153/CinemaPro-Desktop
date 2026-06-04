namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class TicketCheckService
{
    private readonly TicketCheckRepository _ticketCheckRepository = new();

    public IReadOnlyList<TicketCheck> GetRecentChecks(int take = 30)
    {
        return _ticketCheckRepository.GetRecentChecks(take);
    }
}
