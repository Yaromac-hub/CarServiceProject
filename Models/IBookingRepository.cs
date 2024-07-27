namespace CarServiceProject.Models
{
    public interface IBookingRepository
    {
        public IQueryable<Booking> Bookings { get; }
    }
}