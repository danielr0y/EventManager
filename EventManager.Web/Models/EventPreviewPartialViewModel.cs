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

        public string Name { get; }
        public string DateRange { get; }
        public string TimeRange { get; }
        public string Excerpt { get; }
        public string EventStatus { get; }
        public string UIColor { get; }
        public string ButtonText { get; }
        public string LowestPrice { get; }
        public string Image { get; }
    }
}
