using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;
using System;

namespace EventManager.Web.Controllers;

public class BookingsController : Controller
{
    private readonly IBookingService _bookingService;
    private readonly IUserService _userService;

    public BookingsController(IBookingService bookingService, IUserService userService)
    {
        _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
    }

    public IActionResult Index()
    {
        return View(
            new BookingsViewModel(
                new LayoutViewModel(
                    true,
                    true,
                    Array.Empty<MessageViewModel>()
                ),
                from booking in _bookingService.GetBookingsBy(_userService.CurrentUser)
                select new BookingPreviewPartialViewModel(booking)));
    }
}

