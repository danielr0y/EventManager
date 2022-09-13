using System;

namespace EventManager.DomainLayer
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this._repository = repository;
        }

        public IEnumerable<Booking> GetBookingsBy(User user) => _repository.GetBookingsBy(user);
    }
}

