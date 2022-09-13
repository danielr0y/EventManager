using EventManager.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace EventManager.DataLayer
{
    public class BookingRepository : IBookingRepository
    {
        private readonly EventManagerContext _context;
        public BookingRepository(EventManagerContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<Booking> GetBookingsBy(User user) =>
            from booking in _context.Bookings
                .Include(booking => booking.User)
                .Include(booking => booking.Ticket)
                .ThenInclude(ticket => ticket.Event)
            where booking.User == user
            select booking;
    }
}