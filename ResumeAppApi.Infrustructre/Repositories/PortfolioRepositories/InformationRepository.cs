namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class InformationRepository(AppDbContext context) : IInformationRepository
{
	public async Task<Information> CreateAsync(Information entity)
	{
		context.Informations.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(Information entity)
	{
		context.Informations.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var info = await context.Informations.FindAsync(id);

		if (info is null)
			return false;

		context.Informations.Remove(info);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<IEnumerable<Information>> GetAll()
		=> await context.Informations.ToListAsync();

	public async Task<Information?> GetBy(int id)
		=> await context.Informations.FindAsync(id);

	public async Task<Information?> GetFirst() 
		=> await context.Informations.FirstOrDefaultAsync();

	public async Task<Information> UpdateAsync(Information entity)
	{
		context.Informations.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
