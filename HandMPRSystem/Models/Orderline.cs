using System.Text.Json.Serialization;

namespace HandMPRSystem.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;

        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order? Order { get; set; }

        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }

        public int? PantographId { get; set; }
        public virtual Pantograph? Pantograph { get; set; }


    }
}
