using System;
namespace EventManager.DomainLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        // public IEnumerable<Review> Reviews { get; set; }

        public bool HasUserRole(UserRole role) => this.Role == role;
    }
}

