
namespace EventManager.Web.Models
{
	public class TicketTableViewModel
	{
		public TicketTableViewModel(
			TicketTableTimeRowViewModel timeRow, 
			IEnumerable<TicketTableDateRowViewModel> dateRows
		)
		{
			TimeRow = timeRow;
			DateRows = dateRows;
			Width = timeRow.NumberOfCells + 1;
		}

        public TicketTableTimeRowViewModel TimeRow { get; }
        public IEnumerable<TicketTableDateRowViewModel> DateRows { get; }
        public int Width { get; }
    }
}

