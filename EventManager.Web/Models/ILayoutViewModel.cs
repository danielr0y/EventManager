namespace EventManager.Web.Models
{
    public interface ILayoutViewModel
    {
        bool IsAuthenticated { get; }
        bool IsAdmin { get; }
        MessageViewModel[] Messages { get; }
    }
}