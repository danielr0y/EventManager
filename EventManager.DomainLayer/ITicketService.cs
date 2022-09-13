namespace EventManager.DomainLayer
{
    public interface ITicketService
    {
        Ticket GetTicket(int id);
        IEnumerable<Ticket> GetTickets(Event Event);
        IEnumerable<TimeOnly> FormatDataForTicketTableTimeRow(IEnumerable<Ticket> tickets);
        IEnumerable<IGrouping<DateOnly, Ticket>> FormatDataForTicketTableDateRows(IEnumerable<Ticket> tickets);
    }
}