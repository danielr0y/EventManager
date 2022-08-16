namespace EventManager.Web.Models
{
    public class BookingsViewModel : ILayoutViewModel
    {
        public BookingsViewModel(
            ILayoutViewModel layoutViewModel,
            IEnumerable<BookingPreviewPartialViewModel> bookings
        )
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.Bookings = bookings;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        public IEnumerable<BookingPreviewPartialViewModel> Bookings { get; }
    }
}

