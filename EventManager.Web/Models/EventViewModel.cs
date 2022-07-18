
namespace EventManager.Web.Models
{
	public class EventViewModel : ILayoutViewModel
	{
        public EventViewModel(bool isAuthenticated, bool isAdmin, MessageViewModel[] messages, string name, string category, string description, Status status, string image, TicketTableViewModel ticketTable, ReviewViewModel[] reviews)
		{
            this.IsAuthenticated = isAuthenticated;
            this.IsAdmin = isAdmin;
            this.Messages = messages;

			this.Name = name;
			this.Category = category;
			this.Description = description;
            this.DateRange = "a range of dates";
            this.TimeRange = "a range of times";
			this.Status = status;
            this.Image = string.Format("/images/{0}", image);
            this.TicketTable = ticketTable;
		}

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public MessageViewModel[] Messages { get; }

        public string Name { get; }
        public string Category { get; }
        public string Description { get; }
        public string DateRange { get; }
        public string TimeRange { get; }
        public decimal PricedFrom { get; }
        public string Status { get; }
        public string Image { get; }
        public TicketTableViewModel TicketTable { get; }
    }
}

