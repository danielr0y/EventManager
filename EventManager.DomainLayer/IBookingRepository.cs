namespace EventManager.DomainLayer
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetBookingsBy(User user);
    }
}