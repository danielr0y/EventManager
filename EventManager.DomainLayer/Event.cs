namespace EventManager.DomainLayer
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Excerpt { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Status Status { get; set; }
        public string Image { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public string DateRange { get { return "method not yet implemented"; } }
        public string TimeRange { get { return "method not yet implemented"; } }
        public decimal LowestPrice { get { return 0; } }
    }
}