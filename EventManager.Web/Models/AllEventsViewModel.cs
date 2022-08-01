using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel : ILayoutViewModel
    {
		public AllEventsViewModel(ILayoutViewModel layoutViewModel, SearchPartialViewModel searchPartialViewModel, IEnumerable<EventPreviewPartialViewModel> events)
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.SearchPartialViewModel = searchPartialViewModel;

            this.Heading = "All Events";
			this.Events = events;
        }
        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        // SearchPartialView
        public SearchPartialViewModel SearchPartialViewModel { get; }

        // this
        public string Heading { get; }
        public IEnumerable<EventPreviewPartialViewModel> Events { get; }
        public int NumberOfEvents { get { return this.Events.Count(); } }
    }
}

