namespace EventManager.DomainLayer
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetBookingsBy(User user);
    }
}