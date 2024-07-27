namespace CarServiceProject.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;

        public CategoryRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }

        public IQueryable<Category> Categories => _carServiceDbContext.Categories;
    }
}