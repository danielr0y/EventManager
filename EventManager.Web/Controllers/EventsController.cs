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
        private readonly IEventService _eventService;

        public EventsController(IEventService service)
        {
            if (service == null)
            {
                throw new ArgumentNullException("service");
            }

            _eventService = service;
        }

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
                    from Event in _eventService.GetAllEvents()
                    select new EventPreviewViewModel(Event)
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
                    _eventService.GetEvent(name),
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

