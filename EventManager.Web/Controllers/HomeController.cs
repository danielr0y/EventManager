using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using EventManager.Web.Models;

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
                true,
                false,
                Array.Empty<MessageViewModel>(),
                new[]
                {
                    new EventPreviewViewModel(
                        "Sirromet Wine and Dine",
                        "from: 30/08/2022 until: 31/08/2022",
                        "from: 07:00PM until: 08:00PM",
                        "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                        "upcoming",
                        "90",
                        "#"
                    ),
                    new EventPreviewViewModel(
                        "Sunsuper Riverfire",
                        "on: 25/09/2022",
                        "at: 10pm and 11:30pm",
                        "See Australia's most beautiful city in a new light. As another year of celebrations for our great city draw to a close, Sunsuper and Brisbane Festival will light up the night and you'll have the best seats in the house. Riverfront, sky-high and air-conditioned!",
                        "upcoming",
                        "80",
                        "#"
                    ),
                    new EventPreviewViewModel(
                        "New Year's Eve",
                        "on: 31/12/2022",
                        "at: 8pm and 11:30pm",
                        "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                        "upcoming",
                        "100",
                        "#"
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

