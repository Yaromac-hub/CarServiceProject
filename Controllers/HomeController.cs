using Microsoft.AspNetCore.Mvc;
using CarServiceProject.Models;
using CarServiceProject.ViewModels;

namespace CarServiceProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryItemRepository _inventoryRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICustomerFeedbackRepository _customerFeedbackRepository;


        public HomeController(IInventoryItemRepository inventoryRepository, IServiceRepository serviceRepository, IEmployeeRepository employeeRepository, ICustomerFeedbackRepository customerFeedbackRepository)
        {
            _inventoryRepository = inventoryRepository;
            _serviceRepository = serviceRepository;
            _employeeRepository = employeeRepository;
            _customerFeedbackRepository = customerFeedbackRepository;
        }

        public IActionResult Index() =>
        View(new HomeViewModel(_inventoryRepository.InventoryItemsOnSale,
         _serviceRepository.Services, _employeeRepository.Employees,
         _customerFeedbackRepository.CustomerFeedbacks));

    }
}