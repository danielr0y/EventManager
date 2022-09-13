using System;

namespace EventManager.DomainLayer
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _repository;
        
        public TicketService(ITicketRepository ticketRepository)
        {
            this._repository = ticketRepository ?? throw new ArgumentNullException(nameof(ticketRepository));
        }

        public IEnumerable<TimeOnly> FormatDataForTicketTableTimeRow(IEnumerable<Ticket> tickets)
        {
            var ticketsGrouped = from ticket in tickets
                                 orderby ticket.DateTime
                                 group ticket by TimeOnly.FromDateTime(ticket.DateTime);

            return from ticket in ticketsGrouped
                   select ticket.Key;
        }

        public IEnumerable<IGrouping<DateOnly, Ticket>> FormatDataForTicketTableDateRows(IEnumerable<Ticket> tickets)
        {
            return from ticket in tickets
                   orderby ticket.DateTime
                   group ticket by DateOnly.FromDateTime(ticket.DateTime);
        }

        public Ticket GetTicket(int id) => _repository.GetTicket(id);

        public IEnumerable<Ticket> GetTickets(Event Event) => _repository.GetTickets(Event);
    }
}

