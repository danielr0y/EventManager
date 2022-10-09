using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;
using System;

namespace EventManager.Web.Controllers;

public class BookingsController : Controller
{
    private readonly IBookingService _bookingService;
    private readonly IUserService _userService;
    private readonly IUserContext _userContext;

    public BookingsController(IBookingService bookingService, IUserService userService, IUserContext userContext)
    {
        _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
    }

    public IActionResult Index()
    {
        return View(
            new BookingsViewModel(
                new LayoutViewModel(
                    _userContext,
                    Array.Empty<MessageViewModel>(),
                    new LoginFormPartialViewModel()
                ),
                from booking in _bookingService.GetBookingsBy(_userContext.GetCurrentUser(_userService))
                select new BookingPreviewPartialViewModel(booking)));
    }
}

