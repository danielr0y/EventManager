namespace EventManager.Web.Models
{
	public class EventPreviewViewModel
	{
		public EventPreviewViewModel(String name, String dateRange, String timeRange, String excerpt, String status, String lowestPrice, String eventUrl)
        {
            this.Name = name;
            this.DateRange = dateRange;
            this.TimeRange = timeRange;
            this.Excerpt = excerpt;
            this.Status = status;
            this.LowestPrice = lowestPrice;
            this.EventUrl = eventUrl;
        }

        public String Name { get; }
        public String DateRange { get; }
        public String TimeRange { get; }
        public String Excerpt { get; }
        public String Status { get; }
        public String LowestPrice { get; }
        public String EventUrl { get; }
    }
}
