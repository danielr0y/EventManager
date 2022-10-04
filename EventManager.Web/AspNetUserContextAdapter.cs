using EventManager.DomainLayer;
using EventManager.Web.Models;

namespace EventManager.Web
{
    public class AspNetUserContextAdapter : IUserContext
    {
        private static readonly HttpContextAccessor Accessor = new HttpContextAccessor();
        public bool IsAuthenticated => Accessor.HttpContext.User.Identity.IsAuthenticated;
        public bool IsAdmin => Accessor.HttpContext.User.IsInRole(UserRole.Admin.ToString());
        public User CurrentUser { get; }
    }
}