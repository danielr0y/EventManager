using System;
namespace EventManager.DomainLayer
{
    public class Review
    {
        public Review(User user, DateTime dateTime, string text)
        {
            this.User = user;
            this.DateTime = dateTime;
            this.Text = text;
        }

        public User User { get; }
        public DateTime DateTime { get; }
        public string Text { get; set; }

    }
}

