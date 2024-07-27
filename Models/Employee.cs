namespace CarServiceProject.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set;}
        public string? Position { get; set; }
        public int ContactInfoId { get; set; }
        public ContactInfo ContactInfo { get; set; } = default!;
    }
}
