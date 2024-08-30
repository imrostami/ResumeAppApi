namespace ResumeAppApi.Infrustructre.Repositories.WorkSampleRepositories;

public class WorkSampleCategoryRepository(AppDbContext context) : IWorkSampleCategoryRepository
{
	public async Task<WorkSampleCategory> CreateAsync(WorkSampleCategory entity)
	{
		context.WorkSampleCategories.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(WorkSampleCategory entity)
	{
		context.WorkSampleCategories.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var catrgory = await context.WorkSampleCategories.FindAsync(id);

		if (catrgory is null)
			return false;

		context.WorkSampleCategories.Remove(catrgory);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<WorkSampleCategory>> GetAll()
		 => await context.WorkSampleCategories.ToListAsync();

	public async Task<WorkSampleCategory?> GetBy(int id)
		=> await context.WorkSampleCategories.FindAsync(id);

	public async Task<WorkSampleCategory?> GetBy(string name)
	{
		return await context.WorkSampleCategories
			.FirstOrDefaultAsync(x => x.CategoryName == name);


	}

	public async Task<WorkSampleCategory> UpdateAsync(WorkSampleCategory entity)
	{
		context.WorkSampleCategories.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
