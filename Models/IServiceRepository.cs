namespace CarServiceProject.Models
{
    public interface IServiceRepository
    {
        IQueryable<Service> Services { get; }
    }
}