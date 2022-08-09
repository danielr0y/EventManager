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

        // GET: /<controller>/?search&category
        public IActionResult Index(string? category, string? search)
        {
            return View(
                new AllEventsViewModel(
                    new LayoutViewModel(
                        true,
                        true,
                        Array.Empty<MessageViewModel>()
                    ),
                    new SearchPartialViewModel(
                        search,
                        category,
                        _eventService.Categories
                    ),
                    new EventsPartialViewModel(
                        "Ordered reverse chronologically including past events",
                        from Event in _eventService.GetEventsBy(category, search)
                        select new EventPreviewPartialViewModel(Event)
                    )
                )
            );
        }

        // GET: /<controller>/Event/id
        public IActionResult Event(string name)
        {
            return View(
                new EventViewModel(
                    new LayoutViewModel(
                        true,
                        true,
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

        // GET: /<controller>/Edit/name
        public IActionResult Edit(string eventName)
        {
            return View(
                new EditEventViewModel(
                    new LayoutViewModel(
                        true,
                        true,
                        new[]
                        {
                            new MessageViewModel(Color.info, "This route currently displays the same information regardless of which event was actually requested"),
                        }
                    ),
                    _eventService.Categories,
                    _eventService.Statuses,
                    _eventService.GetEvent(eventName)));
        }
    }
}

