namespace EventManager.Web.Models
{
    public class LayoutViewModel : ILayoutViewModel
    {
        public LayoutViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages, LoginFormPartialViewModel loginForm)
        {
            IsAuthenticated = isAuthenticated;
            IsAdmin = isAdmin;
            Messages = messages;
            LoginForm = loginForm;
        }

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages => Messages.Count();
        public LoginFormPartialViewModel LoginForm { get; }
    }
}