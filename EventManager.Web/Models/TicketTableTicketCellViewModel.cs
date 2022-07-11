
namespace EventManager.Web.Models
{
	public class TicketTableTicketCellViewModel
	{
		public TicketTableTicketCellViewModel(int id, decimal price, int remaining)
		{
			this.Id = id;
			this.Price = price;
			this.Remaining = remaining;
		}

        public int Id { get; }
        public decimal Price { get; }
        public int Remaining { get; }
    }
}

