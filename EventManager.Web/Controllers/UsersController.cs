using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserContext _userContext;

        public UsersController(IUserService userService, IUserContext userContext)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }

        public IActionResult Index()
        {
            return View(
                new UsersViewModel(
                    new LayoutViewModel(
                        _userContext,
                        Array.Empty<MessageViewModel>(),
                        new LoginFormPartialViewModel()
                    ),
                    from user in _userService.AllUsers
                    select new UserPreviewPartialViewModel(user)));
        }
    }
}

