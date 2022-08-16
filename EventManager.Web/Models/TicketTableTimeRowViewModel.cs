
namespace EventManager.Web.Models
{
	public class TicketTableTimeRowViewModel
	{
		public TicketTableTimeRowViewModel(IEnumerable<TicketTableTimeCellViewModel> times)
		{
			this.Times = times;
		}

        public IEnumerable<TicketTableTimeCellViewModel> Times { get; }
        public int NumberOfCells { get { return this.Times.Count(); } }
    }
}

