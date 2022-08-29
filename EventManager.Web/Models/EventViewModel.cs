
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class EventViewModel : ILayoutViewModel
    {
        public EventViewModel(ILayoutViewModel layoutViewModel, Event Event, TicketTableViewModel ticketTable, IEnumerable<ReviewPartialViewModel> reviews)
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.Id = Event.Id;
            this.Name = Event.Name;
			this.Category = Event.Category;
			this.Description = Event.Description;
            this.DateRange = Event.DateRange;
            this.TimeRange = Event.TimeRange;
            this.LowestPrice = Event.LowestPrice.ToString();
            this.EventStatus = Event.Status.ToString();
            this.IsUpcoming = (Event.Status == Status.Upcoming);
            this.UIColor = UI.GetColorByStatus(Event.Status).ToString();
            this.Image = string.Format("/images/{0}", Event.Image);
            this.TicketTable = ticketTable;
            this.Reviews = reviews;
        }
        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

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
        public int NumberOfReviews { get { return this.Reviews.Count(); } }
    }
}

