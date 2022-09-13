using EventManager.DomainLayer;

namespace EventManager.DataLayer
{
    public class TicketRepository : ITicketRepository
    {
        private readonly EventManagerContext _context;
        public TicketRepository(EventManagerContext context)
        {
            _context = context;
        }

        public Ticket GetTicket(int id) => this._context.Tickets.Single(ticket => ticket.Id == id);

        public IEnumerable<Ticket> GetTickets(Event Event) =>
            from ticket in this._context.Tickets
            where ticket.Event == Event
            select ticket;
    }
}