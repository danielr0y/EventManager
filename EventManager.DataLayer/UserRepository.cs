using EventManager.DomainLayer;

namespace EventManager.DataLayer;

public class UserRepository : IUserRepository
{
    private readonly EventManagerContext _dbContext; 

    public UserRepository(EventManagerContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public IEnumerable<User> AllUsers =>
        from user in _dbContext.Users
        select user;

    public User GetUser(int id) => _dbContext.Users.Single(user => user.Id == id);
}