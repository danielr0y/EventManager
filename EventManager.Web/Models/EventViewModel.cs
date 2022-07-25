
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class EventViewModel : ILayoutViewModel
    {
        /* a few questions here.
         * 
         * is this an example of contructor over injection?
         * should I be sending full objects to this viewModel and then removing what I need? eg.) IUserContext.IsAdmin? or do I just ask for what I need– bool IsAdmin?
         * the later is what gives me so many arguements
         */
        public EventViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages, string name, string category, string description, Status status, string image, TicketTableViewModel ticketTable, IEnumerable<ReviewViewModel> reviews)
        {
            this.IsAuthenticated = isAuthenticated;
            this.IsAdmin = isAdmin;
            this.Messages = messages;

            this.Name = name;
			this.Category = category;
			this.Description = description;
            this.DateRange = "a range of dates";
            this.TimeRange = "a range of times";
			this.EventStatus = status.ToString();
            this.IsUpcoming = (status == Status.Upcoming);
            this.UIColor = UI.GetColorByStatus(status).ToString();
            this.Image = string.Format("/images/{0}", image);
            this.TicketTable = ticketTable;
            this.Reviews = reviews;
        }

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get { return this.Messages.Count(); } }

        public string Name { get; }
        public string Category { get; }
        public string Description { get; }
        public string DateRange { get; }
        public string TimeRange { get; }
        public decimal PricedFrom { get; }
        public string EventStatus { get; }
        public bool IsUpcoming { get; }
        public string UIColor { get; }
        public string Image { get; }
        public TicketTableViewModel TicketTable { get; }
        public IEnumerable<ReviewViewModel> Reviews { get; }
        public int NumberOfReviews { get { return this.Reviews.Count(); } }
    }
}

