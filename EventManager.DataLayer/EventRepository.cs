using System.Collections.ObjectModel;
using EventManager.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace EventManager.DataLayer
{
    public class EventRepository : IEventRepository
    {
        private readonly EventManagerContext _context;

        public EventRepository(EventManagerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<string> Categories =>
            new[]
            {
                "All Categories",
                "Fireworks",
                "Fundraiser",
                "Gastronomy",
                "Romantic"
            };

        public IEnumerable<string> Statuses => 
            new[]
            {
                Status.Upcoming.ToString(),
                Status.Inactive.ToString(),
                Status.BookedOut.ToString(),
                Status.Cancelled.ToString()
            };

        public IEnumerable<Event> AllEvents =>
            from Event in _context.Events
            select Event;

        public IEnumerable<Event> UpcomingEvents => 
            from Event in _context.Events
            where Event.Status == Status.Upcoming
            select Event;

        public IEnumerable<Event> CancelledEvents => 
            from Event in _context.Events
            where Event.Status == Status.Cancelled
            select Event;

        public IEnumerable<Event> GetEventsBy(string? search, string? category)
        {
            if (search is null && category is null)
            {
                throw new Exception("Either category or search must be provided. Both cannot be null");
            }

            return new[]
            {
                GetEvent(3),
                GetEvent(4),
            };
        }

        public Event GetEvent(int id) => 
            _context.Events
                .Include(Event => Event.Tickets)
                .Include(Event => Event.Reviews)
                .ThenInclude(review => review.User)
                .Single(Event => Event.Id == id);
    }
}