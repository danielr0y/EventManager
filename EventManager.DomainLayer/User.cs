using System;
namespace EventManager.DomainLayer
{
    public class User
    {
        public User(int id, string name, string email, UserRole role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Role = role;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }

        public bool HasUserRole(UserRole role)
        {
            return this.Role == role;
        }
    }
}

