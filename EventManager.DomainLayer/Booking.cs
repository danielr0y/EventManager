namespace EventManager.DomainLayer
{
    public class Booking
    {
        public Booking(int id, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate, Event Event)
        {
            this.Id = id;
            this.Qty = qty;
            this.PurchasePrice = purchasePrice;
            this.PurchaseDate = purchaseDate;
            this.Ticket = ticket;
            this.Event = Event;
        }

        public int Id { get; set; }
        public int Qty { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Ticket Ticket { get; set; }
        public Event Event { get; }
    }
}