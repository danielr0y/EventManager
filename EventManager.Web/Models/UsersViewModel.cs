namespace EventManager.Web.Models
{
    public class UsersViewModel : ILayoutViewModel
    {
        public UsersViewModel(
            ILayoutViewModel layoutViewModel,
            IEnumerable<UserPreviewPartialViewModel> users
        )
        {
            IsAuthenticated = layoutViewModel.IsAuthenticated;
            IsAdmin = layoutViewModel.IsAdmin;
            Messages = layoutViewModel.Messages;
            NumberOfMessages = layoutViewModel.NumberOfMessages;
            LoginForm = layoutViewModel.LoginForm;

            Users = users;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }
        public LoginFormPartialViewModel LoginForm { get; }

        public IEnumerable<UserPreviewPartialViewModel> Users { get; }
    }
}

