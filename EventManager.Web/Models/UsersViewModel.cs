namespace EventManager.Web.Models
{
    public class UsersViewModel : ILayoutViewModel
    {
        public UsersViewModel(
            ILayoutViewModel layoutViewModel,
            IEnumerable<UserPreviewPartialViewModel> users
        )
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.Users = users;
        }
        // parent template items
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        public IEnumerable<UserPreviewPartialViewModel> Users { get; }
    }
}

