using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class BookingPreviewPartialViewModel
    {
        public BookingPreviewPartialViewModel(Booking booking)
        {
            bool isUpcoming = (booking.Ticket.Event.Status == Status.Upcoming);

            this.Id = booking.Id;
            this.EventId = booking.Ticket.Event.Id;
            this.EventName = booking.Ticket.Event.Name;
            this.EventImage = string.Format("/images/{0}", booking.Ticket.Event.Image);
            this.TicketDate = string.Format("{0:dd/MM/yy}", booking.Ticket.DateTime);
            this.TicketTime = string.Format("{0:H:mm}", booking.Ticket.DateTime);
            this.PurchasePrice = booking.PurchasePrice.ToString();
            this.PurchaseDate = string.Format("{0:dd/MM/yy H:mm}", booking.PurchaseDate);
            this.Qty = booking.Qty;
            this.EventStatus = booking.Ticket.Event.Status.ToString();
            this.IsUpcomingEvent = isUpcoming;
            this.ButtonText = isUpcoming ? "View booking" : "Leave a review";
            this.UIColor = UI.GetColorByStatus(booking.Ticket.Event.Status).ToString();

            this.EventExcerpt = booking.Ticket.Event.Excerpt;
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
