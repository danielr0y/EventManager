namespace EventManager.Web.Models
{
    public class LayoutViewModel : ILayoutViewModel
    {
        public LayoutViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages)
        {
            IsAuthenticated = isAuthenticated;
            IsAdmin = isAdmin;
            Messages = messages;
        }

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages => Messages.Count();
    }
}