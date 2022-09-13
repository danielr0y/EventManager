using System;
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
            
            var userRepository = new UserRepository(dbContext);
            var eventRepository = new EventRepository(dbContext);
            var ticketRepository = new TicketRepository(dbContext);
            var bookingRepository = new BookingRepository(dbContext);
            
            var userService = new UserService(userRepository, _userContext);
            var eventService = new EventService(eventRepository);
            var ticketService = new TicketService(ticketRepository);
            var bookingService = new BookingService(bookingRepository);


            switch (type.Name)
            {
                case nameof(HomeController):
                    return new HomeController(eventService);

                case nameof(EventsController):
                    return new EventsController(eventService, ticketService);

                case nameof(BookingsController):
                    return new BookingsController(bookingService, userService);

                case nameof(UsersController):
                    return new UsersController(userService);

                default: throw new InvalidOperationException($"Unknown controller {type}.");
            }
        }

    }
}