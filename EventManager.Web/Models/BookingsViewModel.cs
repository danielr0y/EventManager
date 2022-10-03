namespace EventManager.Web.Models
{
    public class BookingsViewModel : ILayoutViewModel
    {
        public BookingsViewModel(
            ILayoutViewModel layoutViewModel,
            IEnumerable<BookingPreviewPartialViewModel> bookings
        )
        {
            IsAuthenticated = layoutViewModel.IsAuthenticated;
            IsAdmin = layoutViewModel.IsAdmin;
            Messages = layoutViewModel.Messages;
            NumberOfMessages = layoutViewModel.NumberOfMessages;
            LoginForm = layoutViewModel.LoginForm;

            Bookings = bookings;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }
        public LoginFormPartialViewModel LoginForm { get; }

        public IEnumerable<BookingPreviewPartialViewModel> Bookings { get; }
    }
}

