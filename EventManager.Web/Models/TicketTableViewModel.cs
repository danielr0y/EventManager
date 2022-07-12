
namespace EventManager.Web.Models
{
	public class TicketTableViewModel
	{
		public TicketTableViewModel(TicketTableTimeRowViewModel timeRow, TicketTableDateRowViewModel[] dateRows)
		{
			this.TimeRow = timeRow;
			this.DateRows = dateRows;
		}

        public TicketTableTimeRowViewModel TimeRow { get; }
        public TicketTableDateRowViewModel[] DateRows { get; }
    }
}

