using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public enum Color { primary, secondary, success, danger, warning, info, light, dark }

    static class UI
    {
        public static Color GetColorByStatus(Status status) => 
            new Dictionary<Status, Color>
            {
                { Status.Upcoming, Color.success },
                { Status.Inactive, Color.light },
                { Status.Cancelled, Color.danger },
                { Status.BookedOut, Color.dark }
            }[status];
        
        public static Color GetColorByActionPriviledge(UserRole requiredPriviledge) => 
            new Dictionary<UserRole, Color>
            {
                { UserRole.Admin, Color.primary },
                { UserRole.Customer, Color.success }
            }[requiredPriviledge];
    }
}