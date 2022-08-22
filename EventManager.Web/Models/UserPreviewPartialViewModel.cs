using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class UserPreviewPartialViewModel
    {
        public UserPreviewPartialViewModel(User user)
        {
            var isAdmin = user.HasUserRole(UserRole.Admin);

            this.Name = user.Name;
            this.Id = user.Id.ToString();
            this.Email = user.Email;
            this.UIColor = UI.GetColorByActionPriviledge(UserRole.Admin).ToString();
            this.ButtonText = isAdmin ? "Revoke Admin Priviledges" : "Grant Admin Priviledges";
        }

        public string Name { get; }
        public string Id { get; }
        public string Email { get; }
        public string UIColor { get; }
        public string ButtonText { get; }
    }
}
