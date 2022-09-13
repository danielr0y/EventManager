using System;
namespace EventManager.Web.Models
{
    public class EventsPartialViewModel
    {
        public EventsPartialViewModel(string heading, IEnumerable<EventPreviewPartialViewModel> events)
        {
            Heading = heading;
            Events = events;
        }

        public string Heading { get; }
        public IEnumerable<EventPreviewPartialViewModel> Events { get; }
        public int NumberOfEvents => Events.Count();
    }
}