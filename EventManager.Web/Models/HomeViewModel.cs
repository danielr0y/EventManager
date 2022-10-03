namespace EventManager.Web.Models
{
	public class HomeViewModel : ILayoutViewModel
    {
		public HomeViewModel(
            ILayoutViewModel layoutViewModel,
            SearchPartialViewModel search,
            EventsPartialViewModel upcomingEvents,
            EventsPartialViewModel cancelledEvents
        )
        {
            IsAuthenticated = layoutViewModel.IsAuthenticated;
            IsAdmin = layoutViewModel.IsAdmin;
            Messages = layoutViewModel.Messages;
            NumberOfMessages = layoutViewModel.NumberOfMessages;
            LoginForm = layoutViewModel.LoginForm;

            Search = search;

            UpcomingEvents = upcomingEvents;
            CancelledEvents = cancelledEvents;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }
        public LoginFormPartialViewModel LoginForm { get; }

        // search box
        public SearchPartialViewModel Search { get; }

        public string Heading { get; } = "The Wheel of Brisbane";
        // the events
        public EventsPartialViewModel UpcomingEvents { get; }
        public EventsPartialViewModel CancelledEvents { get; }
    }
}