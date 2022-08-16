using System;

namespace EventManager.DomainLayer
{
    public class TicketService : ITicketService
    {
        public TicketService()
        {
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

        public Ticket GetTicket(int id)
        {
            return new Ticket(
                new DateTime(2022, 9, 28, 6, 0, 0),
                100,
                10);
        }

        public IEnumerable<Ticket> GetTickets(int eventID)
        {
            return new[]
            {
                new Ticket(
                    new DateTime(2022, 9, 28, 18, 0, 0),
                    120,
                    12
                ),
                new Ticket(
                    new DateTime(2022, 9, 28, 19, 0, 0),
                    120,
                    12
                ),
                new Ticket(
                    new DateTime(2022, 9, 29, 18, 0, 0),
                    100,
                    6
                ),
                new Ticket(
                    new DateTime(2022, 9, 29, 19, 0, 0),
                    120,
                    8
                ),
                new Ticket(
                    new DateTime(2022, 9, 30, 18, 0, 0),
                    120,
                    2
                ),
                new Ticket(
                    new DateTime(2022, 9, 30, 19, 0, 0),
                    140,
                    4
                )};
        }
    }
}

