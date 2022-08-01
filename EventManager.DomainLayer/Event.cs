﻿namespace EventManager.DomainLayer
{
    public class Event
    {
        public Event(string name, string excerpt, string description, string category, Status status, string image)
        {
            this.Name = name;
            this.Excerpt = excerpt;
            this.Description = description;
            this.Category = category;
            this.Status = status;
            this.Image = image;
        }
        public string Name { get; set; }
        public string Excerpt { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Status Status { get; set; }
        public string Image { get; set; }

        public string DateRange { get { return "method not yet implemented"; } }
        public string TimeRange { get { return "method not yet implemented"; } }
        public decimal LowestPrice { get { return 0; } }
    }
}