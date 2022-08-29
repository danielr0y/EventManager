using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using EventManager.DomainLayer;
using EventManager.Web.Controllers;

namespace EventManager.Web
{
    public class EventManagerControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context) => 
            this.Create(context.ActionDescriptor.ControllerTypeInfo.AsType());

        public void Release(ControllerContext context, object controller) =>
            (controller as IDisposable)?.Dispose();

        public Controller Create(Type type)
        {
            var ticketService = new TicketService();
            var eventService = new EventService(ticketService);
            var bookingService = new BookingService(eventService, ticketService);
            var userService = new UserService();
            var reviewService = new ReviewService(userService);

            // Create Transient components
            switch (type.Name)
            {
                case nameof(HomeController):
                    return new HomeController(eventService);

                case nameof(EventsController):
                    return new EventsController(
                        eventService,
                        ticketService,
                        reviewService);

                case nameof(BookingsController):
                    return new BookingsController(
                        bookingService,
                        eventService,
                        ticketService);

                case nameof(UsersController):
                    return new UsersController(userService);

                default: throw new InvalidOperationException($"Unknown controller {type}.");
            }
        }

    }
}