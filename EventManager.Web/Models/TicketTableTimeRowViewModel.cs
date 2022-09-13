
namespace EventManager.Web.Models
{
	public class TicketTableTimeRowViewModel
	{
		public TicketTableTimeRowViewModel(IEnumerable<TicketTableTimeCellViewModel> times)
		{
			Times = times;
		}

        public IEnumerable<TicketTableTimeCellViewModel> Times { get; }
        public int NumberOfCells => Times.Count();
    }
}

