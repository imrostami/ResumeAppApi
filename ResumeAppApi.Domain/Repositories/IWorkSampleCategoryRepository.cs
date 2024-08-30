using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.WorkSampleAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface IWorkSampleCategoryRepository : IRepositoryBase<WorkSampleCategory>
{
    Task<WorkSampleCategory>? GetBy(string name);
}
