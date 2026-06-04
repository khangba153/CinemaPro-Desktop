namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class TicketService
{
    private readonly TicketRepository _ticketRepository = new();

    public IReadOnlyList<TicketRow> GetTickets()
    {
        return _ticketRepository.GetSoldTickets();
    }

    public IReadOnlyList<TicketRow> GetSoldTickets()
    {
        return _ticketRepository.GetSoldTickets();
    }

    public TicketRow? FindTicket(string ticketCode)
    {
        return _ticketRepository.FindByCode(ticketCode);
    }

    public TicketRow CreateTicket(PaymentSummary summary, string staffName)
    {
        return _ticketRepository.CreateTicket(summary, staffName);
    }
}
