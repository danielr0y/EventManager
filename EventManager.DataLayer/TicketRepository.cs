using EventManager.DomainLayer;

namespace EventManager.DataLayer
{
    public class TicketRepository : ITicketRepository
    {
        private readonly EventManagerContext _context;
        public TicketRepository(EventManagerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Ticket GetTicket(int id) => _context.Tickets.Single(ticket => ticket.Id == id);

        public IEnumerable<Ticket> GetTickets(Event Event) =>
            from ticket in _context.Tickets
            where ticket.Event == Event
            select ticket;
    }
}