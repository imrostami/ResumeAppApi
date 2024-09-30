namespace ResumeAppApi.Infrustructre.Repositories.WorkSampleRepositories;

public class WorkSampleRepository(AppDbContext context) : IWorkSampleRepository
{
	public async Task<WorkSample> CreateAsync(WorkSample entity)
	{
		context.WorkSamples.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(WorkSample entity)
	{
		context.WorkSamples.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var workSample = await context.WorkSamples.FindAsync(id);

		if (workSample is null)
			return false;

		context.WorkSamples.Remove(workSample);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<WorkSample>> GetAll()
		=> await context.WorkSamples
		.Include(x=>x.WorkSampleCategory)
		.ToListAsync();

	public async Task<WorkSample?> GetBy(int id)
		=> await context.WorkSamples
		.Include(x => x.WorkSampleCategory)
		.FirstOrDefaultAsync(x=>x.SampleId == id);

	public async Task<WorkSample> UpdateAsync(WorkSample entity)
	{
		context.WorkSamples.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
