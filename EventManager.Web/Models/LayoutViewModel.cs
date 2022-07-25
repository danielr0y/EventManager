namespace EventManager.Web.Models
{
    public class LayoutViewModel : ILayoutViewModel
    {
        public LayoutViewModel(bool isAuthenticated, bool isAdmin, IEnumerable<MessageViewModel> messages)
        {
            this.IsAuthenticated = isAuthenticated;
            this.IsAdmin = isAdmin;
            this.Messages = messages;
        }

        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get { return this.Messages.Count(); } }
    }
}