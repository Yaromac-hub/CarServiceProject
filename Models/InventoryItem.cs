namespace CarServiceProject.Models
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set;}
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string? ImageUrl { get; set;}
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;

    }
}