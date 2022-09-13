
namespace EventManager.Web.Models
{
	public class TicketTableTimeCellViewModel
	{
		public TicketTableTimeCellViewModel(TimeOnly time)
		{
			Time = time;
		}

        public TimeOnly Time { get; }
    }
}

