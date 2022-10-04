using EventManager.DomainLayer;
using EventManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ITicketService _ticketService;
        private readonly IUserContext _userContext;

        public EventsController(
            IEventService eventService, 
            ITicketService ticketService, 
            IUserContext userContext
        )
        {
            _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
            _ticketService = ticketService ?? throw new ArgumentNullException(nameof(ticketService));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }

        // GET: /<controller>/?search&category
        public IActionResult Index(string? category, string? search)
        {
            return View(
                new AllEventsViewModel(
                    new LayoutViewModel(
                        _userContext,
                        Array.Empty<MessageViewModel>(),
                        new LoginFormPartialViewModel()
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
                        _userContext,
                        new[]
                        {
                            new MessageViewModel(Color.info, "This route currently displays the same information regardless of which event was actually requested"),
                        },
                        new LoginFormPartialViewModel()
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
                        _userContext,
                        new[]
                        {
                            new MessageViewModel(Color.info, "This route currently displays the same information regardless of which event was actually requested"),
                        },
                        new LoginFormPartialViewModel()
                    ),
                    _eventService.Categories,
                    _eventService.Statuses,
                    _eventService.GetEvent(id)));
        }
    }
}