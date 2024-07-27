namespace CarServiceProject.Models
{
    public interface IInventoryItemRepository
    {
        IQueryable<InventoryItem> InventoryItems { get; }
        IQueryable<InventoryItem> InventoryItemsOnSale { get; }
    }
}