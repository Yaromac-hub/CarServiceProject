using CarServiceProject.Models;

namespace CarServiceProject.ViewModels{
    public class ServiceViewModel
    {
        public IQueryable<Service> Services { get; }

        public ServiceViewModel(IQueryable<Service> services)
        {
            Services = services;
        }

    }
}