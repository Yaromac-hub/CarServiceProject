namespace CarServiceProject.Models
{
    public interface IContactInfoRepository
    {
        IQueryable<ContactInfo> ContactInfos { get; }
    }
}