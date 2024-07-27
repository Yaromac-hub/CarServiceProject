namespace CarServiceProject.Models
{
    public interface IBookingManager
    {
        public void AddBooking(Booking booking);
        public Booking GetBookingById(int id);
        public void UpdateBooking(Booking booking);
        public void DeleteBooking(Booking booking);
        public IQueryable<Booking> GetAllBookings();
    }
}