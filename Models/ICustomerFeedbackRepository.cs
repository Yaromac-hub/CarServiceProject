namespace CarServiceProject.Models
{
    public interface ICustomerFeedbackRepository
    {
        IQueryable<CustomerFeedback> CustomerFeedbacks { get; }
    }
}