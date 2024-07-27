namespace CarServiceProject.Models
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public BookingRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<Booking> Bookings => _carServiceDbContext.Bookings;
    }
}