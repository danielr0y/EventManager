using System;
namespace EventManager.Web.Models
{
	public class AllEventsViewModel : ILayoutViewModel
    {
		public AllEventsViewModel(
            ILayoutViewModel layoutViewModel, 
            SearchPartialViewModel searchPartialViewModel, 
            EventsPartialViewModel events
        )
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.SearchPartialViewModel = searchPartialViewModel;

			this.Events = events;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        // search box
        public SearchPartialViewModel SearchPartialViewModel { get; }

        public string Heading { get; } = "All Events";
        // events
        public EventsPartialViewModel Events { get; }
    }
}

