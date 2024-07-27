using CarServiceProject.Models;

namespace CarServiceProject.ViewModels
{
    public class InventoryItemListViewModel
    {
        public IQueryable<InventoryItem> InventoryItems { get; }
        public string? CurrentCategory { get; }

        public InventoryItemListViewModel(IQueryable<InventoryItem> inventoryItems, string? currentcategory)
        {
            InventoryItems = inventoryItems;
            CurrentCategory = currentcategory;
        }
    }
}