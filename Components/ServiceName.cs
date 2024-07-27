using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Components;

public class ServiceName : ViewComponent
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceName(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }
    
    public IViewComponentResult Invoke()
    {
        var services = _serviceRepository.Services.OrderBy(c => c.Name);
        return View(services);
    }
}