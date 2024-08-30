namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class WorkTipsRepository(AppDbContext context) : IWorkTipsRepository
{
	public async Task<WorkTip> CreateAsync(WorkTip entity)
	{
		context.WorkTips.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(WorkTip entity)
	{
		context.WorkTips.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var workTips = await context.WorkTips.FindAsync(id);

		if ( workTips is null)
			return false;

		context.WorkTips.Remove(workTips);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<WorkTip>> GetAll()
		=> await context.WorkTips.ToListAsync();

	public async Task<WorkTip?> GetBy(int id)
		=> await context.WorkTips.FindAsync(id);

	public async Task<WorkTip> UpdateAsync(WorkTip entity)
	{
		context.WorkTips.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
