using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers;

public class HomeController : Controller
{
    private readonly IEventService _eventService;

    public HomeController(IEventService eventService)
    {
        if (eventService == null)
        {
            throw new ArgumentNullException("eventService");
        }

        _eventService = eventService;
    }

    public IActionResult Index()
    {
        return View(
            new UpcomingEventsViewModel(
                new LayoutViewModel(
                    true,
                    true,
                    Array.Empty<MessageViewModel>()
                ),
                new SearchPartialViewModel(
                    null,
                    null,
                    _eventService.Categories
                ),
                from Event in _eventService.GetUpcomingEvents()
                select new EventPreviewPartialViewModel(Event)
            )
        );
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

