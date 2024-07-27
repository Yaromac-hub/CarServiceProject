using Microsoft.AspNetCore.Mvc;
using CarServiceProject.Models;
using CarServiceProject.ViewModels;

namespace CarServiceProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public IActionResult List(){
            return View(new ServiceViewModel(_serviceRepository.Services.OrderBy(i => i.ServiceId)));
        }

        public IActionResult Details(int id){
            return View(_serviceRepository.GetServiceById(id));
        }
    }
}

