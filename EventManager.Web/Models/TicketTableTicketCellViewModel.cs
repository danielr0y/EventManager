
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class TicketTableTicketCellViewModel
	{
		public TicketTableTicketCellViewModel(Ticket ticket)
		{
			Id = ticket.Id;
			Price = ticket.Price;
			Remaining = ticket.RemainingGondolas;
		}

        public int Id { get; }
        public decimal Price { get; }
        public int Remaining { get; }
    }
}

