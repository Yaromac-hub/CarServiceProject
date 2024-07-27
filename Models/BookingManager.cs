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
        
        public Booking GetBookingById(int id)
        {
            return _carServiceDbContext.Bookings.FirstOrDefault(b => b.Id == id);
        }

        public IQueryable<Booking> GetAllBookings()
        {
            return _carServiceDbContext.Bookings;
        }

        public void UpdateBooking(Booking booking)
        {
            _carServiceDbContext.Bookings.Update(booking);
            _carServiceDbContext.SaveChanges();
        }
        
        public void DeleteBooking(Booking booking)
        {
            _carServiceDbContext.Bookings.Remove(booking);
            _carServiceDbContext.SaveChanges();
        }
    }
}