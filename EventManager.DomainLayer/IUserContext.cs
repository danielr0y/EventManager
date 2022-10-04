namespace EventManager.DomainLayer
{
    public interface IUserContext
    {
        User CurrentUser { get; }
        bool IsAuthenticated { get; }
        bool IsAdmin { get; }
        int Id { get; }
    }
}