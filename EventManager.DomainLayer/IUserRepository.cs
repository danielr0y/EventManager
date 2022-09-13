namespace EventManager.DomainLayer
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUser(int id);
    }
}