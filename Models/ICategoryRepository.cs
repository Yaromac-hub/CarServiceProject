namespace CarServiceProject.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
    }
}