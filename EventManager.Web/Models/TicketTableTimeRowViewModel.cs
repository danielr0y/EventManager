
namespace EventManager.Web.Models
{
	public class TicketTableTimeRowViewModel
	{
		public TicketTableTimeRowViewModel(TicketTableTimeCellViewModel[] times)
		{
			this.Times = times;
		}

        public TicketTableTimeCellViewModel[] Times { get; }
    }
}

