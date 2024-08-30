using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface IBlogArticleCategoryRepository : IRepositoryBase<BlogArticleCategory>
{
	Task<BlogArticleCategory> GetBy(string name);
}
