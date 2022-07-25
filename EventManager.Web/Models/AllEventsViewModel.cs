using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel : ILayoutViewModel
    {
		public AllEventsViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages, IEnumerable<EventPreviewViewModel> events, string category, IEnumerable<string> categories)
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

