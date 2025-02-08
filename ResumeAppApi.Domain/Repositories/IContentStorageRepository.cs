using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Domain.Repositories
{
	public interface IContentStorageRepository : IRepositoryBase<ContentStorage>
	{
		Task<ContentStorage> GetByName(string name);
	}
}
