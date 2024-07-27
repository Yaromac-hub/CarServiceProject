namespace CarServiceProject.Models
{
    public class Booking
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long ServiceId { get; set; }
        public Service Service { get; set; } = default!;
        public string? Message { get; set; }
        public string? BookingDateTime { get; set; }
    }
}