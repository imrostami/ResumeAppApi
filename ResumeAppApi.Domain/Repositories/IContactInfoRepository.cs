using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.PortfolioAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface IContactInfoRepository:IRepositoryBase<ContactInfo>
{
	Task<ContactInfo> GetBy(string name);
}
