using System;
namespace EventManager.DomainLayer
{
    public class Ticket
    {
        public Ticket(DateTime dateTime, decimal price, int remainingGondolas)
        {
            this.DateTime = dateTime;
            this.Price = price;
            this.RemainingGondolas = remainingGondolas;
        }

        public int Id { get; set; } = 100;
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
        public int RemainingGondolas { get; set; }
    }
}

