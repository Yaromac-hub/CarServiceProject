using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Components;

public class CategoryItem : ViewComponent
{

    private readonly ICategoryRepository _categoryRepository;

    public CategoryItem(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _categoryRepository.Categories.OrderBy(c => c.Name);
        return View(categories);
    }
}

