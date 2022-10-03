using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public IActionResult Index()
        {
            return View(
                new UsersViewModel(
                    new LayoutViewModel(
                        true,
                        true,
                        Array.Empty<MessageViewModel>(),
                        new LoginFormPartialViewModel()
                    ),
                    from user in _userService.AllUsers
                    select new UserPreviewPartialViewModel(user)));
        }
    }
}

