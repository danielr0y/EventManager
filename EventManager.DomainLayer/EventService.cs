namespace EventManager.DomainLayer;

public class EventService : IEventService
{
    public IEnumerable<Event> GetAllEvents()
    {
        return new[]
        {
            new Event(
                "Some Inactive event",
                "Havent really got an excerpt for this lazi boi yet",
                "description",
                "Fundraiser",
                Status.Upcoming,
                "michelle.jpg"
            ),
            new Event(
                "Sirromet Wine and Dine",
                "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                "description",
                "Gastronomy",
                Status.Upcoming,
                "wine.jpg"
            ),
            new Event(
                "Sunsuper Riverfire",
                "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                "description",
                "Fireworks",
                Status.Upcoming,
                "fireworks.jpg"
            ),
            new Event(
                "New Year's Eve",
                "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                "description",
                "Fireworks",
                Status.Inactive,
                "newyears.jpg"
            ),
            new Event(
                "New Year's Eve",
                "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                "description",
                "Fireworks",
                Status.Cancelled,
                "newyears.jpg"
            ),
            new Event(
                "New Year's Eve",
                "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                "description",
                "Fireworks",
                Status.BookedOut,
                "newyears.jpg"
            )
        };
    }

    public IEnumerable<Event> GetUpcomingEvents()
    {
        return new[]
        {
            new Event(
                "Sirromet Wine and Dine",
                "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                "description",
                "Gastronomy",
                Status.Upcoming,
                "wine.jpg"
            ),
            new Event(
                "Sunsuper Riverfire",
                "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                "description",
                "Fireworks",
                Status.Upcoming,
                "fireworks.jpg"
            ),
            new Event(
                "New Year's Eve",
                "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                "description",
                "Fireworks",
                Status.Upcoming,
                "newyears.jpg"
            ),
        };
    }

    public Event GetEvent(string name)
    {
        return new Event(
            "Sirromet Wine and Dine",
            "excerpt",
            "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
            "Gastronomy",
            Status.Upcoming,
            "wine.jpg");
    }

}
