﻿using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        public IActionResult Index()
        {
            return View(
                new UsersViewModel(
                    new LayoutViewModel(
                        true,
                        true,
                        Array.Empty<MessageViewModel>()
                    ),
                    from user in _userService.AllUsers
                    select new UserPreviewPartialViewModel(user)));
        }
    }
}
