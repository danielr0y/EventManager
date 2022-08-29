using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class BookingPreviewPartialViewModel
    {
        public BookingPreviewPartialViewModel(Booking booking, Ticket ticket, Event Event)
        {
            bool isUpcoming = (Event.Status == Status.Upcoming);

            this.Id = booking.Id;
            this.EventId = Event.Id;
            this.EventName = Event.Name;
            this.EventImage = string.Format("/images/{0}", Event.Image);
            this.TicketDate = string.Format("{0:dd/MM/yy}", ticket.DateTime);
            this.TicketTime = string.Format("{0:H:mm}", ticket.DateTime);
            this.PurchasePrice = booking.PurchasePrice.ToString();
            this.PurchaseDate = string.Format("{0:dd/MM/yy H:mm}", booking.PurchaseDate);
            this.Qty = booking.Qty;
            this.EventStatus = Event.Status.ToString();
            this.IsUpcomingEvent = isUpcoming;
            this.ButtonText = isUpcoming ? "View booking" : "Leave a review";
            this.UIColor = UI.GetColorByStatus(Event.Status).ToString();

            this.EventExcerpt = Event.Excerpt;
        }

        public int Id { get; }
        public int EventId { get; }
        public string EventName { get; }
        public string EventImage { get; }
        public string TicketDate { get; }
        public string TicketTime { get; }
        public string PurchasePrice { get; }
        public string PurchaseDate { get; }
        public decimal Qty { get; }
        public string EventStatus { get; }
        public bool IsUpcomingEvent { get; }
        public string ButtonText { get; }
        public string UIColor { get; }

        public string EventExcerpt { get; }
    }
}
