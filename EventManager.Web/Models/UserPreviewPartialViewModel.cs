using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class UserPreviewPartialViewModel
    {
        public UserPreviewPartialViewModel(User user)
        {
            var isAdmin = user.HasUserRole(UserRole.Admin);

            Name = user.Name;
            Id = user.Id;
            Email = user.Email;
            UIColor = UI.GetColorByActionPriviledge(UserRole.Admin).ToString();
            ButtonText = isAdmin ? "Revoke Admin Priviledges" : "Grant Admin Priviledges";
        }

        public string Name { get; }
        public int Id { get; }
        public string Email { get; }
        public string UIColor { get; }
        public string ButtonText { get; }
    }
}
