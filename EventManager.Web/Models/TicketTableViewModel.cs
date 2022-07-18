
namespace EventManager.Web.Models
{
	public class TicketTableViewModel
	{
		public TicketTableViewModel(TicketTableTimeRowViewModel timeRow, TicketTableDateRowViewModel[] dateRows)
		{
			this.TimeRow = timeRow;
			this.DateRows = dateRows;
			this.Width = this.TimeRow.Times.Length + 1;
		}

        public TicketTableTimeRowViewModel TimeRow { get; }
        public TicketTableDateRowViewModel[] DateRows { get; }
        public int Width { get; }
    }
}

