using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceProject.Models
{
    public class Service
    {
        public long ServiceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set;}
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
