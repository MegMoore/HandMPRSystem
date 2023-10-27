using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HandMPRSystem.Models
{
    [Index("PartNbr", IsUnique = true)]
    public class Pantograph
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        [StringLength(30)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; } = 0;
        [StringLength(30)]
        public string PartNbr { get; set; } = string.Empty;
        [StringLength(255)]
        public string? PhotoPath { get; set; } = null;

    }
}
