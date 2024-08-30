using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.PortfolioAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface ISkillRepository : IRepositoryBase<Skill>
{
	Task<bool> Exist(string name);
}
