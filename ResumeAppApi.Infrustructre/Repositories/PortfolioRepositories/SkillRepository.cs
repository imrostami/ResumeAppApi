namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class SkillRepository(AppDbContext context) : ISkillRepository
{
	public async Task<Skill> CreateAsync(Skill entity)
	{
		context.Skills.Add(entity);
		await context.SaveChangesAsync();
		return entity;
	}

	public async Task<bool> DeleteAsync(Skill entity)
	{
		context.Skills.Remove(entity);
		var saveResult = await context.SaveChangesAsync();
		return saveResult >= 1;
	}

	public async Task<bool> DeleteAsync(int id)
	{
		var skill = await context.Skills.FindAsync(id);

		if (skill is null)
			return false;

		context.Skills.Remove(skill);
		await context.SaveChangesAsync();

		return true;
	}

	public async Task<bool> Exist(string name)
		=> await context.Skills.AnyAsync(x=>x.Name == name);

	public async Task<IEnumerable<Skill>> GetAll()
		=> await context.Skills.ToListAsync();

	public async Task<Skill?> GetBy(int id)
		=> await context.Skills.FindAsync(id);
	public async Task<Skill> UpdateAsync(Skill entity)
	{
		context.Skills.Update(entity);
		await context.SaveChangesAsync();
		return entity;
	}
}
