namespace CarServiceProject.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<InventoryItem>? InventoryItems { get; set; }
    }
}