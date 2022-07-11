
namespace EventManager.Web.Models
{
	public class TicketTableTimeCellViewModel
	{
		public TicketTableTimeCellViewModel(TimeOnly time)
		{
			this.Time = time;
		}

        public TimeOnly Time { get; }
    }
}

