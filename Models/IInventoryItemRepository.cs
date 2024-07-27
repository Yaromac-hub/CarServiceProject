namespace CarServiceProject.Models
{
    public interface IInventoryItemRepository
    {
        IQueryable<InventoryItem> InventoryItems { get; }
    }
}