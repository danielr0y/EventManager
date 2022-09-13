namespace EventManager.DomainLayer
{
    public interface ITicketRepository
    {
        Ticket GetTicket(int id);
        IEnumerable<Ticket> GetTickets(Event @event);
    }
}