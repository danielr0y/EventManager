using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel : ILayoutViewModel
    {
		public AllEventsViewModel(bool isAuthenticated, bool isAdmin, MessageViewModel[] messages, EventPreviewViewModel[] events, string category, string[] categories)
        {
            this.IsAuthenticated = isAuthenticated;
            this.IsAdmin = isAdmin;
            this.Messages = messages;

			this.Heading = "All Events";
			this.Events = events;
			this.Category = category;
			this.Categories = categories;
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

