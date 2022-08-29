namespace EventManager.DomainLayer;

public class EventService : IEventService
{
    //private readonly IEventRepository _eventRepository;
    private readonly ITicketService _ticketService;

    public EventService(ITicketService ticketService)
    {
        if (ticketService == null)
        {
            throw new ArgumentNullException("ticketService");
        }

        this._ticketService = ticketService;
    }

    public IEnumerable<string> Categories
    {
        get
        {
            return new[]
            {
                "All Categories",
                "Fireworks",
                "Fundraiser",
                "Gastronomy",
                "Romantic"};
        }
    }

    public IEnumerable<string> Statuses
    {
        get
        {
            return new[]
            {
                Status.Upcoming.ToString(),
                Status.Inactive.ToString(),
                Status.BookedOut.ToString(),
                Status.Cancelled.ToString()};
        }
    }

    public IEnumerable<Event> AllEvents
    {
        get
        {
            return new[]
            {
                new Event(
                    10,
                    "Some Inactive event",
                    "Havent really got an excerpt for this lazi boi yet",
                    "description",
                    "Fundraiser",
                    Status.Upcoming,
                    "michelle.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    20,
                    "Sirromet Wine and Dine",
                    "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                    "description",
                    "Gastronomy",
                    Status.Upcoming,
                    "wine.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    30,
                    "Sunsuper Riverfire",
                    "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                    "description",
                    "Fireworks",
                    Status.Upcoming,
                    "fireworks.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    40,
                    "New Year's Eve",
                    "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                    "description",
                    "Fireworks",
                    Status.Inactive,
                    "newyears.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    50,
                    "New Year's Eve",
                    "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                    "description",
                    "Fireworks",
                    Status.Cancelled,
                    "newyears.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    60,
                    "New Year's Eve",
                    "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                    "description",
                    "Fireworks",
                    Status.BookedOut,
                    "newyears.jpg",
                    _ticketService.GetTickets(100)
                    )
                };
        }
    }

    public IEnumerable<Event> UpcomingEvents
    {
        get
        {
            return new[]
            {
                new Event(
                    70,
                    "Sirromet Wine and Dine",
                    "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                    "description",
                    "Gastronomy",
                    Status.Upcoming,
                    "wine.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    80,
                    "Sunsuper Riverfire",
                    "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                    "description",
                    "Fireworks",
                    Status.Upcoming,
                    "fireworks.jpg",
                    _ticketService.GetTickets(100)
                ),
                new Event(
                    90,
                    "New Year's Eve",
                    "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                    "description",
                    "Fireworks",
                    Status.Upcoming,
                    "newyears.jpg",
                    _ticketService.GetTickets(100)
                    )
                    };
        }
    }

    public IEnumerable<Event> CancelledEvents
    {
        get
        {
            return new[]
            {
                new Event(
                    10,
                    "New Year's Eve",
                    "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                    "description",
                    "Fireworks",
                    Status.Cancelled,
                    "newyears.jpg",
                    _ticketService.GetTickets(100)
                    )
                    };
        }
    }

    public IEnumerable<Event> GetEventsBy(string? search, string? category)
    {
        if (search is null && category is null)
        {
            return this.AllEvents;
        }

        return new[]
        {
            new Event(
                20,
                "Sunsuper Riverfire",
                "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                "description",
                "Fireworks",
                Status.Upcoming,
                "fireworks.jpg",
                _ticketService.GetTickets(100)
            ),
            new Event(
                30,
                "New Year's Eve",
                "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                "description",
                "Fireworks",
                Status.Upcoming,
                "newyears.jpg",
                _ticketService.GetTickets(100))};
    }

    public Event GetEvent(int id)
    {
        return new Event(
            40,
            "Sirromet Wine and Dine",
            "excerpt",
            "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
            "Gastronomy",
            Status.Upcoming,
            "wine.jpg",
            _ticketService.GetTickets(id));
    }

}
