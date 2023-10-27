using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandMPRSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Description { get; set; } = string.Empty;
        [StringLength(15)]
        public string Status { get; set; } = "NEW";
        [StringLength(15)]
        public string DeliveryMode { get; set; } = "PickUp";
        public DateTime? DropOff { get; set; } = DateTime.Now;
        public DateTime? CompletionDate { get; set; } = DateTime.Today.AddDays(42);
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;

        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }

        
    }
}
