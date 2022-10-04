using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using EventManager.DataLayer;
using EventManager.DomainLayer;
using EventManager.Web.Controllers;

namespace EventManager.Web
{
    public class EventManagerControllerActivator : IControllerActivator
    {
        private readonly IUserContext _userContext;
        private readonly EventManagerConfiguration _configuration;

        public EventManagerControllerActivator(EventManagerConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _userContext = new AspNetUserContextAdapter();
        }

        public object Create(ControllerContext context) => 
            Create(context.ActionDescriptor.ControllerTypeInfo.AsType());

        public void Release(ControllerContext context, object controller) =>
            (controller as IDisposable)?.Dispose();

        public Controller Create(Type type)
        {
            var dbContext = new EventManagerContext(_configuration.ConnectionString);
            
            var userService = new UserService(new UserRepository(dbContext));
            var eventService = new EventService(new EventRepository(dbContext));
            var ticketService = new TicketService(new TicketRepository(dbContext));
            var bookingService = new BookingService(new BookingRepository(dbContext));


            switch (type.Name)
            {
                case nameof(HomeController):
                    return new HomeController(eventService, _userContext);

                case nameof(EventsController):
                    return new EventsController(eventService, ticketService, _userContext);

                case nameof(BookingsController):
                    return new BookingsController(bookingService, _userContext);

                case nameof(UsersController):
                    return new UsersController(userService, _userContext);

                default: throw new InvalidOperationException($"Unknown controller {type}.");
            }
        }

    }
}