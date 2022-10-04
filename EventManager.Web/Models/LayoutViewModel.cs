using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class LayoutViewModel : ILayoutViewModel
    {
        private readonly IUserContext _userContext;
        public LayoutViewModel(
            IUserContext userContext, 
            IEnumerable<MessageViewModel> messages,
            LoginFormPartialViewModel loginForm
        )
        {
            _userContext = userContext;
            Messages = messages;
            LoginForm = loginForm;
        }

        public bool IsAuthenticated => _userContext.IsAuthenticated;
        public bool IsAdmin => _userContext.IsAdmin;
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages => Messages.Count();
        public LoginFormPartialViewModel LoginForm { get; }
    }
}