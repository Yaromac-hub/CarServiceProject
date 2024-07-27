using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarServiceProject.Models
{
    public class CarServiceDbContext : IdentityDbContext
    {
        public CarServiceDbContext(DbContextOptions<CarServiceDbContext> options)
            : base(options) { }
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<ContactInfo> ContactInfos => Set<ContactInfo>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<CustomerFeedback> CustomerFeedbacks => Set<CustomerFeedback>();
        public DbSet<Booking> Bookings => Set<Booking>();
    }

}