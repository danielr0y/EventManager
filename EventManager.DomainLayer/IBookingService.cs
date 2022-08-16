namespace EventManager.DomainLayer
{
    public interface IBookingService
    {
        IEnumerable<Booking> Bookings { get; }
    }
}