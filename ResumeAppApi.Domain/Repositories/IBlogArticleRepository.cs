using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Domain.Repositories;

public interface IBlogArticleRepository : IRepositoryBase<BlogArticle>
{
	List<BlogArticle> GetArticlesBy(string categoryName);
	List<BlogArticle> GetArticlesBy(int categoryId);
}
