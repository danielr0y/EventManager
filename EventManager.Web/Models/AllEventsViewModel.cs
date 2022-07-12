using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel
	{
		public AllEventsViewModel(EventPreviewViewModel[] events)
		{
			this.Heading = "All Events";
			this.Events = events;
		}

        public string Heading { get; }
        public EventPreviewViewModel[] Events { get; }
    }
}

