using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel : ILayoutViewModel, ISearchPartialViewModel
    {
		public AllEventsViewModel(ILayoutViewModel layoutViewModel, ISearchPartialViewModel searchPartialViewModel, IEnumerable<EventPreviewViewModel> events)
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.Category = searchPartialViewModel.Category;
            this.Categories = searchPartialViewModel.Categories;
            this.NumberOfCategories = searchPartialViewModel.NumberOfCategories;

            this.Heading = "All Events";
			this.Events = events;
        }
        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        // ISearchPartialView
        public string Category { get; }
        public IEnumerable<string> Categories { get; }
        public int NumberOfCategories { get; }

        // this
        public string Heading { get; }
        public IEnumerable<EventPreviewViewModel> Events { get; }
        public int NumberOfEvents { get { return this.Events.Count(); } }
    }
}

