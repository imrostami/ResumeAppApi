
namespace ResumeAppApi.Infrustructre.Repositories.BlogRepositories;

public class BlogArticleCategoryRepository(AppDbContext context) : IBlogArticleCategoryRepository
{
	public async Task<BlogArticleCategory> CreateAsync(BlogArticleCategory entity)
	{
		context.BlogArticleCategories.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(BlogArticleCategory entity)
	{
		context.BlogArticleCategories.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var category = await context.BlogArticleCategories.FindAsync(id);

		if (category is null)
			return false;

		context.BlogArticleCategories.Remove(category);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<BlogArticleCategory>> GetAll()
		=> await context.BlogArticleCategories.ToListAsync();

	public async Task<BlogArticleCategory?> GetBy(int id)
		=> await context.BlogArticleCategories.FindAsync(id);

	public async Task<BlogArticleCategory?> GetBy(string name) =>
		await context.BlogArticleCategories.FirstOrDefaultAsync(x => x.CategoryName == name);

	public async Task<BlogArticleCategory> UpdateAsync(BlogArticleCategory entity)
	{
		context.BlogArticleCategories.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
