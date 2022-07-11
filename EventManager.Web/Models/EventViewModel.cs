
namespace EventManager.Web.Models
{
	public class EventViewModel
	{
		public EventViewModel(string name, string category, string description, string status, string image, TicketTableViewModel ticketTable)
		{
			this.Name = name;
			this.Category = category;
			this.Description = description;
            this.DateRange = "a range of dates";
            this.TimeRange = "a range of times";
			this.Status = status;
            this.Image = string.Format("/images/{0}", image);
            this.TicketTable = ticketTable;
		}

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

