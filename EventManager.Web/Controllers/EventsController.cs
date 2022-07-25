using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.DomainLayer;
using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventManager.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(
                new AllEventsViewModel(
                    new LayoutViewModel(
                    true,
                    false,
                        Array.Empty<MessageViewModel>()
                        ),
                    new SearchPartialViewModel(
                    "Fireworks",
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
                            "Some Inactive event",
                            "Havent really got an excerpt for this lazi boi yet",
                            "description",
                            "Fundraiser",
                            Status.Upcoming,
                            "michelle.jpg"
                        ),
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
                            Status.Inactive,
                            "newyears.jpg"
                        ),
                        new Event(
                            "New Year's Eve",
                            "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                            "description",
                            "Fireworks",
                            Status.Cancelled,
                            "newyears.jpg"
                        ),
                        new Event(
                            "New Year's Eve",
                            "New Year's Eve on the Wheel of Brisbane is an experience you won't forget. The most sought after tickets we have on offer, these will sell out fast. Book now",
                            "description",
                            "Fireworks",
                            Status.BookedOut,
                            "newyears.jpg"
                        )
                    }
                )
            );
        }

        // GET: /<controller>/id
        public IActionResult Event(string name)
        {
            return View(
                new EventViewModel(
                    new LayoutViewModel(
                    true,
                    false,
                    new[]
                    {
                        new MessageViewModel(Color.info, "This route currently displays the same information regardless of which event was actually requested"),
                        }
                    ),
                    new Event(
                        "Sirromet Wine and Dine",
                        "excerpt",
                        "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                        "Gastronomy",
                        Status.Upcoming,
                        "wine.jpg"
                    ),
                    new TicketTableViewModel(
                        new TicketTableTimeRowViewModel(
                            new[]
                            {
                                new TicketTableTimeCellViewModel(
                                    new TimeOnly(18, 00)
                                ),
                                new TicketTableTimeCellViewModel(
                                    new TimeOnly(19, 00)
                                )
                            }
                        ),
                        new[]
                        {
                            new TicketTableDateRowViewModel(
                                new DateOnly(2022, 07, 30),
                                new[]
                                {
                                    new TicketTableTicketCellViewModel(
                                        0,
                                        120,
                                        12
                                    ),
                                    new TicketTableTicketCellViewModel(
                                        1,
                                        100,
                                        10
                                    ),
                                }
                            ),
                            new TicketTableDateRowViewModel(
                                new DateOnly(2022, 07, 31),
                                new[]
                                {
                                    new TicketTableTicketCellViewModel(
                                        2,
                                        110,
                                        8
                                    ),
                                    new TicketTableTicketCellViewModel(
                                        3,
                                        120,
                                        12
                                    ),
                                }
                            ),
                        }
                    ),
                    new[]
                    {
                        new ReviewViewModel(
                            "Simbro",
                            new DateTime(),
                            "Was sick, eh."
                        ),
                        new ReviewViewModel(
                            "Simbro",
                            new DateTime(),
                            "Was sick, eh."
                        ),
                        new ReviewViewModel(
                            "Simbro",
                            new DateTime(),
                            "Was sick, eh."
                        ),
                        new ReviewViewModel(
                            "Simbro",
                            new DateTime(),
                            "Was sick, eh."
                        ),
                        new ReviewViewModel(
                            "Simbro",
                            new DateTime(),
                            "Was sick, eh."
                        ),
                    }
                )
            );
        }
    }
}

