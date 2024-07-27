namespace CarServiceProject.Models
{
    public class ContactInfo
    {
        public long ContactInfoId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}