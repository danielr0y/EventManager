using System;
namespace EventManager.DomainLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserContext _userContext;
        public UserService(IUserRepository userRepository, IUserContext userContext)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }
        public IEnumerable<User> AllUsers => _userRepository.AllUsers;
        public User CurrentUser => GetUser(_userContext.Id);

        public User GetUser(int id) => _userRepository.GetUser(id);
    }

}

