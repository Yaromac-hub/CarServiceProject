using Microsoft.AspNetCore.Mvc;
using CarServiceProject.Models;
using CarServiceProject.ViewModels;

namespace CarServiceProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryItemRepository repository;
        public HomeController(IInventoryItemRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(new HomeViewModel(repository.InventoryItemsOnSale));
        
    }
}