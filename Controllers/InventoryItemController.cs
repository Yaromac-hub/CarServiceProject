using Microsoft.AspNetCore.Mvc;
using CarServiceProject.Models;
using CarServiceProject.ViewModels;


namespace CarServiceProject.Controllers
{
    public class InventoryItemController : Controller
    {
        private readonly IInventoryItemRepository _inventoryItemRepository;
        private readonly ICategoryRepository _categoryRepository;
        public InventoryItemController(IInventoryItemRepository inventoryItemRepository, ICategoryRepository categoryRepository)
        {
            _inventoryItemRepository = inventoryItemRepository;
            _categoryRepository = categoryRepository;
        }
        //public IActionResult List() => View(repository.InventoryItems);

        public ViewResult List(string category)
        {
            IQueryable<InventoryItem> inventoryItems;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                inventoryItems = _inventoryItemRepository.InventoryItems.OrderBy(i => i.InventoryItemId);
                currentCategory = "All Categories";
            }
            else
            {
                inventoryItems = _inventoryItemRepository.InventoryItems.Where(p => p.Category.Name == category)
                    .OrderBy(i => i.InventoryItemId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.Name == category)?.Name;
            }
            var viewModel = new InventoryItemListViewModel(inventoryItems, category);

            return View(viewModel);
        }
    }
}