using System;

namespace EventManager.DomainLayer
{
    public class BookingService : IBookingService
    {
        private readonly IEventService _eventService;
        private readonly ITicketService _ticketService;

        public BookingService(IEventService eventService, ITicketService ticketService)
        {
            if (eventService == null)
            {
                throw new ArgumentNullException("eventService");
            }
            if (ticketService == null)
            {
                throw new ArgumentNullException("ticketService");
            }

            this._eventService = eventService;
            this._ticketService = ticketService;
        }

        public IEnumerable<Booking> Bookings
        {
            get
            {
                return new[]
                {
                    new Booking(
                        100,
                        _ticketService.GetTicket(100),
                        2,
                        400,
                        new DateTime(2022,6,15,18,26,34),
                        _eventService.GetEvent(100)
                    ),
                    new Booking(
                        100,
                        _ticketService.GetTicket(100),
                        2,
                        400,
                        new DateTime(2022,6,14,18,26,34),
                        _eventService.GetEvent(100)
                    )};
            }
        }
    }
}

