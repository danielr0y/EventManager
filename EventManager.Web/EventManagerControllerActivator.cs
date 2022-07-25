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
            switch (type.Name)
            {
                case nameof(HomeController):
                    return new HomeController(
                        new EventService());

                case nameof(EventsController):
                    return new EventsController(
                        new EventService());

                default: throw new InvalidOperationException($"Unknown controller {type}.");
            }
        }

    }
}