using CarServiceProject.Models;

namespace CarServiceProject.ViewModels{
    public class HomeViewModel
    {
        public IQueryable<InventoryItem> InventoryItemsOnSale { get; }

        public IQueryable<Service> Services { get; }

        public IQueryable<Employee> Employees { get; }

        public IQueryable<CustomerFeedback> CustomerFeedbacks { get; }

        public HomeViewModel(IQueryable<InventoryItem> inventoryItems, IQueryable<Service> services, IQueryable<Employee> employees, IQueryable<CustomerFeedback> customerFeedbacks )
        {
            InventoryItemsOnSale = inventoryItems;
            Services = services;
            Employees = employees;
            CustomerFeedbacks = customerFeedbacks;
        }

    }
}