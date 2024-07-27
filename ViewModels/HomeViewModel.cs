using CarServiceProject.Models;

namespace CarServiceProject.ViewModels{
    public class HomeViewModel
    {
        public IQueryable<InventoryItem> InventoryItemsOnSale { get; }

        public HomeViewModel(IQueryable<InventoryItem> inventoryItems)
        {
            InventoryItemsOnSale = inventoryItems;
        }

    }
}