
namespace EventManager.Web.Models
{
	public class TicketTableDateRowViewModel
	{
		public TicketTableDateRowViewModel(DateOnly date, IEnumerable<TicketTableTicketCellViewModel> tickets)
		{
			Date = date;
			Tickets = tickets;
		}

        public DateOnly Date { get; }
        public IEnumerable<TicketTableTicketCellViewModel> Tickets { get; }
    }
}

