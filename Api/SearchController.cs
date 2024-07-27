using CarServiceProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Api;

[Route("api/[controller]")]
public class SearchController: ControllerBase
{
    private readonly IInventoryItemRepository _inventoryItemRepository;
    private readonly ICategoryRepository _categoryRepository;
    
    public SearchController(IInventoryItemRepository inventoryItemRepository, ICategoryRepository categoryRepository)
    {
        _inventoryItemRepository = inventoryItemRepository;
        _categoryRepository = categoryRepository;
    }
    
    [HttpPost]
    public ActionResult List([FromBody] SearchParameters searchParameters) 
    {
        IQueryable<InventoryItem> inventoryItems;

        //filter by category
        if (searchParameters.CategoryId==null)
        {
            inventoryItems = _inventoryItemRepository.InventoryItems.OrderBy(i => i.InventoryItemId);
        }
        else
        {
            inventoryItems = _inventoryItemRepository.InventoryItems.Where(p => p.Category.CategoryId == searchParameters.CategoryId)
                .OrderBy(i => i.InventoryItemId);
        }
            
        //filter by name
        if (!string.IsNullOrWhiteSpace(searchParameters.SearchText))
        {
            inventoryItems = inventoryItems.Where(p => p.Name.Contains(searchParameters.SearchText));
        }

        //price filter
        if (searchParameters.MinPrice != null)
        {
            inventoryItems = inventoryItems.Where(p => p.Price >= searchParameters.MinPrice);
        }
            
        //price filter
        if (searchParameters.MaxPrice != null)
        {
            inventoryItems = inventoryItems.Where(p => p.Price <= searchParameters.MaxPrice);
        }
        
        return new JsonResult(inventoryItems);
    }
}