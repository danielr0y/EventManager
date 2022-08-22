namespace EventManager.DomainLayer
{
    public interface IUserService
    {
        IEnumerable<User> AllUsers { get; }
    }
}