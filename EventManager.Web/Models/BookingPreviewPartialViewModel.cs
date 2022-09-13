using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class BookingPreviewPartialViewModel
    {
        public BookingPreviewPartialViewModel(Booking booking)
        {
            bool isUpcoming = (booking.Ticket.Event.Status == Status.Upcoming);

            Id = booking.Id;
            EventId = booking.Ticket.Event.Id;
            EventName = booking.Ticket.Event.Name;
            EventImage = string.Format("/images/{0}", booking.Ticket.Event.Image);
            TicketDate = string.Format("{0:dd/MM/yy}", booking.Ticket.DateTime);
            TicketTime = string.Format("{0:H:mm}", booking.Ticket.DateTime);
            PurchasePrice = booking.PurchasePrice.ToString();
            PurchaseDate = string.Format("{0:dd/MM/yy H:mm}", booking.PurchaseDate);
            Qty = booking.Qty;
            EventStatus = booking.Ticket.Event.Status.ToString();
            IsUpcomingEvent = isUpcoming;
            ButtonText = isUpcoming ? "View booking" : "Leave a review";
            UIColor = UI.GetColorByStatus(booking.Ticket.Event.Status).ToString();

            EventExcerpt = booking.Ticket.Event.Excerpt;
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
