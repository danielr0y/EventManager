using System;
namespace EventManager.DomainLayer
{
    public class UserService : IUserService
    {
        public IEnumerable<User> AllUsers
        {
            get
            {
                return new[]
                {
                    new User(
                        0,
                        "Daniel",
                        "daniel@email.com",
                        UserRole.Admin
                    ),
                    new User(
                        1,
                        "Michelle",
                        "michelle@email.com",
                        UserRole.Customer
                    ),
                    new User(
                        2,
                        "Aaron",
                        "aaron@email.com",
                        UserRole.Customer
                    ),
                    new User(
                        3,
                        "Simon",
                        "simonm@email.com",
                        UserRole.Customer
                    )};
            }
        }
    }
}

