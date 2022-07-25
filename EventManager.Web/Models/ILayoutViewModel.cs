namespace EventManager.Web.Models
{
    public interface ILayoutViewModel
    {
        bool IsAuthenticated { get; }
        bool IsAdmin { get; }
        IEnumerable<MessageViewModel> Messages { get; }
        int NumberOfMessages { get; }
    }
}