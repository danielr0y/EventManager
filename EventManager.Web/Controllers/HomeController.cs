using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;
using EventManager.DomainLayer;

namespace EventManager.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(
            new UpcomingEventsViewModel(
                new LayoutViewModel(
                true,
                false,
                    Array.Empty<MessageViewModel>()
                    ),
                new SearchPartialViewModel(
                "All Categories",
                new[]
                {
                    "All Categories",
                    "Fireworks",
                    "Fundraiser",
                    "Gastronomy",
                    "Romantic"
                }
                ),
                new[]
                {
                    new Event(
                        "Sirromet Wine and Dine",
                        "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                        "description",
                        "Gastronomy",
                        Status.Upcoming,
                        "wine.jpg"
                    ),
                    new Event(
                        "Sunsuper Riverfire",
                        "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                        "description",
                        "Fireworks",
                        Status.Upcoming,
                        "fireworks.jpg"
                    ),
                    new Event(
                        "New Year's Eve",
                        "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                        "description",
                        "Fireworks",
                        Status.Upcoming,
                        "newyears.jpg"
                    ),
                }
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

