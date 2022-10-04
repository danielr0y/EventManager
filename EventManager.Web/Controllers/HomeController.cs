using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers;

public class HomeController : Controller
{
    private readonly IEventService _eventService;
    private readonly IUserContext _userContext;

    public HomeController(IEventService eventService, IUserContext userContext)
    {
        _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
        _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
    }

    public IActionResult Index()
    {
        return View(
            new HomeViewModel(
                new LayoutViewModel(
                    _userContext,
                    Array.Empty<MessageViewModel>(),
                    new LoginFormPartialViewModel()
                ),
                new SearchPartialViewModel(
                    null,
                    null,
                    _eventService.Categories
                ),
                new EventsPartialViewModel(
                    "Upcoming Events",
                    from Event in _eventService.UpcomingEvents
                    select new EventPreviewPartialViewModel(Event)
                ),
                new EventsPartialViewModel(
                    "Cancelled Events",
                    from Event in _eventService.CancelledEvents
                    select new EventPreviewPartialViewModel(Event)
                )
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

