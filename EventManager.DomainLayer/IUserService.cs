namespace EventManager.DomainLayer
{
    public interface IUserService
    {
        IEnumerable<User> AllUsers { get; }
        User CurrentUser { get; }
        User GetUser(int id);
    }
}