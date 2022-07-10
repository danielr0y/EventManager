using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel
	{
		public AllEventsViewModel(IEnumerable<EventPreviewViewModel> events)
		{
			this.Heading = "All Events";
			this.Events = events;
		}

        public string Heading { get; }
        public IEnumerable<EventPreviewViewModel> Events { get; }
    }
}

