using System;
namespace EventManager.Web.Models
{
    public class EventsPartialViewModel
    {
        public EventsPartialViewModel(string heading, IEnumerable<EventPreviewPartialViewModel> events)
        {
            this.Heading = heading;
            this.Events = events;
        }

        public string Heading { get; }
        public IEnumerable<EventPreviewPartialViewModel> Events { get; }
        public int NumberOfEvents { get { return this.Events.Count(); } }
    }
}