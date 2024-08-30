
namespace ResumeAppApi.Infrustructre.Repositories.BlogRepositories;

public class BlogArticleRepository(AppDbContext context) : IBlogArticleRepository
{
	public async Task<BlogArticle> CreateAsync(BlogArticle entity)
	{
		context.BlogArticles.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(BlogArticle entity)
	{
		context.BlogArticles.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var article = await context.BlogArticles.FindAsync(id);

		if (article is null)
			return false;

		context.BlogArticles.Remove(article);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<BlogArticle>> GetAll()
		=> await context.BlogArticles.ToListAsync();

	public List<BlogArticle> GetArticlesBy(string categoryName)
	{
		var articles = context.BlogArticles
			.Where(x => x.BlogArticleCategory.CategoryName == categoryName)
			.ToList();

		return articles;
	}

	public List<BlogArticle> GetArticlesBy(int categoryId)
	{
		var articles = context.BlogArticles
			.Where(x => x.BlogArticleCategory.CategoryId == categoryId)
			.ToList();

		return articles;
	}

	public async Task<BlogArticle?> GetBy(int id)
		=> await context.BlogArticles.FindAsync(id);

	public async Task<BlogArticle> UpdateAsync(BlogArticle entity)
	{
		context.BlogArticles.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
