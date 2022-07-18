using System;
namespace EventManager.Web.Models
{
	public class UpcomingEventsViewModel : ILayoutViewModel
	{
		public UpcomingEventsViewModel(bool isAuthenticated, bool isAdmin, MessageViewModel[] messages, EventPreviewViewModel[] events, string category, string[] Categories)
		{
            this.IsAuthenticated = isAuthenticated;
            this.IsAdmin = isAdmin;
            this.Messages = messages;

			this.Heading = "Upcoming Events";
			this.Events = events;
		}

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public MessageViewModel[] Messages { get; }

        public string Heading { get; }
        public EventPreviewViewModel[] Events { get; }
    }
}

