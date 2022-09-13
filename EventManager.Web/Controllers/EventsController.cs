using EventManager.DomainLayer;
using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ITicketService _ticketService;

        public EventsController(IEventService eventService, ITicketService ticketService)
        {
            _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
            _ticketService = ticketService ?? throw new ArgumentNullException(nameof(ticketService));
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

        public IActionResult Event(int id)
        {
            var Event = _eventService.GetEvent(id);

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
                    Event,
                    new TicketTableViewModel(
                        new TicketTableTimeRowViewModel(
                            from timeCell in _ticketService.FormatDataForTicketTableTimeRow(Event.Tickets)
                            select new TicketTableTimeCellViewModel(timeCell)
                        ),
                        from dateRow in _ticketService.FormatDataForTicketTableDateRows(Event.Tickets)
                        select new TicketTableDateRowViewModel(
                            dateRow.Key,
                            from ticket in dateRow
                            select new TicketTableTicketCellViewModel(ticket)
                        )
                    ),
                    from review in Event.Reviews
                    select new ReviewPartialViewModel(review)
                )
            );
        }

        public IActionResult Edit(int id)
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
                    _eventService.GetEvent(id)));
        }
    }
}