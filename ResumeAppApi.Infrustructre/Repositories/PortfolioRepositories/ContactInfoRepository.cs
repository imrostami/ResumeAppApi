namespace ResumeAppApi.Infrustructre.Repositories.PortfolioRepositories;

public class ContactInfoRepository(AppDbContext context) : IContactInfoRepository
{
    public async Task<ContactInfo> CreateAsync(ContactInfo entity)
    {
        context.Contacts.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(ContactInfo entity)
    {
        context.Contacts.Remove(entity);
        var saveResult = await context.SaveChangesAsync();
        return saveResult >= 1;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var contact = await context.Contacts.FindAsync(id);

        if (contact is null)
            return false;

        context.Contacts.Remove(contact);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<ContactInfo>> GetAll()
        => await context.Contacts.ToListAsync();

    public async Task<ContactInfo?> GetBy(int id)
        => await context.Contacts.FindAsync(id);

	public async Task<ContactInfo?> GetBy(string name) 
        => await context.Contacts
			.FirstOrDefaultAsync(x => x.ContactName == name);






	public async Task<ContactInfo> UpdateAsync(ContactInfo entity)
    {
        context.Contacts.Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}
