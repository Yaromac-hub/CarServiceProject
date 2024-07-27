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

        public ViewResult List(int? categoryId, string? searchText, decimal? minPrice, decimal? maxPrice)
        {
            IQueryable<InventoryItem> inventoryItems;

            if (categoryId==null)
            {
                inventoryItems = _inventoryItemRepository.InventoryItems.OrderBy(i => i.InventoryItemId);
            }
            else
            {
                inventoryItems = _inventoryItemRepository.InventoryItems.Where(p => p.Category.CategoryId == categoryId)
                    .OrderBy(i => i.InventoryItemId);
            }
            
            //filter by name
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                inventoryItems = inventoryItems.Where(p => p.Name.Contains(searchText));
            }

            //price filter
            if (minPrice != null)
            {
                inventoryItems = inventoryItems.Where(p => p.Price >= minPrice);
            }
            
            //price filter
            if (maxPrice != null)
            {
                inventoryItems = inventoryItems.Where(p => p.Price <= maxPrice);
            }
            
            var viewModel = new InventoryItemListViewModel(inventoryItems);

            return View(viewModel);
        }
        
        public IActionResult Search()
        {
            return View();
        }
        
        public IActionResult Details(int id){
            return View(_inventoryItemRepository.GetInventoryItemById(id));
        }
    }
}