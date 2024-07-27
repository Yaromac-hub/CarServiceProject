namespace CarServiceProject.Models
{
    public class InventoryItem
    {
        public long InventoryItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set;}
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public bool OnSale { get; set;}
        public string? ImageUrl { get; set;}
        public long CategoryId { get; set; }
        public Category Category { get; set; } = default!;

    }
}