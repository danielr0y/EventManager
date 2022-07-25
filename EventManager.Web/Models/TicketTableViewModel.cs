
namespace EventManager.Web.Models
{
	public class TicketTableViewModel
	{
		public TicketTableViewModel(TicketTableTimeRowViewModel timeRow, IEnumerable<TicketTableDateRowViewModel> dateRows)
		{
			this.TimeRow = timeRow;
			this.DateRows = dateRows;
			this.Width = this.TimeRow.NumberOfCells + 1;
		}

        public TicketTableTimeRowViewModel TimeRow { get; }
        public IEnumerable<TicketTableDateRowViewModel> DateRows { get; }
        public int Width { get; }
    }
}

