namespace CarServiceProject.Models
{
    public interface IServiceRepository
    {
        IQueryable<Service> Services { get; }

        Service? GetServiceById(int id);
    }
}