namespace CarServiceProject.Models
{
    public class ServiceRepository: IServiceRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public ServiceRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<Service> Services => _carServiceDbContext.Services;
    }
}