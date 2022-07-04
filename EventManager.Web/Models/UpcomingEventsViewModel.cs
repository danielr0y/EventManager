using System;
namespace EventManager.Web.Models
{
	public class UpcomingEventsViewModel
	{
		public UpcomingEventsViewModel(string heading, IEnumerable<EventPreviewViewModel> events)
		{
			this.Heading = heading;
			this.Events = events;
		}

        public string Heading { get; }
        public IEnumerable<EventPreviewViewModel> Events { get; }
    }
}

