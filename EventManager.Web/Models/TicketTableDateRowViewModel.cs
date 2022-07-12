
namespace EventManager.Web.Models
{
	public class TicketTableDateRowViewModel
	{
		public TicketTableDateRowViewModel(DateOnly date, TicketTableTicketCellViewModel[] tickets)
		{
			this.Date = date;
			this.Tickets = tickets;
		}

        public DateOnly Date { get; }
        public TicketTableTicketCellViewModel[] Tickets { get; }
    }
}

