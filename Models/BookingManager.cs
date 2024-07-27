namespace CarServiceProject.Models
{
    public class BookingManager : IBookingManager
    {
        private readonly CarServiceDbContext _carServiceDbContext;

        public BookingManager(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }

        public void AddBooking(Booking booking)
        {
            _carServiceDbContext.Bookings.Add(booking);
            _carServiceDbContext.SaveChanges();
        }
    }
}