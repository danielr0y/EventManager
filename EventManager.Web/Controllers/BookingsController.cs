using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;
using System;

namespace EventManager.Web.Controllers;

public class BookingsController : Controller
{
    private readonly IBookingService _bookingService;
    private readonly IEventService _eventService;
    private readonly ITicketService _ticketService;

    public BookingsController(IBookingService bookingService, IEventService eventService, ITicketService ticketService)
    {
        if (bookingService == null)
        {
            throw new ArgumentNullException("bookingService");
        }
        if (eventService == null)
        {
            throw new ArgumentNullException("eventService");
        }
        if (ticketService == null)
        {
            throw new ArgumentNullException("ticketService");
        }

        _bookingService = bookingService;
        _eventService = eventService;
        _ticketService = ticketService;
    }

    public IActionResult Index()
    {
        return View(
            new BookingsViewModel(
                new LayoutViewModel(
                    true,
                    false,
                    Array.Empty<MessageViewModel>()
                ),
                from booking in _bookingService.Bookings
                select new BookingPreviewPartialViewModel(
                    booking,
                    _ticketService.GetTicket(100),
                    _eventService.GetEvent(100))));
    }
}

