using System;
using EventManager.DomainLayer;
using Microsoft.Extensions.Logging;

namespace EventManager.Web.Models
{
    public class EditEventViewModel : ILayoutViewModel
    {
        public EditEventViewModel(ILayoutViewModel layoutViewModel, IEnumerable<string> categories, IEnumerable<string> statuses, Event? Event = null)
        {
            this.IsAuthenticated = layoutViewModel.IsAuthenticated;
            this.IsAdmin = layoutViewModel.IsAdmin;
            this.Messages = layoutViewModel.Messages;
            this.NumberOfMessages = layoutViewModel.NumberOfMessages;

            this.Categories = categories;
            this.Statuses = statuses;
            this.Category = Event.Category;
            this.Description = Event.Description;
            this.Image = Event.Image;
        }

        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        public IEnumerable<string> Categories { get; }
        public IEnumerable<string> Statuses { get; }
        public string Name { get; }
        public string Category { get; }
        public string Description { get; }
        public string Image { get; }
        public string Status { get; }
        public string TicketsAsJSON { get; }

    }
}

