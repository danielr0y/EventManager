using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    true,
                    false,
                    Array.Empty<MessageViewModel>(),
                    new[]
                    {
                        new EventPreviewViewModel(
                            "Some Inactive event",
                            "n/a",
                            "n/a",
                            "Havent really got a descirption for this lazi boi yet",
                            "inactive",
                            "0",
                            "#"
                        ),
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
                    },
                    "Fireworks",
                    new[]
                    {
                        "All Categories",
                        "Fireworks",
                        "Fundraiser",
                        "Gastronomy",
                        "Romantic"
                    }
                )
            );
        }

        // GET: /<controller>/id
        public IActionResult Event(string name)
        {
            return View(
                new EventViewModel(
                    true,
                    false,
                    new[]
                    {
                        new MessageViewModel(Color.info, "This route currently displays the same information regardless of which event was actually requested"),
                    },
                    "Sirromet Wine and Dine",
                    "Gastronomy",
                    "Three nights a week for 4 weeks over Spring, The Wheel of Brisbane and Sirromet are teaming up to bring you and your partner a dining experience like no other. Leave the kids with uncle Bob and treat your partner to the romantic dinner for two they've been dreaming of.",
                    "upcoming",
                    "wine.jpg",
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
                    )
                )
            );
        }
    }
}

