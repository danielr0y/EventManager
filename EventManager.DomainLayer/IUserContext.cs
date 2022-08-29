namespace EventManager.DomainLayer
{
    public interface IUserContext
    {
        bool IsAuthenticated { get; }
        bool IsAdmin { get; }
    }
}