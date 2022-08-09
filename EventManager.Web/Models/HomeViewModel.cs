using System;
using System.Collections.Generic;

namespace EventManager.Web.Models
{
	public class HomeViewModel : ILayoutViewModel
    {
		public HomeViewModel(
            ILayoutViewModel layout,
            SearchPartialViewModel search,
            EventsPartialViewModel upcomingEvents,
            EventsPartialViewModel cancelledEvents
        )
        {
            this.IsAuthenticated = layout.IsAuthenticated;
            this.IsAdmin = layout.IsAdmin;
            this.Messages = layout.Messages;
            this.NumberOfMessages = layout.NumberOfMessages;

            this.Search = search;

            this.UpcomingEvents = upcomingEvents;
            this.CancelledEvents = cancelledEvents;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        // search box
        public SearchPartialViewModel Search { get; }

        public string Heading { get; } = "The Wheel of Brisbane";
        // the events
        public EventsPartialViewModel UpcomingEvents { get; }
        public EventsPartialViewModel CancelledEvents { get; }
    }
}