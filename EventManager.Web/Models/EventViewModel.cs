
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class EventViewModel : ILayoutViewModel
    {
        public EventViewModel(
            ILayoutViewModel layoutViewModel, 
            Event Event, 
            TicketTableViewModel ticketTable, 
            IEnumerable<ReviewPartialViewModel> reviews
        )
        {
            IsAuthenticated = layoutViewModel.IsAuthenticated;
            IsAdmin = layoutViewModel.IsAdmin;
            Messages = layoutViewModel.Messages;
            NumberOfMessages = layoutViewModel.NumberOfMessages;
            LoginForm = layoutViewModel.LoginForm;

            Id = Event.Id;
            Name = Event.Name;
			Category = Event.Category;
			Description = Event.Description;
            DateRange = Event.DateRange;
            TimeRange = Event.TimeRange;
            LowestPrice = Event.LowestPrice.ToString();
            EventStatus = Event.Status.ToString();
            IsUpcoming = (Event.Status == Status.Upcoming);
            UIColor = UI.GetColorByStatus(Event.Status).ToString();
            Image = string.Format("/images/{0}", Event.Image);
            TicketTable = ticketTable;
            Reviews = reviews;
        }
        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }
        public LoginFormPartialViewModel LoginForm { get; }

        // this
        public int Id { get; }
        public string Name { get; }
        public string Category { get; }
        public string Description { get; }
        public string DateRange { get; }
        public string TimeRange { get; }
        public string LowestPrice { get; }
        public string EventStatus { get; }
        public bool IsUpcoming { get; }
        public string UIColor { get; }
        public string Image { get; }
        public TicketTableViewModel TicketTable { get; }
        public IEnumerable<ReviewPartialViewModel> Reviews { get; }
        public int NumberOfReviews => Reviews.Count();
    }
}

