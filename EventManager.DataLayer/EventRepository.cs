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
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this._context = context;
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
                    "Romantic"
                };
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
                    Status.Cancelled.ToString()
                };
            }
        }

        public IEnumerable<Event> AllEvents =>
            from Event in this._context.Events
            select Event;

        public IEnumerable<Event> UpcomingEvents => 
            from Event in this._context.Events
            where Event.Status == Status.Upcoming
            select Event;

        public IEnumerable<Event> CancelledEvents => 
            from Event in this._context.Events
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
                this.GetEvent(3),
                this.GetEvent(4),
            };
        }

        public Event GetEvent(int id) => 
            this._context.Events
                .Include(Event => Event.Tickets)
                .Include(Event => Event.Reviews)
                .ThenInclude(review => review.User)
                .Single(Event => Event.Id == id);
    }
}