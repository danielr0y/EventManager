using EventManager.DomainLayer;
using EventManager.Web.Models;

namespace EventManager.Web
{
    public class AspNetUserContextAdapter : IUserContext
    {
        public bool IsAuthenticated => true;
        public bool IsAdmin => false;
        public int Id => 2;
    }
}