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
            this.Category = category;
            this.Categories = Categories;
		}

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public MessageViewModel[] Messages { get; }

        public string Heading { get; }
        public EventPreviewViewModel[] Events { get; }
        public string Category { get; }
        public string[] Categories { get; }
    }
}

