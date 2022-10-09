namespace EventManager.DomainLayer
{
    public interface IUserService
    {
        IEnumerable<User> AllUsers { get; }
        User GetUser(int id);
        User GetUser(string email);
    }
}