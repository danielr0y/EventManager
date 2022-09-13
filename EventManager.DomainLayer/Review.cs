using System;
namespace EventManager.DomainLayer
{
    public class Review
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
    }
}

