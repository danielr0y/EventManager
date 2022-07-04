using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class EventViewModel
	{
		public EventViewModel(String name, String description, String status)
		{
			this.Name = name;
			this.Description = description;
			this.Status = status;
		}

        public String Name { get; }
        public String Description { get; }
        public String Status { get; }
    }
}

