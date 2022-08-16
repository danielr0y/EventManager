
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class TicketTableTicketCellViewModel
	{
		public TicketTableTicketCellViewModel(Ticket ticket)
		{
			this.Id = ticket.Id;
			this.Price = ticket.Price;
			this.Remaining = ticket.RemainingGondolas;
		}

        public int Id { get; }
        public decimal Price { get; }
        public int Remaining { get; }
    }
}

