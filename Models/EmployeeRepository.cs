using Microsoft.EntityFrameworkCore;

namespace CarServiceProject.Models
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public EmployeeRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<Employee> Employees => _carServiceDbContext.Employees.Include(e => e.ContactInfo);
    }
}