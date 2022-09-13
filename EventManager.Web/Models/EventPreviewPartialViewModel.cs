using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class EventPreviewPartialViewModel
    {
        public EventPreviewPartialViewModel(Event Event)
        {
            bool isUpcoming = (Event.Status == Status.Upcoming);

            Id = Event.Id;
            Name = Event.Name;
            DateRange = Event.DateRange;
            TimeRange = Event.TimeRange;
            Excerpt = Event.Excerpt;
            EventStatus = Event.Status.ToString();
            UIColor = UI.GetColorByStatus(Event.Status).ToString();
            LowestPrice = Event.LowestPrice.ToString();
            ButtonText = isUpcoming ? "View Event" : Event.Status.ToString();
            Image = string.Format("/images/{0}", Event.Image);
        }

        public int Id { get; }
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
