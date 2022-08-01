using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class EventPreviewPartialViewModel
    {
        public EventPreviewPartialViewModel(Event Event)
        {
            bool isUpcoming = (Event.Status == Status.Upcoming);

            this.Name = Event.Name;
            this.DateRange = Event.DateRange;
            this.TimeRange = Event.TimeRange;
            this.Excerpt = Event.Excerpt;
            this.EventStatus = Event.Status.ToString();
            this.UIColor = UI.GetColorByStatus(Event.Status).ToString();
            this.LowestPrice = Event.LowestPrice.ToString();
            this.ButtonText = isUpcoming ? "View Event" : Event.Status.ToString();
            this.Image = string.Format("/images/{0}", Event.Image);
        }

        public String Name { get; }
        public String DateRange { get; }
        public String TimeRange { get; }
        public String Excerpt { get; }
        public String EventStatus { get; }
        public String UIColor { get; }
        public String ButtonText { get; }
        public String LowestPrice { get; }
        public String Image { get; }
    }
}
