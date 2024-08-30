
namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class EducationRepository(AppDbContext context) : IEducationRepository
{
    public async Task<Education> CreateAsync(Education entity)
    {
        context.Educations.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(Education entity)
    {
        context.Educations.Remove(entity);
        var saveResult = await context.SaveChangesAsync();
        return saveResult >= 1;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var education = await context.Educations.FindAsync(id);

        if (education is null)
            return false;

        context.Educations.Remove(education);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<Education>> GetAll()
        => await context.Educations.ToListAsync();

    public async Task<Education?> GetBy(int id)
        => await context.Educations.FindAsync(id);

    public async Task<Education> UpdateAsync(Education entity)
    {
        context.Educations.Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}
