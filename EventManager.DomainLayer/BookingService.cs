using System;

namespace EventManager.DomainLayer
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<Booking> GetBookingsBy(User user) => _repository.GetBookingsBy(user);
    }
}

