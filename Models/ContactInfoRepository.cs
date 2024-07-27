namespace CarServiceProject.Models
{
    public class ContactInfoRepository : IContactInfoRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public ContactInfoRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<ContactInfo> ContactInfos => _carServiceDbContext.ContactInfos;
    }
}