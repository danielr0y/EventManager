using System;
namespace EventManager.Web.Models
{
	public class UpcomingEventsViewModel : ILayoutViewModel
    {
		public UpcomingEventsViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages, IEnumerable<EventPreviewViewModel> events, string category, IEnumerable<string> Categories)
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
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get { return this.Messages.Count(); } }

        public string Heading { get; }
        public IEnumerable<EventPreviewViewModel> Events { get; }
        public int NumberOfEvents { get { return this.Events.Count(); } }
        public string Category { get; }
        public IEnumerable<string> Categories { get; }
        public int NumberOfCategories { get { return this.Categories.Count(); } }
    }
}

