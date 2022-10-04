using System;
namespace EventManager.DomainLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public IEnumerable<User> AllUsers => _userRepository.AllUsers;
        public User GetUser(int id) => _userRepository.GetUser(id);
    }

}

