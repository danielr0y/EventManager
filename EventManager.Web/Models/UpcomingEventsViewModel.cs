using System;
namespace EventManager.Web.Models
{
	public class UpcomingEventsViewModel
	{
		public UpcomingEventsViewModel(EventPreviewViewModel[] events)
		{
			this.Heading = "Upcoming Events";
			this.Events = events;
		}

        public string Heading { get; }
        public EventPreviewViewModel[] Events { get; }
    }
}

