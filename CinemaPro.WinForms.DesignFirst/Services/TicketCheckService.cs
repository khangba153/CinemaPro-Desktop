using CinemaPro.WinForms.DesignFirst.Repositories;

namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class TicketCheckService
{
    private readonly TicketCheckRepository _ticketCheckRepository = new();

    public bool MarkTicketUsed(string ticketCode)
    {
        return _ticketCheckRepository.MarkTicketUsed(ticketCode);
    }

    public IReadOnlyList<TicketCheck> GetRecentChecks(int take = 30)
    {
        return _ticketCheckRepository.GetRecentChecks(take);
    }
}
