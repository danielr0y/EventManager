using System;
using EventManager.DomainLayer;
using Microsoft.Extensions.Logging;

namespace EventManager.Web.Models
{
    public class EditEventViewModel : ILayoutViewModel
    {
        public EditEventViewModel(
            ILayoutViewModel layoutViewModel, 
            IEnumerable<string> categories, 
            IEnumerable<string> statuses, 
            Event? Event = null
        )
        {
            IsAuthenticated = layoutViewModel.IsAuthenticated;
            IsAdmin = layoutViewModel.IsAdmin;
            Messages = layoutViewModel.Messages;
            NumberOfMessages = layoutViewModel.NumberOfMessages;

            Categories = categories;
            Statuses = statuses;

            if (Event != null)
            {
                Editing = true;
                Name = Event.Name;
                Category = Event.Category;
                Description = Event.Description;
                Image = Event.Image;
                Status = Event.Status.ToString();
            }
        }

        // ILayoutViewModel
        public bool IsAuthenticated { get; }
        public bool IsAdmin { get; }
        public IEnumerable<MessageViewModel> Messages { get; }
        public int NumberOfMessages { get; }

        public bool Editing { get; } = false;

        public IEnumerable<string> Categories { get; }
        public IEnumerable<string> Statuses { get; }
        public string Name { get; } = "";
        public string Category { get; } = "";
        public string Description { get; } = "";
        public string Image { get; } = "";
        public string Status { get; } = "";
        public string TicketsAsJSON { get; } = "";
    }
}

