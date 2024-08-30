namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class CertificateRepository(AppDbContext context) : ICertificateRepository
{
    public async Task<Certificate> CreateAsync(Certificate entity)
    {
        context.Certificates.Add(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Certificate entity)
    {
        context.Certificates.Remove(entity);
        var saveResult = await context.SaveChangesAsync();
        return saveResult >= 1;

    }

    public async Task<bool> DeleteAsync(int id)
    {
        var certificate = await context.Certificates.FindAsync(id);

        if (certificate is null)
            return false;

        context.Certificates.Remove(certificate);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<Certificate>> GetAll()
        => await context.Certificates.ToListAsync();

    public async Task<Certificate?> GetBy(int id)
        => await context.Certificates.FindAsync(id);

    public async Task<Certificate> UpdateAsync(Certificate entity)
    {
        context.Certificates.Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}
