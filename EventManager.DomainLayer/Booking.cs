using System.ComponentModel.DataAnnotations.Schema;

namespace EventManager.DomainLayer
{
    public class Booking
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; }
        public int Qty { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}