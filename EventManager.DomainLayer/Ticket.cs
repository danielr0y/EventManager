using System.ComponentModel.DataAnnotations.Schema;

namespace EventManager.DomainLayer
{
    public class Ticket
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public DateTime DateTime { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int RemainingGondolas { get; set; }
    }
}

