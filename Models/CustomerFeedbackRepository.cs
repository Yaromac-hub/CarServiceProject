namespace CarServiceProject.Models
{
    public class CustomerFeedbackRepository: ICustomerFeedbackRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public CustomerFeedbackRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<CustomerFeedback> CustomerFeedbacks => _carServiceDbContext.CustomerFeedbacks;
    }
}