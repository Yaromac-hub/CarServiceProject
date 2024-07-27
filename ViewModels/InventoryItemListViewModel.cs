using CarServiceProject.Models;

namespace CarServiceProject.ViewModels
{
    public class InventoryItemListViewModel
    {
        public IQueryable<InventoryItem> InventoryItems { get; }

        public InventoryItemListViewModel(IQueryable<InventoryItem> inventoryItems)
        {
            InventoryItems = inventoryItems;
        }
    }
}