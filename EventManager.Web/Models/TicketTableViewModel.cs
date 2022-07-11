
namespace EventManager.Web.Models
{
	public class TicketTableViewModel
	{
		public TicketTableViewModel(TicketTableTimeRowViewModel timeRow, IEnumerable<TicketTableDateRowViewModel> dateRows)
		{
			this.TimeRow = timeRow;
			this.DateRows = dateRows;
		}

        public TicketTableTimeRowViewModel TimeRow { get; }
        public IEnumerable<TicketTableDateRowViewModel> DateRows { get; }
    }
}

