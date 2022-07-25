
namespace EventManager.Web.Models
{
	public class TicketTableDateRowViewModel
	{
		public TicketTableDateRowViewModel(DateOnly date, IEnumerable<TicketTableTicketCellViewModel> tickets)
		{
			this.Date = date;
			this.Tickets = tickets;
		}

        public DateOnly Date { get; }
        public IEnumerable<TicketTableTicketCellViewModel> Tickets { get; }
    }
}

