using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.PortfolioAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface IInformationRepository : IRepositoryBase<Information>
{
	Task<Information> GetFirst();
}
